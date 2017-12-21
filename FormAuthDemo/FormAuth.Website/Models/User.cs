using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}