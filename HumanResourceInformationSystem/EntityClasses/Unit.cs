using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceInformationSystem.EntityClasses
{
    public class Unit
    {
        public string Code { private set; get; }
        public string Title { private set; get; }
        public int Coordinator { private set; get; }

        public Unit(string _code, string _title, int _coordinator)
        {
            this.Code = _code;
            this.Title = _title;
            this.Coordinator = _coordinator;

        }

        public override string ToString()
        {
            string s = String.Format(Code + " - " + Title + " - " + Coordinator);
            return s;
        }

    }
}
