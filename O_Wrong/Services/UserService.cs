using System;
using System.Collections.Generic;
using System.Text;
using O_Wrong.Domain;
using O_Wrong.Repository;
namespace O_Wrong.Services
{
    public class UserService
    {
        private IRepository<User> repository;
        public UserService()
        {
            repository = new UserRepository();
        }

        public void CreateUser(User user)
        {
            if (user.Username == "root" | user.Username == "admin")
                throw new InvalidOperationException();

            repository.Create(user);
        }
    }
}
