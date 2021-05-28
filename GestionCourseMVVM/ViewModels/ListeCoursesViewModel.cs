using GestionCourseMVVM.Models;
using GestionCourseMVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GestionCourseMVVM.ViewModels
{
	public class ListeCoursesViewModel : BindableObject
	{
		private List<Course> _courses;
		private ListView _listView;
		public List<Course> Courses { get => _courses; set { _courses = value; OnPropertyChanged(); } }
		public Command AjouterCoureurCommand { get; set; }
		public Command AjouterCourseCommand { get; set; }
		public INavigation Navigation { get; set; }

		public ListeCoursesViewModel(INavigation navigation, ListView listView)
		{
			Navigation = navigation;
			if (Courses == null)
				Courses = new List<Course>();
			Courses = App.Courses;
			_listView = listView;
			AjouterCoureurCommand = new Command(AjouterCoureurAction);
			AjouterCourseCommand = new Command(AjouterCourseAction);
		}

		private void AjouterCourseAction()
		{
			Navigation.PushModalAsync(new AddCourse(_listView));
		}

		private void AjouterCoureurAction()
		{
			Navigation.PushModalAsync(new AddCoureur());
		}

		public void Item_Tapped(Course course)
		{
			Navigation.PushModalAsync(new ListeCoureur(course));
		}
	}
}
