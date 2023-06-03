using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Queries;
using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler : IRequestHandler<GetProductUpdateByIDQuery, UpdateProductByIDQueryResult>
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<UpdateProductByIDQueryResult> Handle(GetProductUpdateByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.ProductID);
            return new UpdateProductByIDQueryResult
            {
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductStock = values.ProductStock,
                ProductPrice = values.ProductPrice,
                ProductCategory = values.ProductCategory,
                ProductStockType = values.ProductStockType
            };
        }
    }
}
