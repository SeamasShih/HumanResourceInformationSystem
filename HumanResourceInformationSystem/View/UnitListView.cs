using HumanResourceInformationSystem.Adapter;
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
using System.Windows;
using System.Windows.Forms;

namespace HumanResourceInformationSystem.View
{
    public partial class UnitListView : Form
    {
        public UnitListView()
        {
            InitializeComponent();
            loadView();
        }

        // loadView when this view is called
        private void loadView()
        {
            // set list view by retrieved unit list
            refreshListView(UnitController.getUnitList());
        }

        //refresh list view by provided unit list
        private void refreshListView(List<Unit> units)
        {
            //clear original list
            listUnit.Items.Clear();
            //set new list
            foreach (Unit u in units)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = u;
                item.Text = u.Code + " " + u.Title;
                listUnit.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string text = textSearch.Text;
            //refresh list view based on unit list which is gotten by search text
            refreshListView(UnitController.filterUnitByString(text));
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //enable user can use enter key in the search text area
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }

        private void listUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListView.SelectedListViewItemCollection collection = this.listUnit.SelectedItems;
            //when a class in the list is selected, show relative classes
            if (collection.Count > 0)
            {
                ListViewItem item = listUnit.SelectedItems[0];
                UnitController.Unit = (Unit)item.Tag;
                MainView.unitClassList.LoadClasses();
            }
        }

        //change focus to specific unit based on unit code
        public void focusSelectedUnit(string _unitCode)
        {
            loadView();

            for (int i = 0; i < listUnit.Items.Count; i++)
            {
                Unit _unit = (Unit)listUnit.Items[i].Tag;
                //found unit code
                if (_unit.Code == _unitCode)
                {
                    listUnit.Items[i].Selected = true;
                }
            }
        }
    }
}
