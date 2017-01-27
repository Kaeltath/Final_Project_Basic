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
    public partial class FileMaskFrom : Form
    {
        public class FilterChangeEventArgs : EventArgs
        {            
            public string White{set;get;}
            public string Black {set;  get;}
        }       

       
        public event EventHandler<FilterChangeEventArgs> FilterUpdateEventHendler;
               
        
        public FileMaskFrom(string blackbox, string whitebox)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            BlackList_Textbox.Text = blackbox;
            WhiteList_Textbox.Text = whitebox;
        }        
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (FilterUpdateEventHendler != null)
            {
                FilterChangeEventArgs Args = new FilterChangeEventArgs();
                Args.Black = BlackList_Textbox.Text;
                Args.White = WhiteList_Textbox.Text;
                FilterUpdateEventHendler(this, Args);
            }
            this.Close();
        }

                    
    }
}
