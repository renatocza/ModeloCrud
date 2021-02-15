using FluentValidation;
using App.Domain.Entities;
using App.Domain.Interfaces;
using App.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using App.Infra.Data.Context;
using System.Linq;

namespace App.Service.Services
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        internal BaseRepository<T> repository;

        public BaseService(ApiContext context)
        {
            repository = new BaseRepository<T>(context);
        }

        public virtual T Post<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Insert(obj);
            return obj;
        }

        public virtual T Put<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Update(obj);
            return obj;
        }

        public virtual void Delete(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("The id can't be empty.");

            repository.Delete(id);
        }

        public virtual IList<T> Get()
        {
            return repository.Select().ToList();
        }

        public virtual T Get(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("The id can't be empty.");

            return repository.Select(id);
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("No data found!");

            validator.ValidateAndThrow(obj);
        }

        public virtual T Single(Func<T, bool> p)
        {
            return repository.Single(p);
        }

        public virtual IEnumerable<T> Get(Func<T, bool> p)
        {
            throw new NotImplementedException();
        }

        public virtual T Post(T obj)
        {
            throw new NotImplementedException();
        }

        public virtual T Put(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
