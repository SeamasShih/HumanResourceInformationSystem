using HumanResourceInformationSystem.Controller;
using HumanResourceInformationSystem.EntityClasses;
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
    public partial class StaffList : Form
    {
        // use to catch the selected staff id when click to random staff in list.
        public static int _selectedStaffId = 0;


        // load combobox category
        public void loadComboboxCategory()
        {
            comboBoxCategory.Items.Add("All");
            comboBoxCategory.Items.Add(Category.Academic);
            comboBoxCategory.Items.Add(Category.Admin);
            comboBoxCategory.Items.Add(Category.Casual);
            comboBoxCategory.Items.Add(Category.Technical);

            //set All as default
            comboBoxCategory.SelectedIndex = 0;
        }

        // Display staff list
        public void loadStaffList()
        {
            staffListView.View = System.Windows.Forms.View.List;
            //retrieve staff list from database
            List<Staff> _listStaff = StaffController.getStaffListView();
            foreach (var item in _listStaff)
            {
                ListViewItem _listViewItem = new ListViewItem();
                // use Tag to get the ID of staff
                _listViewItem.Tag = item;
                _listViewItem.Text = item.ToString();
                staffListView.Items.Add(_listViewItem);
            }
        }
        public StaffList()
        {
            InitializeComponent();
            loadComboboxCategory();
            loadStaffList();
        }

        // event when click to the Search button
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string _searchString = textBoxSearch.Text;
            string _category = comboBoxCategory.Text;
            staffListView.Clear();
            List<Staff> _listStaff = StaffController.getStaffListBySearchEvent(_searchString, _category);
            foreach (var item in _listStaff)
            {
                ListViewItem _listViewItem = new ListViewItem();
                _listViewItem.Tag = item;
                _listViewItem.Text = item.ToString();
                staffListView.Items.Add(_listViewItem);
            }
        }

        // event when selected random staff in list
        private void staffListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection _collection = this.staffListView.SelectedItems;
            if (_collection.Count > 0)
            {
                StaffDetailView _staffView = new StaffDetailView();
                ListViewItem _listViewItem = staffListView.SelectedItems[0];
                Staff _staff = (Staff)_listViewItem.Tag;
                _selectedStaffId = _staff.Id;
                MainView._staffDetailView.showStaffDetail();
            }

        }

        // show certain staff by staff id
        public void focusSelectedStaff(int id)
        {
            //set catogery selection to all
            comboBoxCategory.SelectedIndex = 0;

            //find the specific staff by id
            for (int i = 0; i < staffListView.Items.Count; i++)
            {
                Staff staff = (Staff)staffListView.Items[i].Tag;
                if (staff.Id == id)
                {
                    staffListView.Items[i].Selected = true;
                }
            }
        }
    }
}
