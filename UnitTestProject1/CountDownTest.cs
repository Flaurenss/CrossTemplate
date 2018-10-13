using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvvmCross.Navigation;
using MvvmCross.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Helpers;
using Template.Core.ViewModels;

namespace Template.Test
{
    [TestClass]
    public class CountDownTest : MvxIoCSupportingTest
    {
        [TestMethod]
        public void TestStartCountdown()
        {
            Setup();
            //Arrange
            var settingsService = new Mock<IAppSettingsService>();
            var navigation = new Mock<IMvxNavigationService>();
            settingsService.Setup(x => x.GetInitialTime()).Returns(10);
            //Act
            var vm = new CountDownViewModel(navigation.Object, settingsService.Object);
            vm.StartCountDown().Wait();
            //Assert
            Assert.IsTrue(vm.Timer == false);
            Assert.IsTrue(vm.ChronoTime == 0);
        }
        [TestMethod]
        public void TestResetCountdown()
        {
            Setup();
            //Arrange
            var settingsService = new Mock<IAppSettingsService>();
            var navigation = new Mock<IMvxNavigationService>();
            settingsService.Setup(x => x.GetInitialTime()).Returns(10);
            //Act
            var vm = new CountDownViewModel(navigation.Object, settingsService.Object);
            vm.StartCountDown().Wait();
            Assert.AreEqual(vm.ChronoTime, 0);
            vm.ResetCountDown();
            //Assert
            Assert.AreEqual(vm.ChronoTime,vm.InitialTime);
        }
        [TestMethod]
        public void TestPauseCountdown()
        {
            Setup();
            //Arrange
            var settingsService = new Mock<IAppSettingsService>();
            var navigation = new Mock<IMvxNavigationService>();
            settingsService.Setup(x => x.GetInitialTime()).Returns(10);
            //Act
            var vm = new CountDownViewModel(navigation.Object, settingsService.Object);
            vm.StartCountDown();
            Assert.IsTrue(vm.ChronoTime == vm.ChronoTime--);
            Assert.IsTrue(vm.Timer == true);
            vm.PauseCountDown();
            //Assert
            Assert.IsTrue(vm.Timer == false);
        }
    }
}
