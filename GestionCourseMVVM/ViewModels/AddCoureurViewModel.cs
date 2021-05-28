using GestionCourseMVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GestionCourseMVVM.ViewModels
{
	public class AddCoureurViewModel : BindableObject
	{
		private Coureur _coureur;
		public INavigation Navigation { get; set; }
		public Coureur Coureur { get => _coureur; set { _coureur = value; OnPropertyChanged(); } }
		public Command ValiderCommand { get; set; }
		public AddCoureurViewModel(INavigation navigation)
		{
			Navigation = navigation;
			if (Coureur == null)
				Coureur = new Coureur();
			ValiderCommand = new Command(ValiderAction);
		}

		private void ValiderAction()
		{
			App.Coureurs.Add(Coureur);
			Navigation.PopModalAsync();
		}
	}
}
