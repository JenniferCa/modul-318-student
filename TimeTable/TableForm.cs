using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace TimeTable
{
    public partial class TableForm : Form
    {
        //Variabelen
        string departureTime = null;
        string departureDate = null;
        int isArrivalTime = 1;
        Transport transport = new Transport();
        List<string> fromStationId = new List<string>();
        List<Station> stationList = new List<Station>();

        public TableForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        //show Textinput in the "Von" Station Combobox
        private void txtStation_TextChanged(object sender, EventArgs e)
        {
            cmbFromStation.Items.Clear();
            GetFromStation(txtFromStation.Text, cmbFromStation);
        }
        //show Textinput in the "Nach" Station Combobox
        private void txtToStation_TextChanged(object sender, EventArgs e)
        {
            cmbToStation.Items.Clear();
            GetToStation(txtToStation.Text, cmbToStation);
        }
        //show Connections in ListView
        private void btnSearchForConnections_Click(object sender, EventArgs e)
        {
            SetDepartureDate();
            SetDepartureTime();
            lvTable.Items.Clear();
            lvTable.Items.AddRange(GetConnection(cmbFromStation.Text, cmbToStation.Text));
        }
        //show the Departure Board from the Current "Von" Station
        private void btnDepartureTable_Click(object sender, EventArgs e)
        {
            if (cmbFromStation.SelectedIndex != -1)
            {
                StationTable stationBoardForm = new StationTable();
                stationBoardForm.setcmbFromStation(cmbFromStation.Text);
                stationBoardForm.setListItemView();
                stationBoardForm.ShowDialog();
            }
        }
        //show the Current "Nach" Station on the Map
        private void btnMap_Click(object sender, EventArgs e)
        {
            if(cmbToStation.SelectedIndex != -1)
            {
                Map gMap = new Map();
                gMap.GetLocation(stationList, transport, cmbToStation.SelectedItem.ToString());
            }
        }
        private void btnEmail_Click(object sender, EventArgs e)
        {
            if(cmbFromStation.SelectedIndex != -1 && cmbToStation.SelectedIndex != -1)
            {
                Email emailTextForm = new Email();
                emailTextForm.ShowDialog();
            }
        }
        //get all stations for the "Von" Station Combobox
        private void GetFromStation(string location, ComboBox cmbStation)
        {
            Stations station = transport.GetStations(location);
            List<string> fromStationList = new List<string>();
            foreach (var item in station.StationList)
            {
                if (!string.IsNullOrEmpty(item.Name))
                {
                    fromStationList.Add(item.Name);
                }
            }
            foreach (var item in fromStationList)
            {
                cmbStation.Items.Add(item);
            }
            if (cmbStation.Items.Count > 0)
            {
                cmbStation.SelectedIndex = 0;
            }
        }
        //set the departureTime
        private void SetDepartureTime()
        {
            departureTime = (tpTime.Value.Hour) + ":" + tpTime.Value.Minute;
        }
        //set the departureDate
        private void SetDepartureDate()
        {
            departureDate = tpDate.Value.Year + "-" + tpDate.Value.Month + "-" + tpDate.Value.Day;
        }
        public ListViewItem[] GetStationBoard(string fromStation)
        {
            Stations stations = new Stations();
            StationBoardRoot stationBoard = null;
            stations = transport.GetStations(fromStation);
            string stationId = stations.StationList.First().Id;
            try
            {
                stationBoard = transport.GetStationBoard(fromStation, stationId);
            }
            catch (Exception e)
            {
                ListViewItem[] errorListView = new ListViewItem[1];
                errorListView[0] = new ListViewItem("FEHLER");
                errorListView[0].SubItems.Add(e.Message);
                return errorListView;

            }
            ListViewItem[] stationListView = new ListViewItem[stationBoard.Entries.Count];
            int i = 0;
            foreach (StationBoard item in stationBoard.Entries)
            {
                stationListView[i] = new ListViewItem(item.Name);
                stationListView[i].SubItems.Add(item.Stop.Departure.ToShortTimeString());
                stationListView[i].SubItems.Add(item.To);
                i++;
            }

            if (stationListView == null)
            {
                stationListView[0] = new ListViewItem("Keine Abfahrtstafel vorhanden");
            }

            return stationListView;
        }
        //get all connections into the ListView
        private ListViewItem[] GetConnection(string fromStation, string toStation)
        {
            Connections ConnectionListView = transport.GetConnections(fromStation, toStation, departureDate, departureTime, isArrivalTime);
            try
            {
                ConnectionListView = transport.GetConnections(fromStation, toStation, departureDate, departureTime, isArrivalTime);
            }
            catch (Exception e)
            {
                ListViewItem[] errorListItemView = new ListViewItem[1];
                errorListItemView[0] = new ListViewItem("Fehler:\n");
                errorListItemView[0].SubItems.Add(e.Message);
                return errorListItemView;

            }
            ListViewItem[] listView = new ListViewItem[ConnectionListView.ConnectionList.Count];
            for (int i = 0; i < ConnectionListView.ConnectionList.Count; i++)
            {
                listView[i] = new ListViewItem(ConnectionListView.ConnectionList[i].From.Station.Name);
                listView[i].SubItems.Add(ConnectionListView.ConnectionList[i].To.Station.Name);
                listView[i].SubItems.Add(DateTime.Parse(ConnectionListView.ConnectionList[i].From.Departure).ToShortTimeString());
                listView[i].SubItems.Add(DateTime.Parse(ConnectionListView.ConnectionList[i].To.Arrival).ToShortTimeString());
                listView[i].SubItems.Add(TimeSpan.Parse(ConnectionListView.ConnectionList[i].Duration.Substring(3)).TotalMinutes.ToString() + " Min");
            }
            if (listView == null)
            {
                listView[0] = new ListViewItem("Keine Verbindungen vorhanden");
            }
            return listView;
        }
        //get all stations for the Station Combobox
        private void GetToStation(string location, ComboBox cmbStation)
        {
            Stations station = transport.GetStations(location);
            List<string> toStationList = new List<string>();
            foreach (var item in station.StationList)
            {
                if (!string.IsNullOrEmpty(item.Name))
                {
                    toStationList.Add(item.Name);
                }
            }
            foreach (var item in toStationList)
            {
                cmbStation.Items.Add(item);
            }
            if (cmbStation.Items.Count > 0)
            {
                cmbStation.SelectedIndex = 0;
            }
        }
    }
}
