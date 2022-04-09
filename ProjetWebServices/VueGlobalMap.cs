using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
namespace ProjetWebServices
{
    public partial class VueGlobalMap : Form
    {
        public VueGlobalMap()
        {
            InitializeComponent();
            try
            {
                System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google");
            }
            catch{ }

             map.DragButton = MouseButtons.Left;
           // map.MapProvider = BingMapProvider.Instance;
           map.MapProvider = GMapProviders.GoogleMap;

            map.Position = new PointLatLng(14.74028, -17.25761);
            map.MinZoom = 0;
            map.MaxZoom = 34;
            map.Zoom = 15;
            Size s = new Size(100, 100);
            Image img = Image.FromFile("E:/API et SERVICES Web/hopi.jpg");
            Bitmap bitmap = new Bitmap(img, s);
            //Abass Ndao
            PointLatLng p1 = new PointLatLng(14.6882,-174547);
            //Hoptal Fann
            PointLatLng p2= new PointLatLng(14.6912, -17.4706);
            //Hopiatal Principal
            PointLatLng p3= new PointLatLng(14.6607, -174351);
            //Hopital Youssou Bargane
            PointLatLng p4= new PointLatLng(14.74028,-1725761);
            //Hopiatal Grand Yoff
            PointLatLng p5 = new PointLatLng(14.7317,-174450);
            //Hopiatl Aristide le Dantec
            PointLatLng p6 = new PointLatLng(14.6569, -17.4366);
            //Hopital Fawzeyni
            PointLatLng p7= new PointLatLng(14.7369, -17.4558);
            //Hopital Pikine 
            PointLatLng p8 = new PointLatLng(14.7542, -17.3759);
            //Hopital Dalal Diam
            PointLatLng p9= new PointLatLng(14.7725, -17.4092);
            GMapMarker mapMarker1 = new GMarkerGoogle(p1, bitmap);
            GMapMarker mapMarker2 = new GMarkerGoogle(p2, GMarkerGoogleType.red_pushpin);
            GMapMarker mapMarker3 = new GMarkerGoogle(p3, bitmap);
            GMapMarker mapMarker4 = new GMarkerGoogle(p4, bitmap);
            GMapMarker mapMarker5 = new GMarkerGoogle(p5, bitmap);
            GMapMarker mapMarker6 = new GMarkerGoogle(p6, bitmap);
            GMapMarker mapMarker7 = new GMarkerGoogle(p7, bitmap);
            GMapMarker mapMarker8 = new GMarkerGoogle(p8, bitmap);
            GMapMarker mapMarker9= new GMarkerGoogle(p9, bitmap);
        

            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(mapMarker1);
            markers.Markers.Add(mapMarker2);
            markers.Markers.Add(mapMarker3);
            markers.Markers.Add(mapMarker4);
            markers.Markers.Add(mapMarker5);
            markers.Markers.Add(mapMarker6);
            markers.Markers.Add(mapMarker7);
            markers.Markers.Add(mapMarker8);
            markers.Markers.Add(mapMarker9);
            map.Overlays.Add(markers);
            
        }
        }
    }

