

using System.Collections.Generic;
using APIServices.Context;
using System.Linq;
using APIServices.Entities;

namespace APIServices.Repositories
{
    class ModelRepositoryEFMemory : IModelRepository
    {
        InMemoryContext _context;

        public ModelRepositoryEFMemory(InMemoryContext context)
        {
            _context = context;
        }

        public Model Create(Model model)
        {
            _context.Models.Add(model);
            return model;
        }

        public Model Delete(int Id)
        {
            var model = Get(Id);
            _context.Models.Remove(model);
            return model;
        }

        public Model Get(int Id)
        {
            return _context.Models.FirstOrDefault(x => x.Id == Id);
        }

        public List<Model> GetAll()
        {
            return _context.Models.ToList();
        }
    }
}
