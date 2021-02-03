using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category product);
        void Delete(Category product);
        List<Category> GetAllByCategory(int categoryId);
    }
}
