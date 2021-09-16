using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Database.Entities
{
    public class DatabaseContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source = DESKTOP-HIQOAFN\SQLEXPRESS; initial catalog=UserMicroservice; persist security info=True; User ID = adm; Password = adm");
        }
    }
}
