using GestionCourseMVVM.Models;
using GestionCourseMVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GestionCourseMVVM.ViewModels
{
	public class ListeCoureurViewModel : BindableObject
	{
		private Course _course;
		private ListView _listView;
		public INavigation Navigation { get; set; }
		public Course Course { get => _course; set { _course = value; OnPropertyChanged(); } }
		public Command RetourCommand { get; set; }
		public Command AjouterCoureurCommand { get; set; }
		public ListeCoureurViewModel(INavigation navigation, Course course, ListView listView)
		{
			Navigation = navigation;
			Course = course;
			_listView = listView;
			RetourCommand = new Command(RetourAction);
			AjouterCoureurCommand = new Command(AjouterCoureurAction);
		}

		private void AjouterCoureurAction()
		{
			Navigation.PushModalAsync(new Inscription(Course, _listView));
		}

		private void RetourAction()
		{
			Navigation.PopModalAsync();
		}
	}
}
