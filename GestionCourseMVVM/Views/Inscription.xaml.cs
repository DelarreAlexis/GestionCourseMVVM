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
	public partial class Inscription : ContentPage
	{
		public Inscription(Course course, ListView listView)
		{
			InitializeComponent();
			BindingContext = new InscriptionViewModel(course, listView, Navigation);
		}

		private void lstCoureur_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			((InscriptionViewModel)BindingContext).Item_Tapped((Coureur)e.Item);
		}
	}
}