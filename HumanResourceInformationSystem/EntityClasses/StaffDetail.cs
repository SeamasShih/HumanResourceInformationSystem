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

        public StaffDetail(int _id, string _givenName, string _familyName, string _title, Campus _campus, string _phone, string _room, string _email, string _photo, Category _category)
        {
            this.Id = _id;
            this.GivenName = _givenName;
            this.FamilyName = _familyName;
            this.Title = _title;
            this.Campus = _campus;
            this.Phone = _phone;
            this.Room = _room;
            this.Email = _email;
            this.Photo = _photo;
            this.Category = _category;
        }

        public override string ToString()
        {
            string str = String.Format("Staff: [" +
                "ID= {0}, Given name= {1}, Family name= {2}, Title= {3}, Campus= {4}, Phone= {5}, Room= {6}, Email= {7}, Photo= {8}, Category= {9}" +
                "]", Id, GivenName, FamilyName, Title, Campus, Phone, Room, Email, Photo, Category);
            return str;
        }

    } 
}
