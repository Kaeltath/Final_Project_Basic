using Microsoft.Synchronization.Files;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSync;

namespace WindowsFormsApplication1
{
    public class SyncronizationController
    {
        //StreamWriter streamWriter = File.AppendText("D:\\SyncLog.txt");

        private FileSyncScopeFilter filter = new FileSyncScopeFilter();

        private string[] rootPathsArray = new string[] { "D:\\1", "D:\\2", "D:\\3", "D:\\4" };

        private bool isSyncInProgress = false;

        public static string logLocation = "D:\\Logs\\SyncLog.txt";

        private bool isOneWaySyncronization = true;

        PathUpdater Path_to_root = new PathUpdater();        

        public List<String> Path;
        
        public event EventHandler TreeConstrucktForForm;


        public void AddPath(string inp)
        {
            Path_to_root.TreeConstruckt += this.EventCreate; 
            Path_to_root.Add_path(inp);
            
            
            
            
        }

        public void EventCreate(object o, EventArgs arg)
        {
            this.Path = Path_to_root.path;
            Path_to_root.TreeConstruckt += this.EventCreate;                
            TreeConstrucktForForm(this, EventArgs.Empty);
        }
        
        public void RemPath(string rem)
        {
            Path_to_root.Remove_path(rem);
        }


        //Parses paths for folders
        public string parseFolderPath(string rootDirectoryPath)
        {
            if (Directory.Exists(rootDirectoryPath))
            {

            }
            //Busines logic
            throw new NotImplementedException();
        }

        public void updateRootPaths(string[] parsedRootPathsArray)
        {
            //Busines logic
            throw new NotImplementedException();
        }

        //Converts string from text box in UI to string array of dedicated filters, by ';' and ',' separators
        public string[] parseSyncFiltersFromView(string syncFiltersFromView)
        {
            char[] delimitersForFiltersParsing = new char[] {',', ';' };
            string[] filtersArray = syncFiltersFromView.Split(delimitersForFiltersParsing, StringSplitOptions.RemoveEmptyEntries);

            Log("Filter for syncronization has been sucessfully parsed");                                  

            return filtersArray;
        }

        //Re-Creates includeFiles and excludeFiles filters according to parsed from UI values
        public void updateSyncFilters(string[] excludeFiltersArray, string[] includeFilterArray)
        {
            if (excludeFiltersArray != null && excludeFiltersArray.Length > 0)
            {
                filter.FileNameExcludes.Clear();

                Log("'Exclude' filter has been cleared");

                for (int i = 0; i < excludeFiltersArray.Length; i++)
                {
                    if (!String.IsNullOrEmpty(excludeFiltersArray[i]))
                    {
                        filter.FileNameExcludes.Add(excludeFiltersArray[i]);
                    }
                }

                Log("'Exclude' filter has been updated with parsed values");                
            }
            else
            {
                Log("'Exclude' filter is empty");
            }

            if (includeFilterArray != null && includeFilterArray.Length > 0)
            {
                filter.FileNameIncludes.Clear();

                Log("'Include' filter has been cleared");

                for (int i = 0; i < includeFilterArray.Length; i++)
                {
                    if (!String.IsNullOrEmpty(includeFilterArray[i]))
                    {
                        filter.FileNameIncludes.Add(includeFilterArray[i]);
                    }                    
                }

                Log("'Exclude' filter has been updated with parsed values");
            }
            else
            {
                Log("'Include' filter is empty");
            }
        }

        //Runs sycronization of folders provided
        public void RunSyncronization(bool syncronizationDirection)
        {


            if (!isSyncInProgress)
            {
                isSyncInProgress = true;

                try
                {
                    FoldersSyncronizator folderSyncronizator = new FoldersSyncronizator();

                    folderSyncronizator.Filter = filter;
                    folderSyncronizator.RootPathsArray = rootPathsArray;

                    folderSyncronizator.DetectChangesInAllRootFolders();

                    if (!syncronizationDirection)
                    {
                        folderSyncronizator.syncAllFoldersTwoWays();
                    }
                    else
                    {
                        folderSyncronizator.syncAllFoldersTwoWays();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    isSyncInProgress = false;
                }                
            }
            else
            {
                Log("New cycle of syncronization has not been started, since the previous one is still in progress");
            }            
        }
        
        //Logger
        public static void Log(string logMessage)
        {

            using (StreamWriter streamWriter = File.AppendText(logLocation))
            {
                streamWriter.WriteLine("{0} {1} : {2}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString(), logMessage);
                streamWriter.WriteLine("-------------------------------");
            }
        }






    }
}
