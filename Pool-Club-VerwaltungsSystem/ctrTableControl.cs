using PoolClub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolClub
{
    public partial class ctrTableControl : UserControl
    {
        private int TotalSeconds;

        private string TableTitle_ = "";
        [Category("Table Config"), Description("The Table name")]
        public string TableTitle
        {
            get
            {
                return TableTitle_;
            }
            set
            {
                TableTitle_ = value;

                grp_Table.Text = value;

               
                Invalidate();
            }
        }

        private float HourlyRate_;



        public event EventHandler<EventTableEnd> TableEnd;

        protected virtual void OnTableEnd(EventTableEnd MyE)
        {
            TableEnd?.Invoke(this, MyE);
        }
        public void ReisOnTableEnd(string TimeText, int TimeInSeconds, float RatePerHour, float TotalFees)
        {
            OnTableEnd(new EventTableEnd(TimeText, TimeInSeconds, RatePerHour, TotalFees));
        }
        public ctrTableControl()
        {
            InitializeComponent();
        }

        private void ResetCtr()
        {
            //grp_Table.Text = "Table";
            rb_Billiard.Checked = false;
            rb_Snooker.Checked = false;
            pa_TableArt.BackgroundImage = Resources.Free;
            btn_StartStop.Enabled = false;
            lbl_Time.Text = "00:00:00";
            btn_StartStop.Text = "Start";
            TotalSeconds = 0;
        }
        private void rb_Snooker_CheckedChanged(object sender, EventArgs e)
        {
            btn_StartStop.Enabled = true;
            HourlyRate_ = 100.00F;
            pa_TableArt.BackgroundImage = Resources.Snooker;
        }

        private void rb_Billiard_CheckedChanged(object sender, EventArgs e)
        {
            btn_StartStop.Enabled = true;
            HourlyRate_ = 200.00F;
            pa_TableArt.BackgroundImage = Resources.Bill;
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            float TotalFees = ((float)TotalSeconds / 60 / 60) * HourlyRate_;

            ReisOnTableEnd(lbl_Time.Text, TotalSeconds, HourlyRate_, TotalFees);
            

            ResetCtr();
        }

        private void btn_StartStop_Click(object sender, EventArgs e)
        {
            if (btn_StartStop.Text == "Start")
            {
                btn_StartStop.Text = "Stop";
                timer1.Start();
            }
            else
            {
                btn_StartStop.Text = "Start";
                timer1.Stop();
            } 
        }

        private void ctrTableControl_Load(object sender, EventArgs e)
        {
            grp_Table.Text = TableTitle_;
            btn_StartStop.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TotalSeconds++;

            TimeSpan time = TimeSpan.FromSeconds(TotalSeconds);
            string str = time.ToString(@"hh\:mm\:ss");
            lbl_Time.Text = str;
            lbl_Time.Refresh();
        }
    }
}
