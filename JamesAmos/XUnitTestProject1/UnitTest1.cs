using System;
using Xunit;
using JamesAmos.Models;
using JamesAmos.Data;
using JamesAmos.Controllers;
using Microsoft.EntityFrameworkCore;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Getters()
        {
            //arrange
            HomePage homePage = new HomePage();
            homePage.CardOneImageUrl = "abcd";

            //assert
            Assert.Equal("abcd", homePage.CardOneImageUrl);

        }

        [Fact]
        public void Getters2()
        {
            //arrange
            HomePage homePage = new HomePage();
            homePage.CardOneImageUrl = "abcd";
            homePage.CardOneText = "Hi";

            //assert
            Assert.Equal("Hi", homePage.CardOneText);

        }

        [Fact]
        public void Getters3()
        {
            //arrange
            HomePage homePage = new HomePage();
            homePage.CardOneImageUrl = "abcd";
            homePage.CardOneText = "Hi";
            homePage.CardOneTitle = "this";

            //assert
            Assert.Equal("this", homePage.CardOneTitle);

        }

        [Fact]
        public void setters()
        {
            //arrange
            HomePage homePage = new HomePage();
            homePage.CardOneImageUrl = "abcd";
            homePage.CardOneText = "Hi";
            homePage.CardOneTitle = "this";

            //act
            homePage.CardOneTitle = "tacos";

            //assert
            Assert.Equal("tacos", homePage.CardOneTitle);

        }

        [Fact]
        public void setters2()
        {
            //arrange
            HomePage homePage = new HomePage();
            homePage.CardOneImageUrl = "abcd";
            homePage.CardOneText = "Hi";
            homePage.CardOneTitle = "this";

            //act
            homePage.CardOneImageUrl = "tacos";

            //assert
            Assert.Equal("tacos", homePage.CardOneImageUrl);

        }

        [Fact]
        public void setters3()
        {
            //arrange
            HomePage homePage = new HomePage();
            homePage.CardOneImageUrl = "abcd";
            homePage.CardOneText = "Hi";
            homePage.CardOneTitle = "this";

            //act
            homePage.CardOneText = "bye";

            //assert
            Assert.Equal("bye", homePage.CardOneText);

        }

        [Fact]
        public async void CreateVlogWorks()
        {
            DbContextOptions<JamesAmosDbContext> options =
                new DbContextOptionsBuilder<JamesAmosDbContext>
                ().UseInMemoryDatabase("CreateVlog").Options;

            using (JamesAmosDbContext context = new JamesAmosDbContext(options))
            {
                // arrange
                Vlog vlog = new Vlog();
                vlog.ID = 1;
                vlog.Subject = "stuff";
                vlog.VideoUrl = "URL";

                // Act
                context.Vlogs.Add(vlog);

                context.SaveChanges();

                var created = await context.Vlogs.FirstOrDefaultAsync(v => v.ID == vlog.ID);

                // Assert
                Assert.Equal(vlog, created);

            }
        }

        [Fact]
        public async void DeleteVlogWorks()
        {
            DbContextOptions<JamesAmosDbContext> options =
                new DbContextOptionsBuilder<JamesAmosDbContext>
                ().UseInMemoryDatabase("DeleteVlog").Options;

            using (JamesAmosDbContext context = new JamesAmosDbContext(options))
            {
                // arrange
                Vlog vlog = new Vlog();
                vlog.ID = 1;
                vlog.Subject = "stuff";
                vlog.VideoUrl = "URL";

                // Act
                context.Vlogs.Add(vlog);

                context.SaveChanges();

                var toDelete = await context.Vlogs.FirstOrDefaultAsync(v => v.ID == vlog.ID);

                context.Remove(toDelete);

                context.SaveChanges();

                var deleted = await context.Vlogs.FirstOrDefaultAsync(v => v.ID == vlog.ID);
                // Assert
                Assert.Null(deleted);

            }
        }

        [Fact]
        public async void CreateHomePage()
        {
            DbContextOptions<JamesAmosDbContext> options =
                new DbContextOptionsBuilder<JamesAmosDbContext>
                ().UseInMemoryDatabase("CreateHomePage").Options;

            using (JamesAmosDbContext context = new JamesAmosDbContext(options))
            {
                // arrange
                HomePage homePage = new HomePage();
                homePage.ID = 1;
                homePage.CardOneTitle = "hi";

                // Act
                context.HomePage.Add(homePage);

                context.SaveChanges();

                var created = await context.HomePage.FirstOrDefaultAsync(h => h.ID == homePage.ID);

                // Assert
                Assert.Equal(homePage, created);

            }
        }

        [Fact]
        public async void DeleteHomePage()
        {
            DbContextOptions<JamesAmosDbContext> options =
                new DbContextOptionsBuilder<JamesAmosDbContext>
                ().UseInMemoryDatabase("DeleteHomePage").Options;

            using (JamesAmosDbContext context = new JamesAmosDbContext(options))
            {
                // arrange
                HomePage homePage = new HomePage();
                homePage.ID = 1;
                homePage.CardOneTitle = "hi";

                // Act
                context.HomePage.Add(homePage);

                context.SaveChanges();

                var toDelete = await context.HomePage.FirstOrDefaultAsync(h => h.ID == homePage.ID);

                context.HomePage.Remove(toDelete);

                context.SaveChanges();

                var deleted = await context.HomePage.FirstOrDefaultAsync(h => h.ID == homePage.ID);
                // Assert
                Assert.Null(deleted);

            }
        }

        [Fact]
        public async void EditHomePage()
        {
            DbContextOptions<JamesAmosDbContext> options =
                new DbContextOptionsBuilder<JamesAmosDbContext>
                ().UseInMemoryDatabase("EditHomePage").Options;

            using (JamesAmosDbContext context = new JamesAmosDbContext(options))
            {
                // arrange
                HomePage homePage = new HomePage();
                homePage.ID = 1;
                homePage.CardOneTitle = "hi";

                // Act
                context.HomePage.Add(homePage);

                context.SaveChanges();

                var created = await context.HomePage.FirstOrDefaultAsync(h => h.ID == homePage.ID);

                created.CardOneTitle = "bye";

                context.SaveChanges();
                // Assert
                Assert.Equal("bye", created.CardOneTitle);

            }
        }
    }
}
