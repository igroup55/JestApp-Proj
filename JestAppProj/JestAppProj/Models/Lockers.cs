using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JestAppProj.Models.DAL;

namespace JestAppProj.Models
{
    public class Lockers
    {
        int lockerID;
        bool busy;
        int packageID;
        string stationName;

        public Lockers()
        {
        }

        public Lockers(int lockerID, bool busy, int packageID, string stationName)
        {
            LockerID = lockerID;
            Busy = busy;
            PackageID = packageID;
            StationName = stationName;
        }

        public int LockerID { get => lockerID; set => lockerID = value; }
        public bool Busy { get => busy; set => busy = value; }
        public int PackageID { get => packageID; set => packageID = value; }
        public string StationName { get => stationName; set => stationName = value; }

        public List<Lockers> GetEmptyLocker()
        {
            DBServices dbs = new DBServices();
            return dbs.GetEmptyLocker(this);
        }
    }
}