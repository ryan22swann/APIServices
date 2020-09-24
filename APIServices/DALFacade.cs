using APIServices.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using APIServices.UOW;

namespace APIServices
{
    public class DALFacade
    {
        public IModelRepository CustomerRepository
        {
            //get { return new CustomerRepositoryFakeDB(); }
            get
            {
                return new ModelRepositoryEFMemory(
                    new Context.InMemoryContext());
            }
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return new UnitOfWorkMem();
            }
        }

    }
}
