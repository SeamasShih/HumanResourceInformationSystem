using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceInformationSystem.EntityClasses
{
    public class StaffDetail
    {
        public int Id { private set; get; }
        public string GivenName { private set; get; }
        public string FamilyName { private set; get; }
        public string Title { private set; get; }
        public Campus Campus { private set; get; }
        public string Phone { private set; get; }
        public string Room { private set; get; }
        public string Email { private set; get; }
        public string Photo { private set; get; }
        public Category Category { private set; get; }
    }
}
