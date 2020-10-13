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
        //use for catch unit code when click unit in table of units in staff detail.
        public static string selectedUnitCode = "";
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
            List<Unit> _listUnits = StaffController.getUnitsByStaffId(StaffList._selectedStaffId);

            foreach (var item in _listUnits)
            {
                listViewStaffUnits.Items.Add(item.ToString());
            }
            //photo
            pictureBoxStaff.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStaff.Load(_staffDetail.Photo);

        }
        public StaffDetailView()
        {
            InitializeComponent();
        }

    }
}
