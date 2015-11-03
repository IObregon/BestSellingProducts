using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BestSellingProducts;
using BestSellingProducts.Controllers;
using BestSellingProducts.Core;
using Moq;
using BestSellingProducts.Models;

namespace BestSellingProducts.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private Mock<IBestSellingProductsDataSource> mockBestSellingProductsDataSource = new Mock<IBestSellingProductsDataSource>();
        [TestMethod]
        public void Index()
        {
            // Arrange
            
            var expect = new List<GetTopTen_Result>(10);
            mockBestSellingProductsDataSource.Setup(m => m.GetTopTen()).Returns(expect);
            HomeController controller = new HomeController(mockBestSellingProductsDataSource.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);

            var model = result.ViewData.Model as List<GetTopTen_Result>;

            Assert.AreEqual(model.Count, expect.Count);
        }

        [TestMethod]
        public void TopByCategory()
        {
            // Arrange
            HomeController controller = new HomeController(mockBestSellingProductsDataSource.Object);

            // Act
            ViewResult result = controller.TopByCategory() as ViewResult;

            // Assert
           
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController(mockBestSellingProductsDataSource.Object);

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);

            Assert.AreEqual("Iker Obregon Reigosa", result.ViewBag.Message);
        }
    }
}
