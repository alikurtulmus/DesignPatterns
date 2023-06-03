using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class GetProductByIDQuery:IRequest<GetProductByIDQueryResult>
    {
        public GetProductByIDQuery(int id)
        {
            ProductID = id;
        }

        public int ProductID { get; set; }
    }
}
