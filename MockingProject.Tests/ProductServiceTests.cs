using MockingProject.models;
using MockingProject.repositories;
using MockingProject.repositories.interfaces;
using MockingProject.services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MockingProject.Tests
{
    public class ProductServiceTests
    {
        [Fact]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            // Arrange
            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(x => x.GetAllProducts())
                .Returns(new List<Product>
                {
                new Product { Id = 1, Name = "Product 1", Price = 10.0m },
                new Product { Id = 2, Name = "Product 2", Price = 20.0m },
                new Product { Id = 3, Name = "Product 3", Price = 30.0m }
                });

            var productService = new ProductService(mockProductRepository.Object);

            // Act
            var result = productService.GetAllProducts();

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Equal("Product 1", result[0].Name);
            Assert.Equal("Product 2", result[1].Name);
            Assert.Equal("Product 3", result[2].Name);
        }
    }
}
