using System.Data.Entity;

namespace GestaodeAtivos.Models
{
    public class DataContexto : DbContext
        
    {
        public DataContexto() : base("GestaodeAtivos")
        {

        }

        public DbSet<Computador> Computadores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConventions>
        }
    }

   
}