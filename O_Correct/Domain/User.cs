using System;
using System.Collections.Generic;
using System.Text;

namespace O_Correct.Domain
{
    public class User
    {
        public Guid Id { get; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
