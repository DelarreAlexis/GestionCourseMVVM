using GestionCourseMVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GestionCourseMVVM.ViewModels
{
	public class ListeCoursesViewModel : BindableObject
	{
		private List<Course> _courses;
		public List<Course> Courses { get => _courses; set { _courses = value; OnPropertyChanged(); } }
		public ListeCoursesViewModel()
		{
			if (Courses == null)
				Courses = new List<Course>();
			InitilisationListeCourse();
		}

		private  void InitilisationListeCourse()
		{
			Courses.Add(new Course { Nom = "Marathon de Paris", Lieu = "Paris", Distance = 42.195f });
			Courses.Add(new Course { Nom = "Marathon de Montpellier", Lieu = "Montpellier", Distance = 42.195f });
			Courses.Add(new Course { Nom = "Semi-Marathon de Phalempin", Lieu = "Phalempin", Distance = 21.1f });
		}
	}
}
