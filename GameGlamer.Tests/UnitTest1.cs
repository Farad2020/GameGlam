using GameGlamer.Controllers;
using GameGlamer.Data;
using GameGlamer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace GameGlamer.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestToCheckIfEverythingWorking()
        {
            Assert.Pass();
        }

        //Testing Home Controller
        [Test]
        public void HomeControllerIndexTest()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<HomeController>>();

            var controller = new HomeController(mockLogger.Object);
            // Act
            var result = controller.IndexAsync();

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void HomeControllerPrivacyTest()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<HomeController>>();

            var controller = new HomeController(mockLogger.Object);
            // Act
            var result = controller.Privacy();

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void HomeControllerSearchTest()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<HomeController>>();

            var controller = new HomeController(mockLogger.Object);
            // Act
            var result = controller.Search("Withcer");

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void GamesControllerIndexTest()
        {
            // Arrange
            var mockCont = new Mock<ApplicationDbContext>(new DbContextOptions<ApplicationDbContext>());

            var controller = new GameDealsController(mockCont.Object);
            // Act
            var result = controller.Index();

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void GamesControllerCreateTest()
        {
            // Arrange
            var mockCont = new Mock<ApplicationDbContext>(new DbContextOptions<ApplicationDbContext>());

            var controller = new GameDealsController(mockCont.Object);
            // Act
            var result = controller.Create();

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void GamesControllerDetailsTest()
        {
            // Arrange
            var mockCont = new Mock<ApplicationDbContext>(new DbContextOptions<ApplicationDbContext>());

            var controller = new GameDealsController(mockCont.Object);
            // Act
            var result = controller.Details(4);

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void LootControllerIndexTest()
        {
            // Arrange
            var mockCont = new Mock<ApplicationDbContext>(new DbContextOptions<ApplicationDbContext>());

            var controller = new DLCorLootDealsController(mockCont.Object);
            // Act
            var result = controller.Index();

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void LootControllerCreateTest()
        {
            // Arrange
            var mockCont = new Mock<ApplicationDbContext>(new DbContextOptions<ApplicationDbContext>());

            var controller = new DLCorLootDealsController(mockCont.Object);
            // Act
            var result = controller.Create();

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void LootControllerDetailsTest()
        {
            // Arrange
            var mockCont = new Mock<ApplicationDbContext>(new DbContextOptions < ApplicationDbContext >());

            var controller = new DLCorLootDealsController(mockCont.Object);
            // Act
            var result = controller.Details(40);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}