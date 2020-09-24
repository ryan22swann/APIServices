using System;
namespace APIServices
{
    public interface IUnitOfWork : IDisposable
    {
        IModelRepository ModelRepository { get; }

        int Complete();
    }
}
