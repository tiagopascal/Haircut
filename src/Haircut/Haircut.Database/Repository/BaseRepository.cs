﻿using Haircut.Database.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haircut.Database.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        protected DatabaseContext _context;

        public BaseRepository()
        {
            _context = new DatabaseContext();
        }

        public virtual void Add(T entity) 
        {       
                 
            _context.Set(typeof(T)).Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _context.Set(typeof(T)).Remove(entity);
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }
    }
}