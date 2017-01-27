﻿using System;
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
        SyncronizationController controller = new SyncronizationController();        
        private int reccurency = 1440;

        public SyncronizationController Controller 
        {
            set { controller = value; }
            get { return controller; }
        }

        public MainForm()
        {

            InitializeComponent();
            InitializeTimer();
        }

        public void UpdateFilters(object sender, WindowsFormsApplication1.FileMaskFrom.FilterChangeEventArgs Args) 
        {
            Controller.blacklist = Args.Black;
            controller.whitelist = Args.White;
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            FileMaskFrom FileMask = new FileMaskFrom(Controller.blacklist, controller.whitelist);
            FileMask.FilterUpdateEventHendler += this.UpdateFilters;
            FileMask.ShowDialog();      
        }

        private void Schedule_Button_Click(object sender, EventArgs e)
        {
            ScheduleForm SchForm = new ScheduleForm(reccurency);
            SchForm.ScheduleEventHendler += schedule_hendler;
            SchForm.ShowDialog();
        }

        public void schedule_hendler(object sender, WindowsFormsApplication1.ScheduleForm.ScheduleEventArgs Args) 
        {
            reccurency = Args.timer;
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
            controller.TreeConstrucktForForm += Construction;            
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string path = fbd.SelectedPath;
            controller.AddPath(path);  

        }

        private void RemoveNode_Client_button_Click(object sender, EventArgs e)
        {
            controller.TreeConstrucktForForm += Construction;
                        
           try
            {
                controller.RemPath(treeView_Client.SelectedNode.Text);
                if (treeView_Client.SelectedNode.Parent == null)
                {
                    controller.TreeConstrucktForForm += Construction;
                    controller.RemPath(treeView_Client.SelectedNode.Text);
                }
                else
                {
                    Exception ex = new Exception();
                    throw ex;
                }

            }
           catch (Exception)
           {
               return;

           }
        }

        private void InitializeTimer()
        {
            // Call this procedure when the application starts.
            // Set to 1 minute.
            int min = 60000;
            Timer1.Interval = reccurency * min;
            Timer1.Tick += new EventHandler(Timer1_Tick);

            // Enable timer.
            Timer1.Enabled = true;
            
        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            controller.RunSyncronization();
            Construction();
        }

        private void Sync_Button_Click(object sender, EventArgs e)
        {
            controller.RunSyncronization();            
        }

        //private void TreeConstructonEvent() 
        //{
            
        //}

        private void Construction(object obj, EventArgs arg) 
        {
            
            treeView_Client.Nodes.Clear();
            List<string> path = controller.Path;
            TreeAddNode createTree = new TreeAddNode(path);
            createTree.create_tree(treeView_Client);
        }

        private void Construction()
        {

            treeView_Client.Nodes.Clear();
            List<string> path = controller.Path;
            TreeAddNode createTree = new TreeAddNode(path);
            createTree.create_tree(treeView_Client);
        }
    }
}