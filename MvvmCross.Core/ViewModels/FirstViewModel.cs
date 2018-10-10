using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Template.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        #region Properties
        public string MainTitle { get; set; }
        public string IconPath { get; set; }
        public string StartButtonText { get; set; }
        public IMvxCommand ButtonCommand { get; set; }
        public IMvxCommand OptionCommand { get; set; }

        private readonly IMvxNavigationService _navigation;
        #endregion

        public FirstViewModel(IMvxNavigationService navigation)
        {
            _navigation = navigation;

            StartButtonText = "Startttt";
            MainTitle = "Count Down";
            IconPath = "options_icon_toolbar.png";

            OptionCommand = new MvxCommand(async ()=> await _navigation.Navigate<SecondViewModel>());
        }


        public override async Task Initialize()
        {
            await base.Initialize();
        }
    }
}
