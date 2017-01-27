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
    public partial class ScheduleForm : Form
    {
        public int Timer{set; get;}

        public class ScheduleEventArgs : EventArgs
        {
            public int timer;
        }

        public event EventHandler<ScheduleEventArgs> ScheduleEventHendler;

        public ScheduleForm(int inp)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            switch (inp)
            {
                case 1440:
                    Daily_Radio.Checked = true;
                    break;
                case 60:
                    Hourly_Radio.Checked = true;
                    break;
                case 10:
                    TenMin_radio.Checked = true;
                    break;
                default:
                    UserSetSch_Radio.Checked = true;
                    Timer_textbox.Text = Convert.ToString(inp);
                    break;
            }
        } 

        private void ScheduleForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Daily_Radio.Checked)
            {
                Timer = 1440;
            }
            if (Hourly_Radio.Checked) 
            {
                Timer = 60;
            }
            if (TenMin_radio.Checked)
            {
                Timer = 10;
            }
            if(UserSetSch_Radio.Checked)
            {
             try
            {
                Timer = Convert.ToInt32(Timer_textbox.Text);
            }
            catch (Exception) 
            {
                MessageBox.Show("Please set correct time interval in minutes");
                Timer_textbox.Text = "5";
                return;
            }
            }
            if (ScheduleEventHendler != null)
            {
                ScheduleEventArgs Args = new ScheduleEventArgs();
                Args.timer = Timer;
                ScheduleEventHendler(this, Args);
            }
            
            this.Close();
        }        
    }
}
