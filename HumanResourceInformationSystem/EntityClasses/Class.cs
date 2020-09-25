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
    }
}
