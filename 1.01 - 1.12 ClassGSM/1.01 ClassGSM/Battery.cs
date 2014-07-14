using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._01_ClassGSM
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

    class Battery
    {
        public Battery()
        { 
        }

        public Battery(BatteryType model, int hoursIdle, int hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }


        public BatteryType Model { set; get; }
        public int HoursIdle { set; get; }
        public int HoursTalk { set; get; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Battery Model: " + this.Model.ToString());
            result.AppendLine("Hours Idle: " + this.HoursIdle);
            result.AppendLine("Hours Talk: " + this.HoursTalk);

            return result.ToString();
        }
    }
}
