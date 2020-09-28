using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIServices.Services;
using System.Text;


namespace APIServices
{
    public class ModelFacade
    {
        public IModelService ModelService
        {
            get { return new ModelService(new DALFacade()); }
        }

    }
}
