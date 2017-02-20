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



        
        string reqUrl = "http://api.tagtider.net/v1/stations.json";
       

        WebRequest req;
        Stream stream;
        CredentialCache reqCred = new CredentialCache();
        
        JsonSerializer jsGrej = new JsonSerializer();
        JsonReader jsReader;
        public dynamic json;
        Stations datan;
        
        /*
         Om vi skulle vilja spara datan i ett vanligt objekt
         public List<RootObject> data; 
        */


        protected void Page_Load(object sender, EventArgs e)
        {
            //Sätter upp get anropet med digest
            reqCred.Add(new Uri(reqUrl), "Digest", new NetworkCredential("tagtider", "codemocracy"));

            req = WebRequest.Create(reqUrl);
            req.Method = "GET";
            req.PreAuthenticate = true;
            req.Credentials = reqCred;

            // Hämtar datan
            stream = req.GetResponse().GetResponseStream();

            var streamReader = new StreamReader(stream);

            //Sparar datan i en "dynamisk", typ som en lista
            json = JsonConvert.DeserializeObject(streamReader.ReadToEnd());

         
          //  Tagtider saken = JsonConvert.DeserializeObject<Tagtider>(json.stations.station[0]);
            
                

          //  datan = JsonConvert.DeserializeObject<Stations>(json.stations.station);

            foreach (dynamic sak in json.stations.station)
            {
                index1.Items.Add((string)sak.name);
            }

           
        }

        
}
}