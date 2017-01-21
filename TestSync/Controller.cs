using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Files;

namespace TestSync
{
    public class SyncronizationController
    {
        private FileSyncScopeFilter filter = new FileSyncScopeFilter();
        private string[] rootPathsArray = new string[] { "D:\\1", "D:\\2", "D:\\3"};

        private bool isSyncInProgress = false;



        //Converts string from text box in UI to string array of dedicated filters, by ';' separator
        public string[] parseSyncFiltersFromView(string syncFiltersFromView)
        {
            string[] filtersArray = null;

            //Business logic
            filtersArray = new string[1] { "*.rar"};

            return filtersArray;
        }

        //Re-Creates includeFiles and excludeFiles filters according to parsed from UI values
        public void updateSyncFilters(string[] excludeFiltersArray, string[] includeFilterArray)
        {
            if (excludeFiltersArray != null && excludeFiltersArray.Length > 0)
            {
                filter.FileNameExcludes.Clear();
                for (int i = 0; i < excludeFiltersArray.Length; i++)
                {
                    filter.FileNameExcludes.Add(excludeFiltersArray[i]);
                }
            }
            if (includeFilterArray != null && includeFilterArray.Length > 0)
            {
                filter.FileNameIncludes.Clear();
                for (int i = 0; i < includeFilterArray.Length; i++)
                {
                    filter.FileNameIncludes.Add(includeFilterArray[i]);
                }
            }
        }

        //Runs sycronization of folders provided
        public void RunSyncronization()
        {
            if (!isSyncInProgress)
            {
                isSyncInProgress = true;

                FoldersSyncronizator folderSyncronizator = new FoldersSyncronizator();

                folderSyncronizator.Filter = filter;
                folderSyncronizator.RootPathsArray = rootPathsArray;

                folderSyncronizator.DetectChangesInAllRootFolders();
                folderSyncronizator.syncAllFolders();

                isSyncInProgress = false;
            }
            else
            {
                Console.WriteLine("The sync is still in progress");
            }            
        }



    }
}
