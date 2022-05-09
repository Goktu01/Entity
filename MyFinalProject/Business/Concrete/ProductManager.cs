using Business.Abstract;
using DataAccess2.Abstract;
using DataAccess2.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal; 
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId==id);
        }

        public List<Product> GetAllByUnitPrice(decimal min, decimal max)
        {
           return _productDal.GetAll(p=>p.UnitPrice<=max &&p.UnitPrice>=min);
        }

        public List<Product> GettAll()
        {
            return _productDal.GetAll();
        } 
    }
}
