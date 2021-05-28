using GestionCourseMVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GestionCourseMVVM.ViewModels
{
	public class AddCourseViewModel : BindableObject
	{
		private ListView _listeView;
		public Course _course { get; set; }
		public INavigation Navigation { get; set; }
		public Course Course { get => _course; set { _course = value; OnPropertyChanged(); } }
		public Command ValiderCommand { get; set; }
		public AddCourseViewModel(INavigation navigation, ListView listView )
		{
			Navigation = navigation;
			_listeView = listView;
			ValiderCommand = new Command(ValiderAction);
			Course = new Course();
		}

		private void ValiderAction()
		{
			App.Courses.Add(Course);
			_listeView.ItemsSource = null;
			_listeView.ItemsSource = App.Courses;
			Navigation.PopModalAsync();
		}
	}
}
