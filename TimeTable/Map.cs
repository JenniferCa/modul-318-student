using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using SwissTransport;

namespace TimeTable
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void btnCloseMap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetToLocation(double x, double y, string stationName)
        {
            GMap_GMapControl.CanDragMap = true;
            GMap_GMapControl.DragButton = MouseButtons.Left;
            GMap_GMapControl.MinZoom = 0;
            GMap_GMapControl.MaxZoom = 24;
            GMap_GMapControl.Zoom = 18;
            GMap_GMapControl.AutoScroll = true;
            GMap_GMapControl.Position = new PointLatLng(x, y);
            GMap_GMapControl.MapProvider = GMapProviders.GoogleMap;
        }

        public void GetLocation(List<Station> stations, Transport transport, string locationName)
        {
            stations = transport.GetStations(locationName).StationList;
            foreach (Station station in stations)
            {
                if (station.Name == locationName)
                {
                    this.SetToLocation(station.Coordinate.XCoordinate, station.Coordinate.YCoordinate, station.Name.ToString());
                    this.Show();
                }
            }
        }
    }
}
