using Cirrious.MvvmCross.ViewModels;
using TipCalc.Core.Services;

namespace TipCalc.Core.ViewModels
{
	public class FirstViewModel : MvxViewModel
	{
		private readonly ICalculationService _calcurationService;

		public FirstViewModel(ICalculationService calcurationService)
		{
			_calcurationService = calcurationService;
			_generosity = 20;
			_subTotal = 100;
			Recalc ();
		}

		private double _generosity;
		public double Generosity
		{
			get { return _generosity; }
			set { _generosity = value; RaisePropertyChanged (() => Generosity); Recalc (); }
		}

		private double _subTotal;
		public double SubTotal
		{
			get { return _subTotal; }
			set { _subTotal = value; RaisePropertyChanged (() => SubTotal); Recalc (); }
		}

		private double _tip;
		public double Tip
		{
			get { return _tip; }
			set { _tip = value; RaisePropertyChanged (() => Tip); }
		}

		private double _total;
		public double Total
		{
			get { return _total; }
			set { _total = value; RaisePropertyChanged (() => Total); }
		}

		private void Recalc()
		{
			Tip = _calcurationService.Tip (SubTotal, Generosity);
			Total = SubTotal + Tip;
		}
	}
}

