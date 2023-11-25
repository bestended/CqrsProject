using CqrsProject.Cqrs.Commands;
using CqrsProject.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CqrsProject.Cqrs.Handlers
{
    public class RemovePersonalsCommandHandler : IRequestHandler<RemovePersonalsCommand>
    {
        private readonly PersonalContext _context;
        public RemovePersonalsCommandHandler(PersonalContext context)
        {
            _context = context;
        }

        public void Handle(RemovePersonalsCommand command)
        {
            var deletedEntity = _context.Personals.Find(command.PersonelId);
            _context.Personals.Remove(deletedEntity);
            _context.SaveChanges();


        }

        public async Task<Unit> Handle(RemovePersonalsCommand request, CancellationToken cancellationToken)
        {
            var deletedEntity = _context.Personals.Find(request.PersonelId);
            _context.Personals.Remove(deletedEntity);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
