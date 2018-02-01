using SampleRestfulAPI.Interfaces;
using SampleRestfulAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SampleRestfulAPI.Repository
{
    public class UserRepository : IRepository<User>
    {
        static UserRepository()
        {
            Users = new List<User>();
        }

        private static List<User> Users { get; set; }
        private static int CurrentId { get; set; }

        public User Create(User user)
        {
            CurrentId++;
            user.Id = CurrentId;

            Users.Add(user);

            return user;
        }

        public void Delete(int id)
        {
            Users.RemoveAll(user => user.Id == id);
        }

        public User Get(int id)
        {
            User retorno = Users.Where(user => user.Id == id).FirstOrDefault();
            return retorno;
        }

        public IEnumerable<User> GetAll()
        {
            return Users;
        }

        public User Update(User entity)
        {
            int index = Users.FindIndex(user => user.Id == entity.Id);
            Users[index] = entity;

            return Users[index];
        }
    }
}