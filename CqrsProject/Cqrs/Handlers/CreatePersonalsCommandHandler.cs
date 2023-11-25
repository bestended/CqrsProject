using CqrsProject.Cqrs.Commands;
using CqrsProject.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CqrsProject.Cqrs.Handlers
{
    public class CreatePersonalsCommandHandler : IRequestHandler<CreatePersonalsCommand>
    {
        public readonly PersonalContext _context;
        public CreatePersonalsCommandHandler(PersonalContext context)
        {
            _context = context;
        }


        public async Task<Unit> Handle(CreatePersonalsCommand request, CancellationToken cancellationToken)
        {

            _context.Personals.Add(new Personals { Name = request.Name, LastName = request.LastName, Age = request.Age, Salary = request.Salary });
            await _context.SaveChangesAsync();
            return Unit.Value;

        }
    }
}
