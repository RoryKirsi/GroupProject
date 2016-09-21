using System;
using System.ComponentModel;

namespace SIT313GroupProject2
{
	public class SessionDetailViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		Session _CurrentSession;

		public Session CurrentSession
		{
			get { return _CurrentSession; }
			set
			{
				_CurrentSession = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(
								this,
								new PropertyChangedEventArgs("CurrentSession"));
				}
			}
		}

		public string SessionTitle
		{
			get { return _CurrentSession.SessionTitle; }
			set
			{
				_CurrentSession.SessionTitle = value;
				if (PropertyChanged != null)
				{

					PropertyChanged(this, new PropertyChangedEventArgs("SessionTitle"));
				}
			}
		}

		public string SessionDescription
		{
			get { return _CurrentSession.SessionDescription; }
			set
			{
				_CurrentSession.SessionDescription = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(
								this,
								new PropertyChangedEventArgs("SessionDescription"));
				}
			}
		}

		public string SessionType
		{
			get { return _CurrentSession.SessionType; }
			set
			{
				_CurrentSession.SessionType = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(
								this,
								new PropertyChangedEventArgs("SessionSize"));
				}
			}
		}

		public string SessionPicture
		{
			get { return _CurrentSession.SessionPicture; }
			set
			{
				_CurrentSession.SessionPicture = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(
								this,
								new PropertyChangedEventArgs("SessionPicture"));
				}
			}
		}

		public string SessionLocation
		{
			get { return _CurrentSession.SessionLocation; }
			set
			{
				_CurrentSession.SessionLocation = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(
								this,
								new PropertyChangedEventArgs("SessionLocation"));
				}
			}
		}

		public string SessionStrategy
		{
			get { return _CurrentSession.SessionStrategy; }
			set
			{
				_CurrentSession.SessionStrategy = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(
								this,
								new PropertyChangedEventArgs("SessionStrategy"));
				}
			}
		}


		public SessionDetailViewModel()
		{
			CurrentSession = new Session
			{
				SessionDescription = "My Description",
				SessionTitle = "This is my default title for the session",
				SessionType = "Type",
				SessionStrategy = "There is the Strategy",
				SessionPicture = "Noting",
				SessionLocation = "Nothing"
			};
		}
	}
}
