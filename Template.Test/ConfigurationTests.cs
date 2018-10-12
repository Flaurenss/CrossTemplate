using Moq;
using NUnit.Framework;
using Template.Core.Helpers;
using Template.Core.ViewModels;

namespace Template.Test
{
    [TestFixture]
    public class ConfigurationTests
    {
        [Test]
        public void TestSetInitialTimeSettings()
        {
            var mockTipService = new Mock<IAppSettingsService>();
            //Arrange
            var vm = new ConfigurationViewModel(mockTipService.Object);
            var settings = new AppSettingsService();
            int TimeToSet = 10;
            //Act
            settings.SetInitialTime(TimeToSet);
            var time = settings.GetInitialTime();
            //Assert
            Assert.AreEqual(TimeToSet, time);
        }
    }
}
