using JestAppProj.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JestAppProj.Models
{
    public class Packages
    {
        int packageId;
        string startStation;
        string endStation;
        float pweight;
        bool expressP;
        bool status;

        public Packages(int packageId, string startStation, string endStation, float pweight, bool expressP, bool status)
        {
            PackageId = packageId;
            StartStation = startStation;
            EndStation = endStation;
            Pweight = pweight;
            ExpressP = expressP;
            Status = status;
        }

        public int PackageId { get => packageId; set => packageId = value; }
        public string StartStation { get => startStation; set => startStation = value; }
        public string EndStation { get => endStation; set => endStation = value; }
        public float Pweight { get => pweight; set => pweight = value; }
        public bool ExpressP { get => expressP; set => expressP = value; }
        public bool Status { get => status; set => status = value; }

        public void AddPack()
        {
            DBServices dbs = new DBServices();
             dbs.AddPack(this);

        }
    }

  
}