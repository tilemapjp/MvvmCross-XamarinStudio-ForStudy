using System;
using System.Drawing;

using MonoTouch.CoreFoundation;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using KittenView.Core.ViewModels;
using Cirrious.MvvmCross.Binding.Touch.Views;

namespace KittenView.Touch.Views
{
	[Register("FirstView")]
	public class FirstView : MvxTableViewController
	{
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
	
			var source = new MvxStandardTableViewSource (TableView, "TitleText Name;ImageUrl ImageUrl");
			TableView.Source = source;

			var set = this.CreateBindingSet<FirstView, FirstViewModel> ();
			set.Bind (source).To (vm => vm.Kittens);
			set.Apply ();

			TableView.ReloadData ();
		}
	}
}

