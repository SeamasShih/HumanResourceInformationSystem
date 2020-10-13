using HumanResourceInformationSystem.Adapter;
using HumanResourceInformationSystem.EntityClasses;
using HumanResourceInformationSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceInformationSystem.Controller
{
    class StaffController
    {
        //get the list of staff
        public static List<Staff> getStaffListView()
        {
            List<Staff> _staffList = new List<Staff>();
            //use linq to filter here
            var _staffDetailList = DatabaseAdapter.RetrieveStaffList();
            var list = from item in _staffDetailList select item;
            foreach (var item in list)
            {
                _staffList.Add(item);
                Console.WriteLine(item);
            }
            return _staffList;
        }

        // get list of staff when click Search button
        public static List<Staff> getStaffListBySearchEvent(string _searchString, string _category)
        {
            Console.WriteLine("========>" + _category);
            _searchString = _searchString.ToUpper();
            List<Staff> _listStaff = new List<Staff>();
            //use linq to filter here
            var _staffDetailList = DatabaseAdapter.RetrieveStaffList();
            var list = from item in _staffDetailList where item.FamilyName.ToUpper().Contains(_searchString) || item.GivenName.ToUpper().Contains(_searchString) select item;
            if (_category != "All")
            {
                list = from item in list where item.Category == (Category)Enum.Parse(typeof(Category), _category) select item;
            }
            foreach (var item in list)
            {
                _listStaff.Add(item);
                Console.WriteLine(item);
            }
            return _listStaff;
        }

        // get staff details by staff ID
        public static StaffDetail getStaffDetail(int _staffId)
        {
            StaffDetail _staffDetail = null;
            //use linq to filter here
            var _staffDetailList = DatabaseAdapter.RetrieveStaffDetail();
            var list = from item in _staffDetailList where item.Id == _staffId select item;
            foreach (var item in list)
            {
                _staffDetail = item;
                Console.WriteLine(item);
            }
            return _staffDetail;
        }

        //get consultation time by staff ID
        public static List<Consultation> getConsultationByStaffId(int _staffId)
        {
            List<Consultation> _consultation = new List<Consultation>();
            //use linq to filter here
            var _consultationNotFilterYet = DatabaseAdapter.RetrieveConsultation();
            var list = from item in _consultationNotFilterYet where item.StaffId == _staffId select item;
            foreach (var item in list)
            {
                _consultation.Add(item);
                Console.WriteLine(item);
            }
            return _consultation;
        }

        //get classes by staff ID
        public static List<Class> getClassesByStaffID(int _staffID)
        {
            List<Class> _listClasses = new List<Class>();
            var _classes = DatabaseAdapter.RetrieveClasses();
            var list = from item in _classes where item.Staff == _staffID select item;
            foreach (var item in list)
            {
                _listClasses.Add(item);
                Console.WriteLine(item);
            }
            return _listClasses;
        }

        //get list of units by staff ID
        public static List<Unit> getUnitsByStaffId(int _staffId)
        {
            List<Unit> _listUnits = new List<Unit>();
            //use linq to filter here
            var _unitsNotFilterYet = DatabaseAdapter.RetrieveUnits();
            var list = from item in _unitsNotFilterYet where item.Coordinator == _staffId select item;
            foreach (var item in list)
            {
                _listUnits.Add(item);
                Console.WriteLine(item);
            }
            return _listUnits;
        }
    }
}
