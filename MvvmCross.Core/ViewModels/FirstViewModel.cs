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
        public string ButtonText { get; set; }
        public IMvxCommand ButtonCommand { get; set; }

        private readonly IMvxNavigationService _navigation;
        #endregion

        public FirstViewModel(IMvxNavigationService navigation)
        {
            _navigation = navigation;

            MainTitle = "Demo";
            ButtonText = "Next View";

            ButtonCommand = new MvxCommand(async ()=> await GoToPage());
        }

        public async Task GoToPage()
        {
            await _navigation.Navigate<SecondViewModel>();
        }

        public override async Task Initialize()
        {
            await base.Initialize();
        }
    }
}
