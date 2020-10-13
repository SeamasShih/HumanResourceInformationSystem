using HumanResourceInformationSystem.Controller;
using HumanResourceInformationSystem.EntityClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResourceInformationSystem.View
{
    public partial class UnitClassList : Form
    {
        public UnitClassList()
        {
            InitializeComponent();
        }

        //Load class data from databass. 
        //It can be called by other objects.
        public void LoadClasses()
        {
            RefreshListView(UnitController.getClassListByUnit(UnitController.Unit));
            SetCampusSelection();
        }

        //Set the selection of campus, including all, Laucenston, and Hobart.
        private void SetCampusSelection()
        {
            comboBoxCampusFilter.Items.Add(Campus.All);
            comboBoxCampusFilter.Items.Add(Campus.Launceston);
            comboBoxCampusFilter.Items.Add(Campus.Hobart);
            comboBoxCampusFilter.SelectedIndex = 0;
        }

        //After retriving data from database, refresh the UI based on what has been downloaded.
        private void RefreshListView(List<Class> classes)
        {
            //Set the columns of classes, including campus, day, start time, end time, type, room, and staff.
            classListView.Clear();
            classListView.Columns.Add("Campus");
            classListView.Columns.Add("Day");
            classListView.Columns.Add("Start");
            classListView.Columns.Add("End");
            classListView.Columns.Add("Type");
            classListView.Columns.Add("Room");
            classListView.Columns.Add("Staff");

            //Put the classes from database into the class table
            foreach (Class c in classes)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = c;
                item.SubItems.Clear();
                item.SubItems[0].Text = c.Campus.ToString();
                item.SubItems.Add(c.Day.ToString());
                item.SubItems.Add(c.Start.ToString());
                item.SubItems.Add(c.End.ToString());
                item.SubItems.Add(c.Type.ToString());
                item.SubItems.Add(c.Room);
                item.SubItems.Add(c.StaffName);
                classListView.Items.Add(item);
            }


            for (int i = 0; i < classListView.Columns.Count; i++)
            {
                classListView.Columns[i].Width = -1;
            }
        }

        //When a selection of the filter is selected, show only classes in the specific campus.
        private void comboBoxCampusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Class> classes = UnitController.filterClassByCampus((Campus)comboBoxCampusFilter.SelectedItem);
            if (classes != null)
                RefreshListView(classes);
        }
    }
}
