using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Template.Core.Helpers;

namespace Template.Core.ViewModels
{
    public class CountDownViewModel : MvxViewModel
    {
        #region Properties
        public bool Timer { get; set; }
        public string MainTitle { get; set; }
        public string IconPath { get; set; }
        public string StartButtonText { get; set; }
        public string PauseButtonText { get; set; }
        public string ResetButtonText { get; set; }
        public int InitialTime { get; set; }
        public IMvxCommand StartCommand { get; set; }
        public IMvxCommand OptionCommand { get; set; }
        public IMvxCommand PauseCommand { get; set; }
        public IMvxCommand ResetCommand { get; set; }
        private int _chronoTime;
        public int ChronoTime
        {
            get => _chronoTime;
            set
            {
                _chronoTime = value;
                RaisePropertyChanged(() => ChronoTime);
            }
        }
        private readonly IMvxNavigationService _navigation;
        private readonly IAppSettingsService _settings;
        #endregion

        public CountDownViewModel(IMvxNavigationService navigation, IAppSettingsService settings)
        {
            _navigation = navigation;
            _settings = settings;
            Timer = false;
            StartButtonText = "Start";
            PauseButtonText = "Pause";
            ResetButtonText = "Reset countdown";
            MainTitle = "Count Down";
            IconPath = "options_icon_toolbar.png";

            InitialTime = _settings.GetInitialTime();
            ChronoTime = InitialTime;
            OptionCommand = new MvxCommand(async ()=> await _navigation.Navigate<ConfigurationViewModel>());
            StartCommand = new MvxCommand(async ()=> await StartCountDown());
            PauseCommand = new MvxCommand(() => PauseCountDown());
            ResetCommand = new MvxCommand(() => ResetCountDown());
        }
        public void ResetCountDown()
        {
            Timer = false;
            ChronoTime = InitialTime;
        }
        public void PauseCountDown()
        {
            Timer = false;
        }
        public async Task StartCountDown()
        {
            Timer = true;
            await Task.Run(async () =>
            {
                while (Timer)
                {
                    if (ChronoTime == 0)
                    {
                        Timer = false;
                    }
                    else
                    {
                        ChronoTime--;
                    }
                    await Task.Delay(TimeSpan.FromSeconds(1));
                }
            });   
        }

        public override void ViewAppearing()
        {
            base.ViewAppearing();
            Timer = false;
            InitialTime = _settings.GetInitialTime();
            ChronoTime = InitialTime;
        }

        public override async Task Initialize()
        {
            await base.Initialize();
        }
    }
}