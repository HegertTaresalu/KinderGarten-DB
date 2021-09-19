using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Children> Childrens { get; set; }
        public DbSet<Cook> Cooks { get; set; }
        public DbSet<Educators> Educators { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<KinderGarden> KinderGardens { get; set; }
        public DbSet<Kitchen> Kitchens { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet <Methodologist> Methodologists { get; set; }
        public DbSet <Parent> Parents { get; set;}
        public  DbSet <Queue> Queues { get; set; }
        public DbSet<Senior_Educator> Senior_Educators { get; set; }

     




    }
}