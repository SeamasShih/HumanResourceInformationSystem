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
        public MainView()
        {
            InitializeComponent();
            staffSplitContainer.Dock = DockStyle.Fill;
            // put staff list view in panel 1 of staff split container
            StaffList _staffListForm = new StaffList();
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
    }
}
