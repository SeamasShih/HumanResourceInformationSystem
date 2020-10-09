using HumanResourceInformationSystem.Controller;
using HumanResourceInformationSystem.EntityClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResourceInformationSystem.View
{
    public partial class UnitClassList : Form
    {
        public Form previous;
        public UnitClassList()
        {
            InitializeComponent();

            LoadClasses();
        }

        private void LoadClasses()
        {
            RefreshListView(UnitController.getClassListByUnit(UnitController.Unit));
            SetCampusSelection();
        }

        private void SetCampusSelection()
        {
            comboBoxCampusFilter.Items.Add(Campus.All);
            comboBoxCampusFilter.Items.Add(Campus.Launceston);
            comboBoxCampusFilter.Items.Add(Campus.Hobart);
            comboBoxCampusFilter.SelectedIndex = 0;
        }

        private void RefreshListView(List<Class> classes)
        {
            classListView.Clear();
            classListView.Columns.Add("Campus");
            classListView.Columns.Add("Day");
            classListView.Columns.Add("Start");
            classListView.Columns.Add("End");
            classListView.Columns.Add("Type");
            classListView.Columns.Add("Room");
            classListView.Columns.Add("Staff");


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
                Console.WriteLine(c.StaffName);
                classListView.Items.Add(item);
            }


            for (int i = 0; i < classListView.Columns.Count; i++)
            {
                classListView.Columns[i].Width = -1;
            }
        }

        private void comboBoxCampusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Class> classes = UnitController.filterClassByCampus((Campus)comboBoxCampusFilter.SelectedItem);
            if (classes != null)
                RefreshListView(classes);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();
            previous.Show();
        }
    }
}
