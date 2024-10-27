using Opgave12DataBindingMaui;
using System.Collections.ObjectModel;

namespace Opgave12._4
{
	public partial class MainPage : ContentPage
	{
		ObservableCollection<Bil1> Biler {  get; set; }

		public MainPage()
		{
			InitializeComponent();
			Biler = new ObservableCollection<Bil1>()
			{
				new Bil1 { Model = "Ford Ka", Heste = 50, Elbil = false },
				new Bil1 { Model = "Tesla Model S", Heste = 800, Elbil = true },


			};

			//BindingContext = Biler;
			BilCollectionView.ItemsSource = Biler;
		}

		private void OnTilfoejBilClicked(object sender, EventArgs e)
		{
			Biler.Add(new Bil1 { Model = "Volvo XC90", Heste = 50, Elbil = false });
		}

		private void OnRetBilClickked(object sender, EventArgs e)
		{
			if (Biler.Count > 0)
			{
				Biler[0].Model = "Tesla Model X";
				Biler[0].Heste = 700;
				Biler[0].Elbil = true;
			}
		}

		


	}

}
