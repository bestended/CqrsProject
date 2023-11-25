using System.ComponentModel.DataAnnotations;

namespace CqrsProject.Data
{
    public class Personals
    {
        [Key]
        public int PersonelId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
       

    }
}
