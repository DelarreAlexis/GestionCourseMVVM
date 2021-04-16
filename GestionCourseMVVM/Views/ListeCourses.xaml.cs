using GestionCourseMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestionCourseMVVM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListeCourses : ContentPage
	{
		public ListeCourses()
		{
			InitializeComponent();
			BindingContext = new ListeCoursesViewModel();
		}
	}
}