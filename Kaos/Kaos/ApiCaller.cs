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
    public class ApiCaller
    {
        WebRequest req;
        Stream stream;
        CredentialCache reqCred = new CredentialCache();

        JsonSerializer jsGrej = new JsonSerializer();
        JsonReader jsReader;
        public dynamic json;
        Stations datan;
        string reqUrl;
        

        public ApiCaller(string file)
        {

            reqUrl = "http://api.tagtider.net/v1/";
            reqUrl += file;

            //Sätter upp get anropet med digest
            reqCred.Add(new Uri(reqUrl), "Digest", new NetworkCredential("tagtider", "codemocracy"));

            getThings();
        }

        private void getThings()
        {
            req = WebRequest.Create(reqUrl);
            req.Method = "GET";
            req.PreAuthenticate = true;
            req.Credentials = reqCred;

            // Hämtar datan
            stream = req.GetResponse().GetResponseStream();

            var streamReader = new StreamReader(stream);

            //Sparar datan i en "dynamisk", typ som en lista
            json = JsonConvert.DeserializeObject(streamReader.ReadToEnd().ToString());
        }

    }
}