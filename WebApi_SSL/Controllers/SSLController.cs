using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CBDocumentData;

namespace WebApi_SSL.Controllers
{
    public class SSLController : ApiController
    {
        // POST: api/SSL
        public void Post([FromBody]SSL SSLMembers)
        {
            /* 
             * Step #1
             * Turn object into XML by passing the object to a library
             * 
             */
            SSL.AddDataSSL(SSLMembers);
        }

        // PUT: api/SSL_/5
        public void Put(int id, [FromBody]SSL SSLMembers)
        {

        }
    }
}
