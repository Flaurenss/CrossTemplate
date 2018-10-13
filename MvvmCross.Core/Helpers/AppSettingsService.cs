using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core.Helpers
{
    public class AppSettingsService : IAppSettingsService
    {
        public int GetInitialTime()
        {
            var initialTime = Plugin.Settings.CrossSettings.Current.GetValueOrDefault("initial-time",10);
            return initialTime;
        }

        public void SetInitialTime(int time)
        {
            Plugin.Settings.CrossSettings.Current.AddOrUpdateValue("initial-time", time);
        }
    }
}
