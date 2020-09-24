using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using APIServices.Entities;
using APIServices.BusinessObjects;
using APIServices.Converters;
using APIServices;

namespace APIServices.Services
{
    class ModelService : IModelService
    {
        ModelConverter conv = new ModelConverter();
        DALFacade facade;
        public ModelService(DALFacade facade)
        {
            this.facade = facade;
        }

        public ModelBO Create(ModelBO model)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newModel = uow.ModelRepository.Create(conv.Convert(model));
                uow.Complete();
                return conv.Convert(newModel);
            }
        }

        public ModelBO Delete(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newModel = uow.ModelRepository.Delete(Id);
                uow.Complete();
                return conv.Convert(newModel);
            }
        }

        public ModelBO Get(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                return conv.Convert(uow.ModelRepository.Get(Id));
            }
        }

        public List<ModelBO> GetAll()
        {
            using (var uow = facade.UnitOfWork)
            {
                //Customer -> CustomerBO
                //return uow.CustomerRepository.GetAll();
                return uow.ModelRepository.GetAll().Select(conv.Convert).ToList();
            }
        }

        public ModelBO Update(ModelBO model)
        {
            using (var uow = facade.UnitOfWork)
            {
                var modelFromDb = uow.ModelRepository.Get(model.Id);
                if (modelFromDb == null)
                {
                    throw new InvalidOperationException("Model not found");
                }

                modelFromDb.model_name = model.model_name;
                modelFromDb.model_version = model.model_version;
                modelFromDb.model_url = model.model_url;
                uow.Complete();
                return conv.Convert(modelFromDb);
            }

        }

    }
}
