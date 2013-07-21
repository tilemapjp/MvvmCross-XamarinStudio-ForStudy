using System;
using System.Drawing;

using MonoTouch.CoreFoundation;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using Template.Core.ViewModels;

namespace Template.Touch.Views
{
	[Register("UniversalView")]
	public class UniversalView : UIView
	{
		public UniversalView()
		{
			Initialize ();	
		}

		public UniversalView(RectangleF bounds) : base(bounds)
		{
			Initialize ();
		}

		void Initialize()
		{
			BackgroundColor = UIColor.White;	
		}
	}

	[Register("FirstView")]
	public class FirstView : MvxViewController
	{
		public FirstView ()
		{
		}

		public override void ViewDidLoad ()
		{
			View = new UniversalView ();

			base.ViewDidLoad ();

			var helloLabel = new UILabel (new RectangleF (10, 0, 300, 40));
			Add (helloLabel);

			var set = this.CreateBindingSet<FirstView, FirstViewModel> ();
			set.Bind (helloLabel).To (vm => vm.SayHello);
			set.Apply ();
		}
	}
}

