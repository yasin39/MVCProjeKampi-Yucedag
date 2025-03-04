﻿using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }

        public void AddCategory(Category cat)
        {
            if (cat.CategoryName == "" || cat.CategoryName.Length <= 3 ||
                cat.CategoryDescription == "" || cat.CategoryName.Length >= 51)
            {
                //hata mesajı fırlat
            }
            else
            {
                repo.Insert(cat);
            }
        }
    }
}
