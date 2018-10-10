using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Template.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        #region Properties
        public string ConfigTitle { get; set; }
        public string Expltext { get; set; }
        public string ConfirmationButton { get; set; }
        public IMvxCommand ConfirmationCommand { get; set; }

        private string _initialTime;
        private string _message;
        private bool _isEnabled;
        private Color _messageColor;
        public string InitialTime
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

        public SecondViewModel()
        {
            ConfigTitle = "Configuration";
            Expltext = "Set initial seconds:";
            ConfirmationButton = "Set time";
            MessageIsEnabled = false;
            InitialTime = "10";

            ConfirmationCommand = new MvxCommand(async () => await SetInitialTime(InitialTime));
        }

        public override async Task Initialize()
        {
            await base.Initialize();
        }

        public async Task SetInitialTime(string initialNum)
        {
            Regex regex = new Regex("^[1-9][0-9]*$");
            if (!regex.IsMatch(initialNum))
            {
                MessageIsEnabled = true;
                Message = "Please enter an integer number";
                MessageColor = Color.Red;
            }
            else
            {
                MessageIsEnabled = true;
                Message = "Time set correctly";
                MessageColor = Color.Green;
                //TODO save time on app settings file
            }
        }
    }
}
