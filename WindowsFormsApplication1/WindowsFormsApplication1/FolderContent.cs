using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class FolderContent : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView songsDataGridView = new DataGridView();
        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();
        
        private string path;
        public FolderContent(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void FolderContent_Load(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            listBox1.Items.Clear();            
            string[] files = Directory.GetFiles(path);
            string[] dirs = Directory.GetDirectories(path);

            foreach (string dir in dirs)
            {
                listBox1.Items.Add(dir);
            }

            foreach (string file in files)
            {
                listBox1.Items.Add(file);
            }

        }         
    }
}
