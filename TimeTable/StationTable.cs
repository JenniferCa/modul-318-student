using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable
{
    public partial class StationTable : Form
    {
        public StationTable()
        {
            InitializeComponent();
        }
        public void setListItemView()
        {
            livStationboard.Items.Clear();
            TableForm mainForm = new TableForm();
            livStationboard.Items.AddRange(mainForm.GetStationBoard(lblFromStation.Text));
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setcmbFromStation(string station)
        {
            lblFromStation.Text = station;
        }
    }
}
