using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JestAppProj.Models.DAL;


namespace JestAppProj.Models
{
    public class Users
    {
        int userId;
        string fullName;
        string phoneNum;
        string emailAddress;
        string password;
        string profilePic;
        string birthDate;
        int rating;


        public Users() { }

        public Users(int userId, string fullName, string phoneNum, string emailAddress, string password, string profilePic, string birthDate, int rating)
        {
            UserId = userId;
            FullName = fullName;
            PhoneNum = phoneNum;
            EmailAddress = emailAddress;
            Password = password;
            ProfilePic = profilePic;
            BirthDate = birthDate;
            Rating = rating;
        }

        public int UserId { get => userId; set => userId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string Password { get => password; set => password = value; }
        public string ProfilePic { get => profilePic; set => profilePic = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public int Rating { get => rating; set => rating = value; }

        public int InsertUser()
        {
            DBServices dbs = new DBServices();
            return dbs.InsertUser(this);
        }

        public List<Users> LoginUser(string email, string pass)
        {
            DBServices dbs = new DBServices();
            List<Users> userlist = dbs.LoginUser(email, pass);
            return userlist;

        }

    }
}