using System;
using System.Collections.Generic;
using System.Text;
using O_Correct.Domain;
using O_Correct.Repository;
namespace O_Correct.Services
{
    public class UserService
    {
        private IRepository<User> repository;
        private IRegistrationServiceUsername registrationServiceUsername;
        public UserService()
        {
            repository = new UserRepository();
            registrationServiceUsername = new RegistrationServiceUsername();
        }

        public void CreateUser(User user)
        {
            if (!registrationServiceUsername.Check(user.Username)) return;

            repository.Create(user);
        }
    }
}
