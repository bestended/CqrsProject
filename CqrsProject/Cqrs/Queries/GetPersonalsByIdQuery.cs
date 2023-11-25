using CqrsProject.Cqrs.Results;
using MediatR;

namespace CqrsProject.Cqrs.Queries
{
    public class GetPersonalsByIdQuery:IRequest<GetPersonalsByIdQueryResult>
    {

        public int PersonalId { get; set; }
        public GetPersonalsByIdQuery(int id)
        {
            PersonalId = id;
        }



    }
}
