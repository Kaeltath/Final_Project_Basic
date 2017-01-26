using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Files;
using System.Windows;
using static WindowsFormsApplication1.SyncronizationController;

namespace TestSync
{
    public class FoldersSynchronizator
    {
        public string[] RootPathsArray { private set; get; }
        public FileSyncScopeFilter Filter { private set; get; } //Obsolete
        public List<string> RootPathsList = new List<string>();
         


        public FoldersSynchronizator(List<string> rootPathsList, FileSyncScopeFilter filter)
        {
            RootPathsList = rootPathsList;
            Filter = filter;
        }



        public event EventHandler<SynchronizationEventArgs> OnAppliedChangeEventEventHandler;
        public event EventHandler<SynchronizationEventArgs> OnSkippedChangeEventEventHandler;

        

        //Creates/updates metadata file in root folders for synchronization
        public void DetectChangesInAllRootFolders()
        {
            FileSyncProvider provider = null;

            try
            {
                for (int i = 0; i < RootPathsList.Count; i++)
                {
                    provider = new FileSyncProvider(RootPathsList[i], Filter, FileSyncOptions.None);
                    provider.DetectChanges();
                }
            }
            catch (Exception e)
            {                
                throw e;
            }
            finally
            {
                if (provider != null)
                {
                    provider.Dispose();
                }
            }
        }

        //Sync folders by downloading all changes to first folder from the other ones (by pairs) and then uploading aggregated changes from first folder to the others (by pairs)
        public void syncAllFoldersTwoWays()
        {
            if (RootPathsList != null && RootPathsList.Count > 1)
            {                
                for (int i = 1; i < RootPathsList.Count; i++)
                {
                    syncTwoFoldersOneWayDownload(RootPathsList[0], RootPathsList[i]);
                }                
                for (int i = 1; i < RootPathsList.Count; i++)
                {
                    syncTwoFoldersOneWayUpload(RootPathsList[0], RootPathsList[i]);
                }
            }
            else
            {
                throw new Exception("Exception: List of paths is null or contain less than 2 pathes");
            }
        }
        
        //Uploads shanges from source to destination
        private void syncTwoFoldersOneWayUpload(string sourceRootPath, string destinationRootPath)
        {
            FileSyncProvider sourceProvider = null;
            FileSyncProvider destinationProvider = null;            
            
            try
            {
                sourceProvider = new FileSyncProvider(sourceRootPath, Filter, FileSyncOptions.None);
                destinationProvider = new FileSyncProvider(destinationRootPath, Filter, FileSyncOptions.None);

                destinationProvider.AppliedChange += FolderSynchronizator_OnAppliedChangeEventHandler;
                destinationProvider.SkippedChange += FolderSynchronizator_OnSkippedChangeEventHandler;

                SyncOrchestrator orchrstrator = new SyncOrchestrator();
                orchrstrator.Direction = SyncDirectionOrder.Upload;
                orchrstrator.LocalProvider = sourceProvider;
                orchrstrator.RemoteProvider = destinationProvider;

                orchrstrator.Synchronize();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sourceProvider != null)
                {
                    sourceProvider.Dispose();
                }
                if (destinationProvider != null)
                {
                    destinationProvider.Dispose();
                }
            }

            destinationProvider.AppliedChange -= FolderSynchronizator_OnAppliedChangeEventHandler;
            destinationProvider.SkippedChange -= FolderSynchronizator_OnSkippedChangeEventHandler;
            
        }
        
        //Downloads changes from destination to source
        private void syncTwoFoldersOneWayDownload(string sourceRootPath, string destinationRootPath)
        {
            FileSyncProvider sourceProvider = null;
            FileSyncProvider destinationProvider = null;

            

            try
            {
                sourceProvider = new FileSyncProvider(sourceRootPath, Filter, FileSyncOptions.None);
                destinationProvider = new FileSyncProvider(destinationRootPath, Filter, FileSyncOptions.None);

                destinationProvider.AppliedChange += FolderSynchronizator_OnAppliedChangeEventHandler;
                destinationProvider.SkippedChange += FolderSynchronizator_OnSkippedChangeEventHandler;

                SyncOrchestrator orchrstrator = new SyncOrchestrator();
                orchrstrator.Direction = SyncDirectionOrder.Download;
                orchrstrator.LocalProvider = sourceProvider;
                orchrstrator.RemoteProvider = destinationProvider;

                orchrstrator.Synchronize();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sourceProvider != null)
                {
                    sourceProvider.Dispose();
                }
                if (destinationProvider != null)
                {
                    destinationProvider.Dispose();
                }
            }

            destinationProvider.AppliedChange -= FolderSynchronizator_OnAppliedChangeEventHandler;
            destinationProvider.SkippedChange -= FolderSynchronizator_OnSkippedChangeEventHandler;

        }



        //Creates string message about files that were affected by the synchronization session
        //Sends event
        private void FolderSynchronizator_OnAppliedChangeEventHandler(object sender, AppliedChangeEventArgs args)
        {
            string message;

            switch (args.ChangeType)
            {
                case ChangeType.Create:
                    message = String.Format("-- Applied CREATE for file " + args.NewFilePath);
                    break;
                case ChangeType.Delete:
                    message = String.Format("-- Applied DELETE for file " + args.OldFilePath);
                    break;
                case ChangeType.Update:
                    message = String.Format("-- Applied OVERWRITE for file " + args.OldFilePath);
                    break;
                case ChangeType.Rename:
                    message = String.Format("-- Applied RENAME for file " + args.OldFilePath +
                                      " as " + args.NewFilePath);
                    break;
                default:
                    message = "Error: message was not agged by 'OnAppliedChange' event handler";
                    break;
            }

            if (OnAppliedChangeEventEventHandler != null)
            {
                OnAppliedChangeEventEventHandler(this, new SynchronizationEventArgs(message));
            }
        }

        //Creates string message about error information for any changes that were skipped
        //Sends event
        public void FolderSynchronizator_OnSkippedChangeEventHandler(object sender, SkippedChangeEventArgs args)
        {
            string message = String.Format("-- Skipped applying " + args.ChangeType.ToString().ToUpper()
                  + " for " + (!string.IsNullOrEmpty(args.CurrentFilePath) ? args.CurrentFilePath : args.NewFilePath) + " due to error");

            if (args.Exception != null)
            {
                message = String.Format(message + "   [" + args.Exception.Message + "]");
            }

            if (OnSkippedChangeEventEventHandler != null)
            {
                OnSkippedChangeEventEventHandler(this, new SynchronizationEventArgs(message));
            }
        }
        
    }
}
