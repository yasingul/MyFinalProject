using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemortProductDal : IProductDal
    {
        void IProductDal.Add(Product product)
        {
            throw new NotImplementedException();
        }

        void IProductDal.Delete(Product product)
        {
            throw new NotImplementedException();
        }

        List<Product> IProductDal.GetAll()
        {
            throw new NotImplementedException();
        }

        void IProductDal.Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
