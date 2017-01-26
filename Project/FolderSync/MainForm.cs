using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form

    {
        //PathUpdater add = new PathUpdater();       
        private string master_path;
        private FormWindowState _OldFormState;
        SyncronizationController Controller = new SyncronizationController();

        public MainForm()
        {

            InitializeComponent();
            InitializeTimer();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
           
            //controller.updateSyncFilters(controller.parseSyncFiltersFromView(testFilter1), controller.parseSyncFiltersFromView(testFilter2));
            
           

        }
        
      

        private void button1_Click(object sender, EventArgs e)
        {
            FileMaskFrom FileMask = new FileMaskFrom();
            FileMask.Show();    
        }

        private void Schedule_Button_Click(object sender, EventArgs e)
        {
            ScheduleForm SchForm = new ScheduleForm();
            SchForm.Show();
        }      

        private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {                
                if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
                {                    
                    _OldFormState = WindowState;                   
                    WindowState = FormWindowState.Minimized;
                    this.ShowInTaskbar = false;
                   
                }
                else
                {                    
                    Show();                    
                    WindowState = _OldFormState;
                    this.ShowInTaskbar = true;
                }
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                Hide();

            }
        }

       

       

        private void Master_select_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog AddFolder = new FolderBrowserDialog();
            AddFolder.ShowDialog();
            master_path = AddFolder.SelectedPath;
            if (String.IsNullOrEmpty(master_path))
            {
                return;
            }           
        }

       

        private void ChangeMaster_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog AddFolder = new FolderBrowserDialog();
            AddFolder.ShowDialog();
            master_path = AddFolder.SelectedPath;
        }

        private void MasterContent_Button_Click(object sender, EventArgs e)
        {
            FolderContent FC = new FolderContent(master_path);
            FC.Show();
        }

        private void AddNode_Client_Click(object sender, EventArgs e)
        {
            Controller.TreeConstrucktForForm += Construction;            
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string path = fbd.SelectedPath;
            Controller.AddPath(path);  

        }

        private void RemoveNode_Client_button_Click(object sender, EventArgs e)
        {
            Controller.TreeConstrucktForForm += Construction;
            Controller.RemPath(treeView_Client.SelectedNode.Text);

          //  add.Remove();
        //    try
        //    {
        //        if (treeView_Client.SelectedNode.Parent == null)
        //        {
        //            treeView_Client.Nodes.Remove(treeView_Client.SelectedNode);                   
        //        }
        //        else
        //        {
        //            Exception ex = new Exception();
        //            throw ex;
        //        }
                
        //    }
        //    catch (Exception )
        //    {
        //        return;
                
        //    }
        }
        private void InitializeTimer()
        {
            // Call this procedure when the application starts.
            // Set to 1 second.
            int min = 60000;
            Timer1.Interval = 5*min;
            Timer1.Tick += new EventHandler(Timer1_Tick);

            // Enable timer.
            Timer1.Enabled = true;
            
        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            //treeView_Client.Nodes.Clear();
            //List<string> path = { "D:/1", "D:/2", "D:/3" };
            //TreeAddNode createTree = new TreeAddNode(path);
            //createTree.create_tree(treeView_Client);
        }

        private void Sync_Button_Click(object sender, EventArgs e)
        {            
            Controller.RunSyncronization();            
        }

        //private void TreeConstructonEvent() 
        //{
            
        //}

        private void Construction(object obj, EventArgs arg) 
        {
            
            treeView_Client.Nodes.Clear();
            List<string> path = Controller.Path;
            TreeAddNode createTree = new TreeAddNode(path);
            createTree.create_tree(treeView_Client);
        }
        
    }
}
