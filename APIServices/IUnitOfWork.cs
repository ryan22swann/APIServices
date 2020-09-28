using APIServices.Context;
using System;
namespace APIServices
{
    public interface IUnitOfWork : IDisposable
    {
        IModelRepository ModelRepository { get; }


        int Complete();
        //IModelRepository = new ModelRepository(context);
    }

  



}


