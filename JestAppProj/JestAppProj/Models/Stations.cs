using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JestAppProj.Models.DAL;

namespace JestAppProj.Models
{
    public class Stations
    {
        int stationID;
        string stationName;

        public Stations()
        {
        }

        public Stations(int stationID, string stationName)
        {
            StationID = stationID;
            StationName = stationName;
        }

        public int StationID { get => stationID; set => stationID = value; }
        public string StationName { get => stationName; set => stationName = value; }

        public List<Stations> GetStations ()
        {
            DBServices dbs = new DBServices();
            List<Stations> StationList = dbs.GetAllStations();
            return StationList;
        }
    }

   
}