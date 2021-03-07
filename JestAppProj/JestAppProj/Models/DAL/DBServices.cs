﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.Configuration;
using JestAppProj.Models;

namespace JestAppProj.Models.DAL
{
    public class DBServices
    {
        public List<Stations> GetAllStations()
        {
            SqlConnection con = null;
            List<Stations> StationList = new List<Stations>();

            try
            {
                con = Connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

                String selectSTR = "SELECT * FROM Stations";
                SqlCommand cmd = new SqlCommand(selectSTR, con);

                // get a reader
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

                while (dr.Read())
                {   // Read till the end of the data into a row
                    Stations R = new Stations
                    {
                      
                    };
                    StationList.Add(R);
                }

                return StationList;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }

        }

      
        public int AddPack(Packages packages)
        {

            SqlConnection con;
            SqlCommand cmd;

            try
            {
                con = Connect("DBConnectionString"); // create the connection
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }

            string cStr = BuildInsertCommand(packages);      // helper method to build the insert string

            cmd = CreateCommand(cStr, con);             // create the command

            try
            {
                int numEffected = cmd.ExecuteNonQuery(); // execute the command
                return numEffected;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }

            finally
            {
                if (con != null)
                {
                    //close the db connection
                    con.Close();
                }
            }

        }

        public SqlConnection Connect(string conString)
        {
            // read the connection string from the configuration file
            string cStr = WebConfigurationManager.ConnectionStrings[conString].ConnectionString;
            SqlConnection con = new SqlConnection(cStr);
            con.Open();
            return con;
        }

        private string BuildInsertCommand(Packages packages)
        {
            string command;

            StringBuilder sb = new StringBuilder();
            // use a string builder to create the dynamic string
            sb.AppendFormat("Values ('{0}','{1}',{2},'{3}','{4}')", packages.StartStation, packages.EndStation,packages.Pweight ,packages.ExpressP,packages.Status );
            string prefix = "INSERT INTO Packages ([StartStation],[EndStation],[Pweight],[ExpressP],[Status])";

            command = prefix + sb.ToString() + "SELECT @@IDENTITY";


            return command;
        }

        private SqlCommand CreateCommand(string CommandSTR, SqlConnection con)
        {

            SqlCommand cmd = new SqlCommand
            {
                Connection = con,              // assign the connection to the command object

                CommandText = CommandSTR,      // can be Select, Insert, Update, Delete 

                CommandTimeout = 10,           // Time to wait for the execution' The default is 30 seconds

                CommandType = System.Data.CommandType.Text // the type of the command, can also be stored procedure
            }; // create the command object

            return cmd;
        }
    }
}