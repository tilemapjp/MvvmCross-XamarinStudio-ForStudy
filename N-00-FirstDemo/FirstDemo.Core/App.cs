using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;

namespace FirstDemo.Core
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			CreatableTypes ()
				.EndingWith ("service")
					.AsInterfaces ()
					.RegisterAsLazySingleton ();
			RegisterAppStart<ViewModels.FirstViewModel>();
		}
	}
}

