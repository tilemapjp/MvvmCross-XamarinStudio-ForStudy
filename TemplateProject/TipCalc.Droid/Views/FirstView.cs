using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace Template.Droid.Views
{
	[Activity (Label = "Template")]			
	public class FirstView : MvxActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.FirstView);
			// Create your application here
		}
	}
}

