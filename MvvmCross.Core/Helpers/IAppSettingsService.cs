using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core.Helpers
{
    public interface IAppSettingsService
    {
        void SetInitialTime(int time);
        int GetInitialTime(); 
    }
}
