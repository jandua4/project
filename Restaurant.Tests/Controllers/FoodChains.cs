using Restaurant.Controllers;
using Restaurant.Data;
using Restaurant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.Hosting;

namespace Restaurant.Tests.Controllers
{
    public class FoodChains
    {

        private readonly IHostEnvironment hostingEnvironment;

        private async Task<ApplicationDbContext> GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var databaseContext = new ApplicationDbContext(options);
            databaseContext.Database.EnsureCreated();
            if (await databaseContext.FoodChains.CountAsync() <= 0)
            {
                databaseContext.FoodChains.AddRange(FoodChain());
                await databaseContext.SaveChangesAsync();
            }
            return databaseContext;
        }

        private List<FoodChain> FoodChain()
        {
            return new List<FoodChain>
            {
                new FoodChain
                {
                    FoodChainID = 11,
                    FoodChainName="Test",
                    Description="blah",
                    MenuLink=null,
                    GlutenFreeOptions="Yes",
                    DairyFreeOptions="No",
                    NutFreeOptions="Yes",
                    VegetarianOptions="Yes",
                    VeganOptions="No",
                    OtherOptions="Celery, Shellfish"
                },
                new FoodChain
                {
                    FoodChainID = 12,
                    FoodChainName="Test2",
                    Description="blah2",
                    MenuLink=null,
                    GlutenFreeOptions="Yes",
                    DairyFreeOptions="No",
                    NutFreeOptions="Yes",
                    VegetarianOptions="Yes",
                    VeganOptions="No",
                    OtherOptions="Soya, Celery, Shellfish"
                }
            };
        }


        [Fact]
        public async Task Index_ReturnsAViewResult_WithAListOfFoodChains()
        {
            //Arrange
            var dbContext = await GetDatabaseContext();
            var foodChainsController = new FoodChainsController(dbContext, hostingEnvironment);
            //Act
            var result = await foodChainsController.Index("", "", "", null);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<FoodChain>>(
                viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
        }

        [Fact]
        public async Task Details_ReturnsViewResultWithFoodChainModel()
        {
            //Arrange
            var dbContext = await GetDatabaseContext();
            var foodChainsController = new FoodChainsController(dbContext, hostingEnvironment);

            //Act
            var result = await foodChainsController.Details(11);

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<FoodChain>(
                viewResult.ViewData.Model);
            Assert.Equal(11, model.FoodChainID);
            Assert.Equal("Test", model.FoodChainName);
            Assert.Equal("blah", model.Description);
            Assert.Null(model.MenuLink);
            Assert.Equal("Yes", model.GlutenFreeOptions);
            Assert.Equal("No", model.DairyFreeOptions);
            Assert.Equal("Yes", model.NutFreeOptions);
            Assert.Equal("Yes", model.VegetarianOptions);
            Assert.Equal("No", model.VeganOptions);
            Assert.Equal("Celery, Shellfish", model.OtherOptions);
        }

        [Fact]
        public async Task Edit_ReturnsHttpNotFoundWhenFoodChainIdNotFound()
        {
            //Arrange
            var FoodChainID = 100;
            var dbContext = await GetDatabaseContext();
            var foodChainsController = new FoodChainsController(dbContext, hostingEnvironment);

            //Act
            var result = await foodChainsController.Edit(FoodChainID);

            //Assert
            Assert.IsType<NotFoundResult>(result);

        }
    }
}