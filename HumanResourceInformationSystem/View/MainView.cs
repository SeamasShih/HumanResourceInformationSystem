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
        public static StaffDetailView _staffDetailView = new StaffDetailView();
        public MainView()
        {
            InitializeComponent();
            staffSplitContainer.Dock = DockStyle.Fill;

            StaffList _staffListForm = new StaffList();
            _staffListForm.TopLevel = false;
            _staffListForm.Parent = staffSplitContainer.Panel1;
            _staffListForm.Show();
            _staffListForm.Dock = DockStyle.Fill;

            _staffDetailView.TopLevel = false;
            _staffDetailView.Parent = staffSplitContainer.Panel2;
            _staffDetailView.Show();
            _staffDetailView.Dock = DockStyle.Fill;
        }
    }
}
