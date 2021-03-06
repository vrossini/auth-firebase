using Android.OS;
using Android.App;
using App.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace App.UI.Droid.Views
{
    [Activity(Label = "App.UI.Droid")]
    public class SignUpView : MvxActivity<SignUpViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SignUpView);
        }
    }
}