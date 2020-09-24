using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIDataAccess;

namespace APIServices.Controllers
{
    public class RecordController : ApiController
    {
        public IEnumerable<Law_Recording_Classification> Get()
        {
            using (Gabriel_DBEntities entities = new Gabriel_DBEntities())
            {
                return entities.Law_Recording_Classification.ToList(); 
            }
        }
        public HttpResponseMessage Get(string State)
        {
            using (Gabriel_DBEntities entities = new Gabriel_DBEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, entities.Law_Recording_Classification.Where(e => e.STATE == State).ToList());

            }

        }
    }
}
