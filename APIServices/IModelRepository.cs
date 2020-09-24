using APIServices.Entities;
using System.Collections.Generic;

namespace APIServices
{
    public interface IModelRepository
    {
        //C
        Model Create(Model model);
        //R
        List<Model> GetAll();
        Model Get(int Id);
        //U
        //No Update for Repository, It will be the task of Unit of Work
        //D
        Model Delete(int Id);
    }
}
