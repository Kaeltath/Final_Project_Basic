using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class PathUpdater
    {
        public class TreeConstructorEventArgs : EventArgs
        {
            public List<string> Path
            {
                set;get;
            }            
        }

       public event EventHandler<TreeConstructorEventArgs> TreeConstruckt;

       public List<string> path = new List<string>();

       public List<string> PathUpdate{             
            get { return path; }
        }


       public void Add_path(string add)
       {
           if (path.Count() > 0)
           {
               for (int i = 0; i < path.Count; i++)
               {
                   try
                   {
                       if (path[i].Contains(add) || add.Contains(path[i]))
                       {
                           throw new Exception();
                       }
                       path.Add(add);                       
                       Update_Config();

                   }
                   catch (Exception)
                   {
                       return;
                   }
               }              
           }
           path.Add(add);
           Update_Config();
       }
       

        public void Remove_path (string rem)
       {
           path.Remove(rem);
           Update_Config();
       }

       public void Update_Config()
       {
           List<string> temp = new List<string>();
           for (int i = 0; i < path.Count(); i++)
           {
               if (!string.IsNullOrEmpty(path[i])) 
               {
                   temp.Add(path[i]);
               }           
           }
           path = temp;
           if (TreeConstruckt != null)
           {
               TreeConstructorEventArgs Args = new TreeConstructorEventArgs();
               Args.Path = this.path;
               TreeConstruckt(this, Args);
           }
       }
        
    }
}
