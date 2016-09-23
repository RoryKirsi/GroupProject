using System;
using System.ComponentModel;
namespace SIT313GroupProject2
{
	public class AdviseDetailViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		AdviseField _CurrentAdvise;

		public AdviseField CurrentAdvise
		{
			get { return _CurrentAdvise; }
			set
			{
				_CurrentAdvise = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(
								this,
								new PropertyChangedEventArgs("CurrentAdvise"));
				}
			}
		}

		public string Title
		{
			get { return _CurrentAdvise.Title; }
			set
			{
				_CurrentAdvise.Title = value;
				if (PropertyChanged != null)
				{

					PropertyChanged(this, new PropertyChangedEventArgs("Title"));
				}
			}
		}

		public string Name
		{
			get { return _CurrentAdvise.Name; }
			set
			{
				_CurrentAdvise.Name = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(
								this,
								new PropertyChangedEventArgs("Name"));
				}
			}
		}

		public string Email
		{
			get { return _CurrentAdvise.Email; }
			set
			{
				_CurrentAdvise.Email = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(
								this,
								new PropertyChangedEventArgs("Email"));
				}
			}
		}

		public string Phone
		{
			get { return _CurrentAdvise.Phone; }
			set
			{
				_CurrentAdvise.Phone = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(
								this,
								new PropertyChangedEventArgs("Phone"));
				}
			}
		}

		public string Score
		{
			get { return _CurrentAdvise.Score; }
			set
			{
				_CurrentAdvise.Score = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(
								this,
								new PropertyChangedEventArgs("Score"));
				}
			}
		}

		public string Advise
		{
			get { return _CurrentAdvise.Advise; }
			set
			{
				_CurrentAdvise.Advise = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(
								this,
								new PropertyChangedEventArgs("Advise"));
				}
			}
		}


		public AdviseDetailViewModel()
		{
			CurrentAdvise = new AdviseField
			{
				Title = "Title",
				Name = "Name",
				Email = "Email",
				Phone = "Phone",
				Score = "Score",
				Advise = "Advise"
			};
		}
	}
}
