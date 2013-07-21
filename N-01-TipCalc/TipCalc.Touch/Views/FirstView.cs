using System;
using System.Drawing;

using MonoTouch.CoreFoundation;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using TipCalc.Core.ViewModels;

namespace TipCalc.Touch.Views
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

			var subTotalLabel = new UILabel (new RectangleF (10, 0, 300, 40));
			subTotalLabel.Text = "SubTotal";
			Add (subTotalLabel);

			var subTotalTextField = new UITextField (new RectangleF (10, 40, 300, 40));
			Add (subTotalTextField);

			var generosityLabel = new UILabel (new RectangleF (10, 80, 300, 40));
			generosityLabel.Text = "SubTotal";
			Add (generosityLabel);

			var generositySlider = new UISlider(new RectangleF (10, 120, 300, 40));
			generositySlider.MinValue = 0;
			generositySlider.MaxValue = 100;
			Add (generositySlider);

			var tipLabel = new UILabel (new RectangleF (10, 160, 300, 40));
			tipLabel.Text = "Tip";
			Add (tipLabel);

			var tipShow = new UILabel (new RectangleF (10, 200, 300, 40));
			Add (tipShow);

			var totalLabel = new UILabel (new RectangleF (10, 240, 300, 40));
			totalLabel.Text = "Total";
			Add (totalLabel);

			var totalShow = new UILabel (new RectangleF (10, 280, 300, 40));
			Add (totalShow);

			var set = this.CreateBindingSet<FirstView, FirstViewModel> ();
			set.Bind (subTotalTextField).To (vm => vm.SubTotal);
			set.Bind (generositySlider).To (vm => vm.Generosity);
			set.Bind (tipShow).To (vm => vm.Tip);
			set.Bind (totalShow).To (vm => vm.Total);
			set.Apply ();

			var gesture = new UITapGestureRecognizer (() => {
				subTotalTextField.ResignFirstResponder();
			});
			View.AddGestureRecognizer (gesture);
		}
	}
}

