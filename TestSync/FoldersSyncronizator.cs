using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Files;

namespace TestSync
{
    public class FoldersSyncronizator
    {
        public string[] RootPathsArray { set; get; }
        public FileSyncScopeFilter Filter { set; get; }

        public FoldersSyncronizator()
        { }

        
        public void DetectChangesInAllRootFolders()
        {
            FileSyncProvider provider = null;

            try
            {
                for (int i = 0; i < RootPathsArray.Length; i++)
                {
                    provider = new FileSyncProvider(RootPathsArray[i], Filter, FileSyncOptions.None);
                    provider.DetectChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception from 'DetectChangesInAllRootFolders': {0}", e.ToString());
                //throw e;
            }
            finally
            {
                if (provider != null)
                {
                    provider.Dispose();
                }
            }

        }

        public void DetectChangesInAllRootFolders(string[] rootPathsArray, FileSyncScopeFilter filter)
        {
            FileSyncProvider provider = null;

            try
            {
                for (int i = 0; i < RootPathsArray.Length; i++)
                {
                    provider = new FileSyncProvider(rootPathsArray[i], filter, FileSyncOptions.None);
                    provider.DetectChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception from 'DetectChangesInAllRootFolders': {0}", e.ToString());
                //throw e;
            }
            finally
            {
                if (provider != null)
                {
                    provider.Dispose();
                }
            }

        }
        
        public void syncAllFolders()
        {
            for (int i = 1; i < RootPathsArray.Length; i++)
            {
                syncTwoFoldersOneWayDownload(RootPathsArray[0], RootPathsArray[i]);
            }
            for (int i = 1; i < RootPathsArray.Length; i++)
            {
                syncTwoFoldersOneWayUpload(RootPathsArray[0], RootPathsArray[i]);
            }
        }

        public void syncAllFolders(string[] rootPathsArray, FileSyncScopeFilter filter)
        {
            for (int i = 1; i < rootPathsArray.Length; i++)
            {
                syncTwoFoldersOneWayDownload(RootPathsArray[0], RootPathsArray[i],filter);
            }
            for (int i = 1; i < rootPathsArray.Length; i++)
            {
                syncTwoFoldersOneWayUpload(RootPathsArray[0], RootPathsArray[i], filter);
            }
        }

        private void syncTwoFoldersOneWayUpload(string sourceRootPath, string destinationRootPath)
        {
            FileSyncProvider sourceProvider = null;
            FileSyncProvider destinationProvider = null;

            try
            {
                sourceProvider = new FileSyncProvider(sourceRootPath, Filter, FileSyncOptions.None);
                destinationProvider = new FileSyncProvider(destinationRootPath, Filter, FileSyncOptions.None);

                SyncOrchestrator orchrstrator = new SyncOrchestrator();
                orchrstrator.Direction = SyncDirectionOrder.Upload;
                orchrstrator.LocalProvider = sourceProvider;
                orchrstrator.RemoteProvider = destinationProvider;

                orchrstrator.Synchronize();
            }
            catch (Exception)
            {

                throw;
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
        }

        private void syncTwoFoldersOneWayUpload(string sourceRootPath, string destinationRootPath, FileSyncScopeFilter filter)
        {
            FileSyncProvider sourceProvider = null;
            FileSyncProvider destinationProvider = null;

            try
            {
                sourceProvider = new FileSyncProvider(sourceRootPath, filter, FileSyncOptions.None);
                destinationProvider = new FileSyncProvider(destinationRootPath, filter, FileSyncOptions.None);

                SyncOrchestrator orchrstrator = new SyncOrchestrator();
                orchrstrator.Direction = SyncDirectionOrder.Upload;
                orchrstrator.LocalProvider = sourceProvider;
                orchrstrator.RemoteProvider = destinationProvider;

                orchrstrator.Synchronize();
            }
            catch (Exception)
            {

                throw;
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
        }

        private void syncTwoFoldersOneWayDownload(string sourceRootPath, string destinationRootPath)
        {
            FileSyncProvider sourceProvider = null;
            FileSyncProvider destinationProvider = null;

            try
            {
                sourceProvider = new FileSyncProvider(sourceRootPath, Filter, FileSyncOptions.None);
                destinationProvider = new FileSyncProvider(destinationRootPath, Filter, FileSyncOptions.None);

                SyncOrchestrator orchrstrator = new SyncOrchestrator();
                orchrstrator.Direction = SyncDirectionOrder.Download;
                orchrstrator.LocalProvider = sourceProvider;
                orchrstrator.RemoteProvider = destinationProvider;

                orchrstrator.Synchronize();
            }
            catch (Exception)
            {

                throw;
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
        }

        private void syncTwoFoldersOneWayDownload(string sourceRootPath, string destinationRootPath, FileSyncScopeFilter filter)
        {
            FileSyncProvider sourceProvider = null;
            FileSyncProvider destinationProvider = null;

            try
            {
                sourceProvider = new FileSyncProvider(sourceRootPath, filter, FileSyncOptions.None);
                destinationProvider = new FileSyncProvider(destinationRootPath, filter, FileSyncOptions.None);

                SyncOrchestrator orchrstrator = new SyncOrchestrator();
                orchrstrator.Direction = SyncDirectionOrder.Download;
                orchrstrator.LocalProvider = sourceProvider;
                orchrstrator.RemoteProvider = destinationProvider;

                orchrstrator.Synchronize();
            }
            catch (Exception)
            {

                throw;
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
        }



    }
}
