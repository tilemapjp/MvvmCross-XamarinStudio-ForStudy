using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace Template.Droid
{
	[Activity (Label = "Template", MainLauncher=true, Icon="@drawable/icon")]			
	public class SplashScreen : MvxSplashScreenActivity
	{
		public SplashScreen() 
			: base(Resource.Layout.SplashScreen)
		{
		}
	}
}

