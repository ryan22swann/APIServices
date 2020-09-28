

using System.Collections.Generic;
using APIServices.Context;
using System.Linq;
using APIServices.Entities;

namespace APIServices.Repositories
{
    class ModelRepositoryEFMemory : IModelRepository
    {
        GabrielAppContext _context;

        public ModelRepositoryEFMemory(GabrielAppContext context)
        {
            _context = context;
        }

        public Model Create(Model model)
        {
            _context.Model_Catalog.Add(model);
            return model;
        }

        public Model Delete(int Id)
        {
            var model = Get(Id);
            _context.Model_Catalog.Remove(model);
            return model;
        }

        public Model Get(int Id)
        {
            return _context.Model_Catalog.FirstOrDefault(x => x.Id == Id);
        }

        public List<Model> GetAll()
        {
            return _context.Model_Catalog.ToList();
        }
    }
}
