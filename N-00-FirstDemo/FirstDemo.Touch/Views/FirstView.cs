using System;
using System.Drawing;

using MonoTouch.CoreFoundation;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using FirstDemo.Core.ViewModels;

namespace FirstDemo.Touch.Views
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
			
			// Perform any additional setup after loading the view, typically from a nib.
			var textEditFirst = new UITextField (new RectangleF (0, 0, 320, 40));
			Add (textEditFirst);

			var textEditLast = new UITextField (new RectangleF (0, 50, 320, 40));
			Add (textEditLast);

			var labelFull = new UILabel (new RectangleF (0, 100, 320, 40));
			Add (labelFull);

			var set = this.CreateBindingSet<FirstView, FirstViewModel> ();
			set.Bind (textEditFirst).To (vm => vm.FirstName);
			set.Bind (textEditLast).To (vm => vm.LastName);
			set.Bind (labelFull).To (vm => vm.FullName);
			set.Apply ();
		}
	}
}

