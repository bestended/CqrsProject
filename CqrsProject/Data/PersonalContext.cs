using Microsoft.EntityFrameworkCore;
namespace CqrsProject.Data
{
    public class PersonalContext:DbContext
    {

        public PersonalContext(DbContextOptions<PersonalContext>options):base(options)
        {
                
        }

        public DbSet<Personals> Personals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personals>().HasData(new Personals[]
            {

                new Personals(){Name="Sinan",LastName="Sarı",Age=38, Salary=50000,PersonelId =1},
                new Personals(){Name="Suzan",LastName="Kaya",Age=37, Salary=60000,PersonelId =2}


            });

            base.OnModelCreating(modelBuilder);
        }


    }
}
