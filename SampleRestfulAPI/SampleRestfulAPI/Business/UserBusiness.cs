using SampleRestfulAPI.Exceptions;
using SampleRestfulAPI.Interfaces;
using SampleRestfulAPI.Models;
using SampleRestfulAPI.Repository;
using System;
using System.Collections.Generic;

namespace SampleRestfulAPI.Business
{
    public class UserBusiness : IBusiness<User>
    {
        public UserBusiness()
        {
            Repository = new UserRepository();
        }

        public IRepository<User> Repository { get; set; }

        public User Create(User user)
        {
            Validate(user);
            User retorno = Repository.Create(user);

            return retorno;
        }

        public void Delete(int id)
        {
            Repository.Delete(id);
        }

        public User Get(int id)
        {
            User retorno = Repository.Get(id);
            return retorno;
        }

        public IEnumerable<User> GetAll()
        {
            IEnumerable<User> retorno = Repository.GetAll();
            return retorno;
        }

        public User Update(User entity)
        {
            Validate(entity, false);
            User retorno = Repository.Update(entity);

            return retorno;
        }

        public void Validate(User user, bool isNew = true)
        {
            if (!isNew && user.Id == 0) throw new ValidateException("ID precisa ser preenchido");
            if (string.IsNullOrEmpty(user.Name)) throw new ValidateException("nome precisa ser preenchido!");
            if (user.Birthdate == default(DateTime)) throw new ValidateException("data de nascimento precisa ser preenchido!");
        }
    }
}