using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Template.Core.Helpers;

namespace Template.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        #region Properties
        public string ConfigTitle { get; set; }
        public string Expltext { get; set; }
        public string ConfirmationButton { get; set; }
        public IMvxCommand ConfirmationCommand { get; set; }

        private int _initialTime;
        private string _message;
        private bool _isEnabled;
        private Color _messageColor;
        private readonly IAppSettingsService _settings;

        public int InitialTime
        {
            get => _initialTime;
            set
            {
                _initialTime = value;
                RaisePropertyChanged(() => InitialTime);
            }
        }
        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                RaisePropertyChanged(() => Message);
            }
        }
        public bool MessageIsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                RaisePropertyChanged(() => MessageIsEnabled);
            }
        }
        public Color MessageColor
        {
            get => _messageColor;
            set
            {
                _messageColor = value;
                RaisePropertyChanged(() => MessageColor);
            }
        }
        #endregion

        public SecondViewModel(IAppSettingsService settings)
        {
            _settings = settings;
            ConfigTitle = "Configuration";
            Expltext = "Set initial seconds:";
            ConfirmationButton = "Set time";
            MessageIsEnabled = false;
            InitialTime = _settings.GetInitialTime();

            ConfirmationCommand = new MvxCommand(() => SetInitialTime(InitialTime));
        }

        public override async Task Initialize()
        {
            await base.Initialize();
        }

        public void SetInitialTime(int initialNum)
        {
            //Maybe Symbology checkers can be deleted
            var numToString = initialNum.ToString();
            var tmp1 = numToString.Contains(",");

            if (initialNum == 0)
            {
                MessageIsEnabled = true;
                Message = "Please enter an integer number different from 0";
                MessageColor = Color.Red;
            }
            else
            {
                InitialTime = initialNum;
                MessageIsEnabled = true;
                Message = "Time set correctly to " + InitialTime;
                MessageColor = Color.Green;
                _settings.SetInitialTime(InitialTime);
            }
        }
    }
}
