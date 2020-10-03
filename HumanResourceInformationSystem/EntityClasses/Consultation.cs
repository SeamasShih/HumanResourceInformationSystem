using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceInformationSystem.EntityClasses
{
    public class Consultation
    {
        public int StaffId { private set; get; }
        public DayOfWeek DayOfWeek { private set; get; }
        public DateTime StartTime { private set; get; }
        public DateTime EndTime { private set; get; }
        public Consultation(int _staffId, DayOfWeek _dayOfWeek, DateTime _startTime, DateTime _endTime)
        {
            this.StaffId = _staffId;
            this.DayOfWeek = _dayOfWeek;
            this.StartTime = _startTime;
            this.EndTime = _endTime;

        }

        public override string ToString()
        {
            string s = String.Format(DayOfWeek + ": " + StartTime.TimeOfDay + " - " + EndTime.TimeOfDay);
            return s;
        }

    }
}
