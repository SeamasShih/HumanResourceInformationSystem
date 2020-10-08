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
using static System.Windows.Forms.ListView;

namespace HumanResourceInformationSystem.View
{
    public partial class UnitClassList : Form
    {
        public UnitClassList()
        {
            InitializeComponent();

            LoadClasses();
        }

        private void LoadClasses()
        {
            RefreshListView();
        }

        private void RefreshListView()
        {
            classListView.Clear();
            classListView.Columns.Add("Campus");
            classListView.Columns.Add("Day");
            classListView.Columns.Add("Start");
            classListView.Columns.Add("End");
            classListView.Columns.Add("Type");
            classListView.Columns.Add("Room");
            classListView.Columns.Add("Staff");


            List<Class> classes = UnitController.getClassListByUnit(UnitController.Unit);
            foreach(Class c in classes)
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
    }
}
