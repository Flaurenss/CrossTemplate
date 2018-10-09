using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Core.ViewModels;

namespace Template.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            //Some bootstraping code
            RegisterAppStart<FirstViewModel>();
        }
    }
}
