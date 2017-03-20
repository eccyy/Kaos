using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kaos
{
    public static class DBStorer
    {
        public static bool StoreTransfer(string id, string arrival, string newArrival, string train, string type, string comment)
        {
            int Id = int.Parse(id);
            DateTime Arrival = DateTime.Parse(arrival);
            DateTime NewArrival = DateTime.Parse(newArrival);
            string Train = train;
            string Type = type;
            string Comment = comment;

            //SendToDB(Id, Arrival, NewArrival,...)
            return true; // Temporary // If DB was updated
        }
    }
}