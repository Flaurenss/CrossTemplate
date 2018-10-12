using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Template.Core.Helpers;
using Template.Core.ViewModels;

namespace UnitTestProject1
{
    [TestClass]
    public class ConfigurationTests
    {
        [TestMethod]
        public void TestSetInitialTime()
        {
            //Arrange
            int TimeToSet = 10;
            var settingsService = new Mock<IAppSettingsService>();
            settingsService.Setup(x => x.GetInitialTime()).Returns(TimeToSet);
            var _settings = settingsService.Object;
            //Act
            _settings.SetInitialTime(TimeToSet);
            var time = _settings.GetInitialTime();
            //Assert
            Assert.AreEqual(TimeToSet, time);
        }
    }
}
