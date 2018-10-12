using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvvmCross.Tests;
using Template.Core.Helpers;
using Template.Core.ViewModels;

namespace Template.Test
{
    [TestClass]
    public class ConfigurationTests : MvxIoCSupportingTest
    {
        [TestMethod]
        public void TestSetInitialTimeCorrectly()
        {
            Setup();
            //Arrange
            int TimeToSet = 10;
            var settingsService = new Mock<IAppSettingsService>();
            settingsService.Setup(x => x.GetInitialTime()).Returns(10);
            var vm = new ConfigurationViewModel(settingsService.Object);
            //Act
            vm.ConfirmationCommand.Execute();
            //Assert
            Assert.IsTrue(vm.InitialTime==TimeToSet);
            Assert.IsTrue(vm.MessageColor == Color.Green);
        }
        [TestMethod]
        public void TestSetInitialTimeIncorrectly()
        {
            Setup();
            //Arrange
            int TimeToSet = 0;
            var settingsService = new Mock<IAppSettingsService>();
            settingsService.Setup(x => x.GetInitialTime()).Returns(10);
            var vm = new ConfigurationViewModel(settingsService.Object);
            //Act
            vm.ConfirmationCommand.Execute(TimeToSet);
            //Assert
            Assert.IsTrue(vm.InitialTime != TimeToSet);
        }
    }
}
