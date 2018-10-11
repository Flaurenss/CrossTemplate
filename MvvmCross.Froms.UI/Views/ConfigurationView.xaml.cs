using MvvmCross.Forms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Template.Forms.UI.Views
{
	public partial class ConfigurationView : MvxContentPage<ConfigurationViewModel>
    {
		public ConfigurationView()
		{
			InitializeComponent();
		}
	}
}