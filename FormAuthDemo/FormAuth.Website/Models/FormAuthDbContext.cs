using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FormAuth.Website.Models
{
    public class FormAuthDbContext : DbContext
    {
        public System.Data.Entity.DbSet<FormAuth.Website.Models.User> Users { get; set; }
    }
}