using MediatR;

namespace CqrsProject.Cqrs.Commands
{
    public class UpdatePersonalsCommand:IRequest
    {
        public int PersonelId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }




    }
}
