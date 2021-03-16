using JestAppProj.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JestAppProj.Models
{
    
    public class Customers
    {
        int customerID;
        string fullName;
        string address;
        int phoneNum;
        int packageId;

        public Customers(int customerID, string fullName, string address, int phoneNum, int packageId)
        {
            CustomerID = customerID;
            FullName = fullName;
            Address = address;
            PhoneNum = phoneNum;
            PackageId = packageId;
        }

        public int CustomerID { get => customerID; set => customerID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Address { get => address; set => address = value; }
        public int PhoneNum { get => phoneNum; set => phoneNum = value; }
        public int PackageId { get => packageId; set => packageId = value; }


        public int AddCust()
        {
            DBServices dbs = new DBServices();
            return dbs.AddCust(this);
        }
    }
}