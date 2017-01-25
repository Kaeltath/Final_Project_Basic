using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;

namespace WindowsFormsApplication1
{
    class TreeAddNode
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(@"E:/");
        List<string> path = new List<string> { "D:\\"};
        

        public TreeAddNode(List<string> inp_str)
        {
            this.path = inp_str;
            //DirectoryInfo inp_dir = new DirectoryInfo(@inp_str);
            //directoryInfo = inp_dir;
        }

        public void create_tree(TreeView treeView)
        {
            int i = 0;
            while (i < path.Count())
            {
                string dir_path = path[i];
                directoryInfo = new DirectoryInfo(@dir_path);
                i++;
                if (directoryInfo.Exists)
                    
                {

                    try
                    {
                        treeView.Nodes.Add(LoadDirectory(directoryInfo));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private TreeNode LoadDirectory(DirectoryInfo dir)
        {
            if (!dir.Exists)
                return null;

            TreeNode output = new TreeNode(dir.FullName.ToString(), 0, 0);

            foreach (var subDir in dir.GetDirectories())
            {
                try
                {
                    output.Nodes.Add(LoadDirectory(subDir));
                }
                catch (IOException)
                {
                    //handle error
                }
                catch { }
            }

            foreach (var file in dir.GetFiles())
            {
                if (file.Exists)
                {
                    output.Nodes.Add(file.Name);
                }
            }

            return output;
        }
    }
}
