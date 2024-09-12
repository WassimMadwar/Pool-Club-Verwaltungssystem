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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void ctrTableControl_TableEnd(object sender, EventTableEnd MyE)
        {
            string TableResults = "";

            TableResults = "Time Consumed " + MyE.TimeText;
            TableResults = TableResults + ", Total Seconds= " + MyE.TimeInSeconds;
            TableResults = TableResults + ", HourlyRate=" + MyE.RatePerHour.ToString();
            TableResults = TableResults + ", Total Fees=" + MyE.TotalFees.ToString();

            MessageBox.Show(TableResults);

        }
    }
}
