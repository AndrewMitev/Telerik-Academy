using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Battery
    {
        internal string Model { set; get; }

        internal int? HoursIdle { set; get; }

        internal int? HoursTalk { set; get; }

        internal BatteryType type = BatteryType.LiOn;

        public enum BatteryType { LiOn, NiMH, NiCd }

        public Battery()
        {
            this.Model = String.Empty;

            this.HoursIdle = 0;

            this.HoursTalk = 0;
        }

        public Battery(string m, int idle, int talk, BatteryType t)
        {
            this.Model = m;

            this.HoursIdle = idle;

            this.HoursTalk = talk;

            this.type = t;
        }

        public override string ToString()
        {
            return String.Format("model => {0}, hoursIdle => {1}, hoursTalk => {2}, batteryType => {3}", this.Model ?? "none", this.HoursIdle ?? 0, this.HoursTalk ?? 0, BatteryType.NiMH);
        }

    }
}
