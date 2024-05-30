﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context context = new Context();

        DbSet<Category> _object;

        public void Delete(Category c)
        {
            _object.Remove(c);
            context.SaveChanges();
        }

        public void Insert(Category c)
        {
            _object.Add(c);
            context.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category c)
        {
            context.SaveChanges();
        }
    }
}

/*
 * EF fonksiyonları
    ToList();
    Add();
    Remove();
    Find();

 */