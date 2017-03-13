using System;
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
        ApiCaller apiCaller;


        protected void Page_Load(object sender, EventArgs e)
        {
            //Knapp som visar alla stationer eller en lista där man får välja station

            apiCaller = new ApiCaller("stations.json");

            //Tagtider saken = JsonConvert.DeserializeObject<Tagtider>(json.stations.station[0]);

            //ska kalla apicaller och göra logiken för att visa sakerna här
            

            //datan = JsonConvert.DeserializeObject<Stations>(json.stations.station);
            
            
            foreach (dynamic sak in apiCaller.json.stations.station)
            {
                index1.Items.Add((string)sak.name);
            }
            
           
        }

        
}
}