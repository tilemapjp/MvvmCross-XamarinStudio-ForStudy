using Cirrious.MvvmCross.ViewModels;
using Template.Core.Services;

namespace Template.Core.ViewModels
{
	public class FirstViewModel : MvxViewModel
	{
		private readonly ITemplateService _templateService;

		public FirstViewModel(ITemplateService templateService)
		{
			_templateService = templateService;
			SayHello = _templateService.SayHello ();
		}

		private string _sayHello;
		public string SayHello
		{
			get { return _sayHello; }
			set { _sayHello = value; RaisePropertyChanged (() => SayHello); }
		}
	}
}

