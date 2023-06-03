﻿using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                ProductName=request.ProductName,
                ProductPrice=request.ProductPrice,
                ProductStock=request.ProductStock,
                ProductStockType=request.ProductStockType,
                ProductCategory=request.ProductCategory
            });
            await _context.SaveChangesAsync();
        }
    }
}
