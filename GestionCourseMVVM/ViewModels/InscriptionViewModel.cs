using GestionCourseMVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GestionCourseMVVM.ViewModels
{
	public class InscriptionViewModel : BindableObject
	{
		private List<Coureur> _coureurs;
		private ListView _listView;
		public Course Course { get; set; }
		public List<Coureur> Coureurs { get => _coureurs; set { _coureurs = value; OnPropertyChanged(); } }
		public INavigation Navigation { get; set; }
		public InscriptionViewModel(Course course, ListView listView, INavigation navigation)
		{
			Course = course;
			_listView = listView;
			Coureurs = App.Coureurs;
			Navigation = navigation;
		}

		internal void Item_Tapped(Coureur item)
		{
			if (Course.Coureurs == null)
				Course.Coureurs = new List<Coureur>();
			Course.Coureurs.Add(item);
			_listView.ItemsSource = null;
			_listView.ItemsSource = Course.Coureurs;
			Navigation.PopModalAsync();
		}
	}
}
