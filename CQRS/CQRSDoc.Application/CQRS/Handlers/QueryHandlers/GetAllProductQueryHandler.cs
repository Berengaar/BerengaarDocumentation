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
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllProductQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            return _context.Products.Select(product => new GetAllProductQueryResponse
            {
                Id = product.Id,
                CreateTime = DateTime.Now,
                Name = product.Name,
                Price = product.Price,
                Quantity=product.Quantity
            }).ToList();
        }
    }
}
