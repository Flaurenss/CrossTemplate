using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.Forms.Platforms.Android.Core;
using Template.Core;
using Template.Forms.UI;
using Android.Content.PM;

namespace Template.Forms.Droid
{
    [Activity(
        Label = "Template",
        //Label = "@string/app_name",
        Theme = "@style/AppTheme",
        MainLauncher = false,
        LaunchMode = LaunchMode.SingleTask,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MvxFormsAppCompatActivity
    {
        //No splash screen use this 
        //MvxFormsAppCompatActivity<MvxFormsAndroidSetup<App, FormsApp>, App, FormsApp>
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(bundle);

        }
    }
}