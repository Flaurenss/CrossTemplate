using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template.Core.Helpers;
using Template.Core.ViewModels;

namespace Template.UnitTest
{
    [TestClass]
    public class ConfigurationTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            IAppSettingsService AppSettings = new AppSettingsService();
            var vm = new ConfigurationViewModel(AppSettings);
            AppSettings.SetInitialTime(10);
            //Act
            vm.SetInitialTime(5);
            //Assert
        }
    }
}
