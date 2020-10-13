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

        private void loadView()
        {
            refreshListView(UnitController.getUnitList());
        }

        private void refreshListView(List<Unit> units)
        {
            listUnit.Items.Clear();
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
            refreshListView(UnitController.filterUnitByString(text));
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }

        private void listUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListView.SelectedListViewItemCollection collection = this.listUnit.SelectedItems;
            if (collection.Count > 0)
            {
                ListViewItem item = listUnit.SelectedItems[0];
                UnitController.Unit = (Unit)item.Tag;
                MainView.unitClassList.LoadClasses();
            }
        }
    }
}
