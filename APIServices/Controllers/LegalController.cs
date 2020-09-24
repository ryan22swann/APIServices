using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIDataAccess;

namespace APIServices.Controllers
{
    public class LegalController : ApiController
    {
        public  IEnumerable<Law_Classification> Get()
        {
            using(Gabriel_DBEntities entities = new Gabriel_DBEntities())
            {
                return entities.Law_Classification.ToList();
            }
        }
        public HttpResponseMessage Get(string Jurisdiction)
        {
            using (Gabriel_DBEntities entities = new Gabriel_DBEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, entities.Law_Classification.Where(e => e.Jurisdiction == Jurisdiction).ToList());

            }

        }
    }



}
