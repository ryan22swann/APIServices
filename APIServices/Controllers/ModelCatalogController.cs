using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Design;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Windows.Forms;
using APIDataAccess;
using APIServices.BusinessObjects;
using APIServices.Converters;
using APIServices.Entities;
using Eml.ControllerBase;
using Microsoft.AspNetCore.Mvc;

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

        //public IEnumerable<ModelBO> Get()
        //{
        //    return facade.ModelService.GetAll();
        //}
        public HttpResponseMessage Get(int id)
        {
            using (Gabriel_DBEntities entities = new Gabriel_DBEntities())
            {
                //entities.
                return Request.CreateResponse(HttpStatusCode.OK, entities.Model_Catalog.Where(e => e.id == id).ToList());

            }

        }


        //public ModelBO Get(int id)
        //{
        //    return facade.ModelService.Get(id);
        //}
        // POST api/values
        //public ActionResult<Model> Post([Microsoft.AspNetCore.Mvc.FromBody] ModelBO modelBO)

        //{
        //    using (Gabriel_DBEntities entities = new Gabriel_DBEntities())
        //    {
        //        ModelConverter conv = new ModelConverter();
        //        var newModel = entities.Model_Catalog.  (conv.Convert(modelBO));

        //        return entities.Model_Catalog.Add(ModelConverter(;


        //    }

        // POST api/values
        public ActionResult<ModelBO> Post([System.Web.Http.FromBody] ModelBO model)
            {

                return facade.ModelService.Create(model);
            }
        // DELETE api/values
        public String Delete(int id)

        {
            try
            {
                facade.ModelService.Delete(id);
                return "Successfully deleted ID " + id;
            }
            catch(Exception e)
            {
                return "No Model Catalog entry found with ID " + id + "  " + e;
            }
                
            

        }

            
            
        

        //PUT api/values
        public IHttpActionResult Put(int id, [System.Web.Http.FromBody] ModelBO model)

        {
            if (id != model.Id)
            {
                return BadRequest("Path Id does not match Model ID in json object");
            }
            var model1 = facade.ModelService.Update(model);
            return Ok(model1);
        }
    }

}
