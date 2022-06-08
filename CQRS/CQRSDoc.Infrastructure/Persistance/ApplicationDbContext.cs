using CQRSDoc.Application.Interfaces;
using CQRSDoc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSDoc.Infrastructure.Persistance
{
    public class ApplicationDbContext : IApplicationDbContext
    {
        private readonly List<Product> _products;
        public ApplicationDbContext()
        {
            _products = new List<Product>
            {
                new() {Id=Guid.NewGuid(),Name="Product 1",Price=100,Quantity=10,CreateTime=DateTime.Now},
                new() {Id=Guid.NewGuid(),Name="Product 2",Price=200,Quantity=20,CreateTime=DateTime.Now},
                new() {Id=Guid.NewGuid(),Name="Product 3",Price=300,Quantity=30,CreateTime=DateTime.Now},
                new() {Id=Guid.NewGuid(),Name="Product 4",Price=400,Quantity=40,CreateTime=DateTime.Now},
                new() {Id=Guid.NewGuid(),Name="Product 5",Price=500,Quantity=50,CreateTime=DateTime.Now}
            };
        }

        public List<Product> Products { get => _products; }

    }
}
