using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceInformationSystem.View
{
    public partial class MainView : Form
    {
        // view of staff details
        public static StaffDetailView _staffDetailView = new StaffDetailView();
        public static UnitClassList unitClassList = new UnitClassList();
        public static StaffList _staffListForm = new StaffList();
        public static UnitListView unitListView = new UnitListView();


        public MainView()
        {
            InitializeComponent();
            setStaffListForm();
            setUnitListForm();
        }

        private void setStaffListForm()
        {
            staffSplitContainer.Dock = DockStyle.Fill;
            // put staff list view in panel 1 of staff split container
            _staffListForm.TopLevel = false;
            _staffListForm.Parent = staffSplitContainer.Panel1;
            _staffListForm.Show();
            _staffListForm.Dock = DockStyle.Fill;

            // put staff details view in panel 2 of staff split container
            _staffDetailView.TopLevel = false;
            _staffDetailView.Parent = staffSplitContainer.Panel2;
            _staffDetailView.Show();
            _staffDetailView.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// In Here, the initial setting of unit form and class list form are done.
        /// </summary>
        private void setUnitListForm()
        {
            UnitsplitContainer.Dock = DockStyle.Fill;

            //set unit form
            unitListView.TopLevel = false;
            unitListView.Parent = UnitsplitContainer.Panel1;
            unitListView.Show();
            unitListView.Dock = DockStyle.Fill;

            //set class list form
            unitClassList.TopLevel = false;
            unitClassList.Parent = UnitsplitContainer.Panel2;
            unitClassList.Show();
            unitClassList.Dock = DockStyle.Fill;
        }

        //change unit tab focus
        public void changeUnitTabFocus(string _unitCode)
        {
            Console.WriteLine("===unit code===>" + _unitCode);
            mainTabControl.SelectedTab = tabPageUnits;
            unitListView.focusSelectedUnit(_unitCode);
        }

        //change tab focus from unit page to staff page
        public void changeUnitTabFocusByStaffID(int id)
        {
            mainTabControl.SelectedTab = tabPageStaff;
            _staffListForm.focusSelectedStaff(id);
        }
    }
}
