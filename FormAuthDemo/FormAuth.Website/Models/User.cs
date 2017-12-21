using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormAuth.Website.Models
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}