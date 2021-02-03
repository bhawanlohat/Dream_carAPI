using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dream_carAPI.Models;

namespace Dream_carAPI.Data
{
    public class Dream_carAPIDatabase : DbContext
    {
        public Dream_carAPIDatabase (DbContextOptions<Dream_carAPIDatabase> options)
            : base(options)
        {
        }

        public DbSet<Dream_carAPI.Models.Car> Car { get; set; }
    }
}
