using CQRSDoc.Application.CQRS.Queries.Request;
using CQRSDoc.Application.CQRS.Queries.Response;
using CQRSDoc.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSDoc.Application.CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        private readonly IApplicationDbContext _context;

        public GetByIdProductQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = _context.Products.SingleOrDefault(s => s.Id == request.Id);
            return new GetByIdProductQueryResponse
            {
                Id = product.Id,
                CreateTime = product.CreateTime,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity
            };
        }
    }
}
