using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JestAppProj.Models;

namespace JestAppProj.Controllers
{
    public class UsersController : ApiController
    {
    
        public List<Users> Get(string email, string pass)
        {
            Users user = new Users();
            return user.LoginUser(email, pass);

        }

        public HttpResponseMessage Post([FromBody]Users users)
        {

            try
            {
                users.InsertUser();
                string msg = "Inserted Successesfully";
                return Request.CreateResponse(HttpStatusCode.OK, msg);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

    }
}