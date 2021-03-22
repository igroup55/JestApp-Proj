using JestAppProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JestAppProj.Controllers
{
    public class LockersController : ApiController
    {
        // GET api/<controller>
        public List<Lockers> Get()
        {

            Lockers lockers = new Lockers();
            return lockers.GetEmptyLocker();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
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