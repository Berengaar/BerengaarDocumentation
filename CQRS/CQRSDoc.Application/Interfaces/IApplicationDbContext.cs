using CQRSDoc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSDoc.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        public List<Product> Products { get; }
    }
}
