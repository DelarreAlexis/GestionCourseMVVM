using GestionCourseMVVM.Models;
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
	public partial class ListeCoureur : ContentPage
	{
		public ListeCoureur(Course course)
		{
			InitializeComponent();
			BindingContext = new ListeCoureurViewModel(Navigation, course, lstCoureur);
		}
	}
}