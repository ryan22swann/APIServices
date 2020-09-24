using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIServices.BusinessObjects;
using System.Text;

namespace APIServices
{

    public interface IModelService
    {
        //C
        ModelBO Create(ModelBO Model);
        //R
        List<ModelBO> GetAll();
        ModelBO Get(int Id);
        //U
        ModelBO Update(ModelBO Model);
        //D
        ModelBO Delete(int Id);
    }
}
