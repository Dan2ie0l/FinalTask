using RazorApp.Repository;
using RazorApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorApp.Services.Services
{
    public class BaseService<T> : IBaseService<T>
        where T : Abstract
    {
       
            private  IBaseRepository<T> repo;

            public BaseService(IBaseRepository<T> repository)
            {
                this.repo = repository;
            }

            public IEnumerable<T> Actives()
            {
                return repo.Actives();
            }

            public IEnumerable<T> All()
            {
                return repo.All();
            }

            public IEnumerable<T> Deleted()
            {
                return repo.Deleted();
            }

            public T GetById(int id)
            {
                return repo.GetById(id);
            }

            public void Add(T model)
            {
                model.Active = true;
                model.ModifiedOn = DateTime.Now;
                model.CreatedOn = DateTime.Now;
                repo.Add(model);
            }

            public bool Delete(int id)
            {
                return repo.Delete(id);
            }

            public void Update(T model)
            {
                repo.Update(model);
            }
        }
    }
