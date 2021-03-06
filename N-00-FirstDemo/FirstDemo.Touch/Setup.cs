using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.MvvmCross.ViewModels;

namespace FirstDemo.Touch
{
	public class Setup : MvxTouchSetup
	{
		public Setup (MvxApplicationDelegate applicationDelegate, IMvxTouchViewPresenter presenter) 
			: base(applicationDelegate,presenter)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new FirstDemo.Core.App ();
		}
	}
}

