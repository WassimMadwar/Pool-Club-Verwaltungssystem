using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolClub
{
    public class EventTableEnd : EventArgs
    {
        public string TimeText { get; }
        public int TimeInSeconds { get; }
        public float RatePerHour { get; }
        public float TotalFees { get; }

        public EventTableEnd(string TimeText, int TimeInSeconds, float RatePerHour, float TotalFees)
        {
            this.TimeText = TimeText;
            this.TimeInSeconds = TimeInSeconds;
            this.RatePerHour = RatePerHour;
            this.TotalFees = TotalFees;
        }

    }
}
