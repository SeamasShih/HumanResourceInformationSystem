using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceInformationSystem.EntityClasses
{
    public class Staff
    {
        public int Id { private set; get; }
        public string GivenName { private set; get; }
        public string FamilyName { private set; get; }
        public string Title { private set; get; }
        public Category Category { private set; get; }

        public Staff(int id, string givenName, string familyName, string title, Category category)
        {
            Id = id;
            GivenName = givenName;
            FamilyName = familyName;
            Title = title;
            Category = category;
        }

        public override string ToString()
        {
            string s = String.Format(FamilyName + ", " + GivenName + "(" + Title + ")");
            return s;
        }
    }
}
