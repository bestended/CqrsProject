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
    public class GetPersonalsQueryHandler : IRequestHandler<GetPersonalsQuery, IEnumerable<GetPersonalsQueryResult>>
    {
        private readonly PersonalContext _context;
        public GetPersonalsQueryHandler(PersonalContext context)
        {
            _context = context;
        }




        public async Task<IEnumerable<GetPersonalsQueryResult>> Handle(GetPersonalsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Personals.Select(x => new GetPersonalsQueryResult { Name = x.Name, LastName = x.LastName,Age=x.Age,Salary=x.Salary }).AsNoTracking().ToListAsync();
        }




        public IEnumerable<GetPersonalsQueryResult> Handle(GetPersonalsQuery query)
        {
            return _context.Personals.Select(x => new GetPersonalsQueryResult { Name = x.Name, LastName = x.LastName, Age = x.Age, Salary = x.Salary }).AsNoTracking().AsEnumerable();
        }











    }
}
