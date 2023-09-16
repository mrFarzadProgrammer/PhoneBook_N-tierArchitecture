using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataBase
{
    public class DataBaseContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog = DBContact;Integrated Security= True");
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
