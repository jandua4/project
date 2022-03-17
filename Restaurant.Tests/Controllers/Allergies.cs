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
    public class Allergies
    {

        private async Task<ApplicationDbContext> GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var databaseContext = new ApplicationDbContext(options);
            databaseContext.Database.EnsureCreated();
            if (await databaseContext.Allergies.CountAsync() <= 0)
            {
                databaseContext.Allergies.AddRange(Allergy());
                await databaseContext.SaveChangesAsync();
            }
            return databaseContext;
        }

        private List<Allergy> Allergy()
        {
            return new List<Allergy>
            {
                new Allergy
                {
                    AllergyID = 100,
                    Name = "Test",
                    GroupID = 1
                },
                new Allergy
                {
                    AllergyID = 101,
                    Name = "Test2",
                    GroupID = 1
                }
            };
        }


        [Fact]
        public async Task Index_ReturnsAViewResult_WithAListOfAllergies()
        {
            //Arrange
            var dbContext = await GetDatabaseContext();
            var allergiesController = new AllergiesController(dbContext);
            //Act
            var result = await allergiesController.Index("", "", null);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Allergy>>(
                viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
        }

        [Fact]
        public async Task Details_ReturnsViewResultWithAllergyModel()
        {
            //Arrange
            var dbContext = await GetDatabaseContext();
            var allergiesController = new AllergiesController(dbContext);

            //Act
            var result = await allergiesController.Details(100);

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<Allergy>(
                viewResult.ViewData.Model);
            Assert.Equal(100, model.AllergyID);
            Assert.Equal("Test", model.Name);
            Assert.Equal(1, model.GroupID);
        }

        [Fact]
        public async Task Edit_ReturnsHttpNotFoundWhenAllergyIdNotFound()
        {
            //Arrange
            var AllergyID = 1000;
            var dbContext = await GetDatabaseContext();
            var allergiesController = new AllergiesController(dbContext);

            //Act
            var result = await allergiesController.Edit(AllergyID);

            //Assert
            Assert.IsType<NotFoundResult>(result);

        }
    }
}