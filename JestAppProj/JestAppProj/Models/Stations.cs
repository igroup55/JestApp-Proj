using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JestAppProj.Models.DAL;

namespace JestAppProj.Models
{
    public class Stations
    {
        int id;
        string stationName;

        public Stations() { }

        public Stations(int id, string stationName)
        {
            Id = id;
            StationName = stationName;
        }

        public int Id { get => id; set => id = value; }
        public string StationName { get => stationName; set => stationName = value; }

     

        public List<Stations> GetStations ()
        {
            DBServices dbs = new DBServices();
            List<Stations> StationList = dbs.GetAllStations();
            return StationList;
        }
    }

   
}