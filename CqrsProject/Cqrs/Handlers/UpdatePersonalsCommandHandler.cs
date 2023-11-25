using CqrsProject.Cqrs.Commands;
using CqrsProject.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CqrsProject.Cqrs.Handlers
{
    public class UpdatePersonalsCommandHandler:IRequestHandler<UpdatePersonalsCommand>
    {
        private readonly PersonalContext _context;
        public UpdatePersonalsCommandHandler(PersonalContext context)
        {


            _context = context;

        }

        public async Task<Unit> Handle(UpdatePersonalsCommand request, CancellationToken cancellationToken)
        {
            var updatedPersonal = _context.Personals.Find(request.PersonelId);
            updatedPersonal.Name = request.Name;
            updatedPersonal.LastName = request.LastName;
            updatedPersonal.Age = request.Age;
            updatedPersonal.Salary = request.Salary;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
