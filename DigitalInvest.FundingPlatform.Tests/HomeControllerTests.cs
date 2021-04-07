using Xunit;
using Moq;
using System.Threading.Tasks;
using DigitalInvest.FundingPlatform.Services;
using DigitalInvest.FundingPlatform.Models;
using System.Collections.Generic;
using System;
using DigitalInvest.FundingPlatform.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DigitalInvest.FundingPlatform.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public async Task IndexAsync_ValidRequest_ReturnsAViewResultWithFundings()
        {
            // Arrange
            var mockService = new Mock<IService<FundingViewModel>>();
            var testFundings = new List<FundingViewModel>() {
                new FundingViewModel(),
                new FundingViewModel()
            };
            mockService.Setup(srv => srv.GetAllAsync())
                .ReturnsAsync(testFundings);
            var controller = new HomeController(mockService.Object);

            // Act
            var result = await controller.IndexAsync();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<FundingViewModel>>(
    viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
        }
    }
}
