using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using APIServices.BusinessObjects;

namespace APIServices.Services
{

    public interface IModelCatalog
    {
        //C
        ModelBO Create(ModelBO cust);
        //R
        List<ModelBO> GetAll();
        ModelBO Get(int Id);
        //U
        ModelBO Update(ModelBO cust);
        //D
        ModelBO Delete(int Id);
    }
}