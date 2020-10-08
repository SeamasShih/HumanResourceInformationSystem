using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceInformationSystem.EntityClasses
{
    public class Class
    {
        public string UnitCode { private set; get; }
        public Campus Campus { private set; get; }
        public Weekday Day { private set; get; }
        public TimeSpan Start { private set; get; }
        public TimeSpan End { private set; get; }
        public UnitType Type { private set; get; }
        public string Room { private set; get; }
        public int Staff { private set; get; }
        public string StaffName { private set; get; }

        public Class(string unitCode, Campus campus, Weekday day, 
            TimeSpan start, TimeSpan end, UnitType type, string room, int staff, string staffName)
        {
            UnitCode = unitCode;
            Campus = campus;
            Day = day;
            Start = start;
            End = end;
            Type = type;
            Room = room;
            Staff = staff;
            StaffName = staffName;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", UnitCode, Campus, Day, Start, End, Type, Room, Staff, StaffName);
        }
    }
}
