using System;
using System.Collections.Generic;
using System.Linq;
using Serilog;
using RazorApp.Repository.Models;

namespace RazorApp.Repository.Repo
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : Abstract
    {
        private readonly ApplicationContext dbContext;
        private readonly ILogger logger;

        public BaseRepository(ApplicationContext dbContext, ILogger logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }

        public IQueryable<T> Actives()
        {
            return All().Where(element => element.Active);
        }

        public void Add(T model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> All()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Deleted()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
