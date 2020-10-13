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
        public static int _selectedStaffId = 0;
        public void loadComboboxCategory()
        {
            comboBoxCategory.Items.Add("All");
            comboBoxCategory.Items.Add(Category.Academic);
            comboBoxCategory.Items.Add(Category.Admin);
            comboBoxCategory.Items.Add(Category.Casual);
            comboBoxCategory.Items.Add(Category.Technical);
            comboBoxCategory.SelectedIndex = 0;
        }
        public void loadStaffList()
        {
            staffListView.View = System.Windows.Forms.View.List;
            List<Staff> _listStaff = StaffController.getStaffListView();
            foreach (var item in _listStaff)
            {
                ListViewItem _listViewItem = new ListViewItem();
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

        private void staffListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection _collection = this.staffListView.SelectedItems;
            if(_collection.Count > 0) 
            {
                StaffDetailView _staffView = new StaffDetailView();
                ListViewItem _listViewItem = staffListView.SelectedItems[0];
                Staff _staff = (Staff)_listViewItem.Tag;
                _selectedStaffId = _staff.Id;
                MainView._staffDetailView.showStaffDetail();
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
