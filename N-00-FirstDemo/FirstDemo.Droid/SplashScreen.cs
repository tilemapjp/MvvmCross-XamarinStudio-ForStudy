using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace FirstDemo.Droid
{
	[Activity(Label="FirstDemo", MainLauncher=true, Icon="@drawable/icon")] 
	class SplashScreen : MvxSplashScreenActivity
	{
		public SplashScreen () : base(Resource.Layout.SplashScreen)
		{
		}
	}
}

