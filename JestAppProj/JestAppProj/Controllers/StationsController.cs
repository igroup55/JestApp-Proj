﻿using JestAppProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JestAppProj.Controllers
{
    public class StationsController : ApiController
    {

        // GET api/<controller>/5
        public List<Stations> GetAllStations()
        {

            Stations stations = new Stations();
            return stations.GetStations();

        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}