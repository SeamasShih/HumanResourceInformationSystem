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
            string s = String.Format("Staff: [" +
                "ID= {0}, Given name= {1}, Family name= {2}, Title= {3}, Category= {4}" +
                "]", Id, GivenName, FamilyName, Title, Category);
            return s;
        }
    }
}
