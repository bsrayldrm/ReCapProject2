﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Car, RentaCarContext>, IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(Brand entity)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                return filter == null
                    ? context.Set<Brand>().ToList()
                    : context.Set<Brand>().Where(filter).ToList();
            }
        }
        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }
    }
}
