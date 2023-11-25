using CqrsProject.Cqrs.Queries;
using CqrsProject.Cqrs.Results;
using CqrsProject.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CqrsProject.Cqrs.Handlers
{
    public class GetPersonalsByIdQueryHandler : IRequestHandler<GetPersonalsByIdQuery, GetPersonalsByIdQueryResult>
    {
        private readonly PersonalContext _context;
        public GetPersonalsByIdQueryHandler(PersonalContext context)
        {
            _context = context;
        }

        public async Task<GetPersonalsByIdQueryResult> Handle(GetPersonalsByIdQuery request, CancellationToken cancellationToken)
        {

            var personal = await _context.Set<Personals>().FindAsync(request.PersonalId);
            return new GetPersonalsByIdQueryResult
            {
               Name=personal.Name,
               LastName=personal.LastName,
               Age=personal.Age,
               Salary=personal.Salary
            };
        }
    }
}
