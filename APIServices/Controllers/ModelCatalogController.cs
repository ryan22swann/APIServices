using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Design;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIDataAccess;
using APIServices.BusinessObjects;

namespace APIServices.Controllers
{
    public class ModelCatalogController : ApiController
    {
        ModelFacade facade = new ModelFacade();
        public IEnumerable<Model_Catalog> Get()
        {
            using (Gabriel_DBEntities entities = new Gabriel_DBEntities())
            {
                return entities.Model_Catalog.ToList(); 
            }
        }
        public HttpResponseMessage Get(string name1)
        {
            using (Gabriel_DBEntities entities = new Gabriel_DBEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, entities.Model_Catalog.Where(e => e.model_name == name1).ToList());

            }

        }
        // POST api/values
        public void Post([FromBody] ModelBO model)

        {
            facade.ModelService.Create(model);
        }
    }
}
