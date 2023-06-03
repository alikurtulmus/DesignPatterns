using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class GetProductUpdateByIDQuery:IRequest<UpdateProductByIDQueryResult>
    {
        public GetProductUpdateByIDQuery(int productID)
        {
            ProductID = productID;
        }

        public int ProductID { get; set; }
    }
}
