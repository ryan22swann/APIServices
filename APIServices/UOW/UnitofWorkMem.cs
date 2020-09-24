

using System;
using APIServices.Context;
using APIServices.Repositories;

namespace APIServices.UOW
{
    public class UnitOfWorkMem : IUnitOfWork
    {
        public IModelRepository ModelRepository { get; internal set; }
        private InMemoryContext context;

        public UnitOfWorkMem()
        {
            context = new InMemoryContext();
            ModelRepository = new ModelRepositoryEFMemory(context);
        }

        public int Complete()
        {
            //The number of objects written to the underlying database.
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

    }
}
