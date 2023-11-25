using MediatR;

namespace CqrsProject.Cqrs.Commands
{
    public class RemovePersonalsCommand:IRequest
    {


        public int PersonelId { get; set; }

        public RemovePersonalsCommand(int id)
        {
            PersonelId = id;
        }
    }
}
