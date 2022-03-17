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
    public class AllergyGroups
    {

        private async Task<ApplicationDbContext> GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var databaseContext = new ApplicationDbContext(options);
            databaseContext.Database.EnsureCreated();
            if (await databaseContext.AllergyGroups.CountAsync() <= 0)
            {
                databaseContext.AllergyGroups.AddRange(AllergyGroup());
                await databaseContext.SaveChangesAsync();
            }
            return databaseContext;
        }

        private List<AllergyGroup> AllergyGroup()
        {
            return new List<AllergyGroup>
            {
                new AllergyGroup
                {
                    GroupID = 100,
                    GroupName = "Test"
                },
                new AllergyGroup
                {
                    GroupID = 101,
                    GroupName = "Test2"
                }
            };
        }


        [Fact]
        public async Task Index_ReturnsAViewResult_WithAListOfAllergyGroups()
        {
            //Arrange
            var dbContext = await GetDatabaseContext();
            var allergyGroupsController = new AllergyGroupsController(dbContext);
            //Act
            var result = await allergyGroupsController.Index("", "", null);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<AllergyGroup>>(
                viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
        }

        [Fact]
        public async Task Details_ReturnsViewResultWithAllergyGroupModel()
        {
            //Arrange
            var dbContext = await GetDatabaseContext();
            var allergyGroupController = new AllergyGroupsController(dbContext);

            //Act
            var result = await allergyGroupController.Details(100);

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<AllergyGroup>(
                viewResult.ViewData.Model);
            Assert.Equal(100, model.GroupID);
            Assert.Equal("Test", model.GroupName);
        }

        [Fact]
        public async Task Edit_ReturnsHttpNotFoundWhenGroupIdNotFound()
        {
            //Arrange
            var GroupID = 1000;
            var dbContext = await GetDatabaseContext();
            var allergyGroupController = new AllergyGroupsController(dbContext);

            //Act
            var result = await allergyGroupController.Edit(GroupID);

            //Assert
            Assert.IsType<NotFoundResult>(result);

        }
    }
}