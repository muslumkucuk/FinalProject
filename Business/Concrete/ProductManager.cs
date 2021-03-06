﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İŞ KODLARI
            //Yetkisi var mı?
            //vs. vs.??
            return _ProductDal.GetAll();
        }

        public IEnumerable<object> GetAllByUnitPrice(int v)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _ProductDal.GetAll(prop => prop.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _ProductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _ProductDal.GetProductDetails();
        }
    }
}
