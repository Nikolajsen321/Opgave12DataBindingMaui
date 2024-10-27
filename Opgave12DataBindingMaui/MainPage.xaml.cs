namespace Opgave12DataBindingMaui
{
	public partial class MainPage : ContentPage
	{
		Bil bil;

		public MainPage()
		{
			InitializeComponent();

			 bil =  new Bil
			{
				Model = "Tesla model L",
				Heste = 450,
				Elbil = true
			};

			BindingContext = bil;
		}

		private void OnChangedPropertiesClicked(object sender, EventArgs e)
		{
			bil.Model = "Volvo X40";
			bil.Heste = 2000;
			bil.Elbil = !bil.Elbil;
			
		}

	}

}
