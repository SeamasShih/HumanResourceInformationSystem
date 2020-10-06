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
    public partial class UnitListView : Form
    {
        public UnitListView()
        {
            InitializeComponent();
            List<Unit> units = Adapter.DatabaseAdapter.RetrieveUnits();
            foreach(Unit unit in units)
            {
                Console.WriteLine(unit.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
