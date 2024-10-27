using System.ComponentModel;

namespace Opgave12DataBindingMaui
{
	internal class Bil : INotifyPropertyChanged
	{
		private string _model;
		public string Model
		{
			get { return _model; }
			set
			{
				if (_model != value)
				{
					_model = value;
					OnPropertyChanged(nameof(Model));
				}
			}
		}

		private int _heste;
		public int Heste
		{
			get { return _heste; }
			set
			{
				if (_heste != value)
				{
					_heste = value;
					OnPropertyChanged(nameof(Heste));
				}
			}
		}

		private bool _elbil;
		public bool Elbil
		{
			get { return _elbil; }
			set
			{
				if (_elbil != value)
				{
					_elbil = value;
					OnPropertyChanged(nameof(Elbil));
				}
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
