using GestionCourseMVVM.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestionCourseMVVM
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new ListeCourses();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
