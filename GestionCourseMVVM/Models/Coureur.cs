using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GestionCourseMVVM.Models
{
	public class Coureur : BindableObject
	{
		private int _num;
		private string _nom;
		private string _prenom;
		private int _age;
		private int _sexe;

		public int Num { get => _num; set { _num = value; } }
		public string Nom { get => _nom; set { _nom = value; OnPropertyChanged(); } }
		public string Prenom { get => _prenom; set { _prenom = value; OnPropertyChanged(); } }
		public int Age { get => _age; set { _age = value; OnPropertyChanged(); } }
		public int Sexe { get => _sexe; set { _sexe = value; OnPropertyChanged(); } }
	}
}
