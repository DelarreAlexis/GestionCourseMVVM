using GestionCourseMVVM.Models;
using GestionCourseMVVM.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestionCourseMVVM
{
	public partial class App : Application
	{
		public static List<Coureur> Coureurs { get; set; }
		public static List<Course> Courses { get; set; }

		public App()
		{
			InitializeComponent();
			if (Coureurs == null)
				Coureurs = new List<Coureur>();
			if (Courses == null)
				Courses = new List<Course>();
			InitialiseListeCourse();
			MainPage = new ListeCourses();
		}
		private void InitialiseListeCourse()
		{
			if (Courses == null)
				Courses = new List<Course>();
			Courses.Add(new Course { Nom = "Marathon de Paris", Lieu = "Paris", Distance = 42.195f });
			Courses.Add(new Course { Nom = "Marathon de Montpellier", Lieu = "Montpellier", Distance = 42.195f });
			Courses.Add(new Course { Nom = "Semi-Marathon de Phalempin", Lieu = "Phalempin", Distance = 21.1f });
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
