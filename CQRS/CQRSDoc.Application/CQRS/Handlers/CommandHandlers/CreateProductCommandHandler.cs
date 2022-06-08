using CQRSDoc.Application.CQRS.Commands.Request;
using CQRSDoc.Application.CQRS.Commands.Response;
using CQRSDoc.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSDoc.Application.CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        private readonly IApplicationDbContext _context;
        public CreateProductCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            _context.Products.Add(new()
            {
                Id = id,
                Name = request.Name,
                Price = request.Price,
                CreateTime = DateTime.Now,
                Quantity = request.Quantity
            });

            return new CreateProductCommandResponse { IsSuccess = true, ProductId = id };
        }
    }
}
