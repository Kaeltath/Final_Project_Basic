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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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
       
    }
}
