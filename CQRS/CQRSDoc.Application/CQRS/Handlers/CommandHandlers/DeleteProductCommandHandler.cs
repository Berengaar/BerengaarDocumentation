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
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        private readonly IApplicationDbContext _context;

        public DeleteProductCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var deletedProduct = _context.Products.FirstOrDefault(f => f.Id == request.Id);
            _context.Products.Remove(deletedProduct);
            return new DeleteProductCommandResponse { IsSuccess = true };
        }
    }
}
