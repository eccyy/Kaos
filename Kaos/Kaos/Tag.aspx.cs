﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;


namespace Kaos
{
    public partial class Tag : System.Web.UI.Page    
    {

        /*
         Om vi skulle vilja spara datan i ett vanligt objekt
         public List<RootObject> data; 
        */
        ApiCaller apiCallerStations;
        ApiCaller apiCallerOperators;
        ApiCaller apiCallerTimes;


        protected void Page_Load(object sender, EventArgs e)
        {
            //Knapp som visar alla stationer eller en lista där man får välja station
            //Tagtider saken = JsonConvert.DeserializeObject<Tagtider>(json.stations.station[0]);
            //ska kalla apicaller och göra logiken för att visa sakerna här
            //datan = JsonConvert.DeserializeObject<Stations>(json.stations.station);
            //rtbText.SelectionFont = new Font(cmbFonts.Text, (int)numericUpDown1.Value);
            ShowStations();
            //ShowOperators();
        }

        private void ShowStations()
        {
            apiCallerStations = new ApiCaller("stations.json");

            foreach (dynamic sak in apiCallerStations.json.stations.station)
            {
                index1.Items.Add((string)sak.name);
            }
        }

        private void ShowOperators()
        {
            apiCallerOperators = new ApiCaller("operators.json");

            foreach(dynamic sak in apiCallerOperators.json.operators["operator"])
            {
                index2.Items.Add((string)sak.name);
            }
        }

        private void ShowTimes()
        {
            apiCallerTimes = new ApiCaller("stations/");
        }
    }
}