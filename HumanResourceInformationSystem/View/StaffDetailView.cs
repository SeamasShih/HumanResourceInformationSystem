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
using System.Windows.Forms;

namespace HumanResourceInformationSystem.View
{
    public partial class StaffDetailView : Form
    {
        //use for catch unit code when click unit in table of units.
        public static string _selectedUnitCode = "";
        //show staff detail
        public void showStaffDetail()
        {
            Console.WriteLine("===> staff Id: " + StaffList._selectedStaffId);
            StaffDetail _staffDetail = StaffController.getStaffDetail(StaffList._selectedStaffId);
            txtStaffName.Text = _staffDetail.FamilyName + ", " + _staffDetail.GivenName + " (" + _staffDetail.Title + ")";
            txtStaffCampus.Text = _staffDetail.Campus.ToString();
            txtStaffPhoneNumber.Text = _staffDetail.Phone;
            txtRoomLocation.Text = _staffDetail.Room;
            txtEmailAddress.Text = _staffDetail.Email;
            //Consultation hours
            txtConsultationHours.Text = "";
            List<Consultation> _listConsultation = StaffController.getConsultationByStaffId(StaffList._selectedStaffId);

            foreach (var item in _listConsultation)
            {
                txtConsultationHours.Text += item + "\n";
            }
            //Table of units
            listViewStaffUnits.View = System.Windows.Forms.View.List;
            listViewStaffUnits.Clear();
            List<Unit> _listUnits = StaffController.getUnitsByStaffId(StaffList._selectedStaffId);

            foreach (var item in _listUnits)
            {
                ListViewItem _listViewItem = new ListViewItem();
                // Use Tag for catch Unit code
                _listViewItem.Tag = item;
                _listViewItem.Text = item.ToString();
                listViewStaffUnits.Items.Add(_listViewItem);
            }
            //photo
            pictureBoxStaff.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStaff.Load(_staffDetail.Photo);

            //current avaiability
            //get time of class.
            List<Class> _listClasses = StaffController.getClassesByStaffID(StaffList._selectedStaffId);
            // use to check current valiability status
            Boolean _temp = true;
            // check class time
            foreach (var item in _listClasses)
            {
                //compare day of week first
                if(item.Day.CompareTo((Weekday)DateTime.Now.DayOfWeek) == 0)
                {
                    //compare time
                    if(DateTime.Now.TimeOfDay.CompareTo(item.Start) < 0 && DateTime.Now.TimeOfDay.CompareTo(item.End) > 0)
                    {
                        //class time
                        txtCurrentAvaiability.Text = "Teaching";
                        _temp = false;
                    }
                }
            }
            // check consultation time
            foreach (var item in _listConsultation)
            {
                //compare day of week first
                if (item.DayOfWeek.CompareTo(DateTime.Now.DayOfWeek) == 0)
                {
                    //compare time
                    if (DateTime.Now.TimeOfDay.CompareTo(item.StartTime.TimeOfDay) < 0 && DateTime.Now.TimeOfDay.CompareTo(item.EndTime.TimeOfDay) > 0)
                    {
                        //class time
                        txtCurrentAvaiability.Text = "Consultation";
                        _temp = false;
                    }
                }
            }
            // if not teaching or consultation
            if (_temp)
            {
                txtCurrentAvaiability.Text = "Free";
            }

            //load activity grid view
            loadActivityGridView(_listClasses, _listConsultation);
        }
        public StaffDetailView()
        {
            InitializeComponent();
        }

        // load activity colour grid view
        public void loadActivityGridView(List<Class> _listClasses, List<Consultation> _listConsultation)
        {
            //load white color for all first
            DataTable _activityTable = new DataTable();
            _activityTable.Columns.Add("Time");
            _activityTable.Columns.Add("Monday");
            _activityTable.Columns.Add("Tuesday");
            _activityTable.Columns.Add("Wednesday");
            _activityTable.Columns.Add("Thursday");
            _activityTable.Columns.Add("Friday");
            for (int i=9; i<17; i++)
            {
                DataRow _dataRow = _activityTable.NewRow();
                _dataRow["Time"] = i + ":00 - " + (i+1) + ":00";
                _activityTable.Rows.Add(_dataRow);
               
            }
            activityGridView.DataSource = _activityTable;

            // colour for teaching
            foreach (var item in _listClasses)
            {
                for (int j = item.Start.Hours; j < item.End.Hours; j++)
                {
                    //colour
                    activityGridView.Rows[j - 9].Cells[item.Day.ToString()].Style.BackColor = Color.Red;
                }
            }
            // colour for consultation
            foreach (var item in _listConsultation)
            {
                for (int j = item.StartTime.Hour; j < item.EndTime.Hour; j++)
                {
                    //colour
                    activityGridView.Rows[j-9].Cells[item.DayOfWeek.ToString()].Style.BackColor = Color.Lime;
                }
            }
        }

        // show and hide activity colour grid
        private void cbActivityGrid_CheckedChanged(object sender, EventArgs e)
        {
            if (cbActivityGrid.Checked)
            {
                activityGridView.Visible = false;
                lblTeaching.Visible = false;
                lblConsultation.Visible = false;
                lblFree.Visible = false;
            }
            else
            {
                activityGridView.Visible = true;
                lblTeaching.Visible = true;
                lblConsultation.Visible = true;
                lblFree.Visible = true;
            }
           
        }
        
        // event when random click to unit in table of units.
        private void listViewStaffUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection _collection = this.listViewStaffUnits.SelectedItems;
            if(_collection.Count > 0) 
            {
                ListViewItem _listViewItem = listViewStaffUnits.SelectedItems[0];
                Unit _unit = (Unit)_listViewItem.Tag;
                _selectedUnitCode = _unit.Code;
                Console.WriteLine("===unit code==>: " + _selectedUnitCode);
                //change focus tab
                MainWindow._mainView.changeUnitTabFocus(_selectedUnitCode);
                // set selected unit list view
            }

        }
    }
}
