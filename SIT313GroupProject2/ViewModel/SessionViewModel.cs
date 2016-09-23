using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SIT313GroupProject2
{
	public class SessionViewModel : INotifyPropertyChanged
	{
		SessionsManager sessionsManager = new SessionsManager();


		public event PropertyChangedEventHandler PropertyChanged;

		bool _dataLoaded;

		public bool DataLoaded
		{
			get { return _dataLoaded; }
			set
			{
				_dataLoaded = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(this,
									new PropertyChangedEventArgs("DataLoaded"));
				}

			}
		}
		ObservableCollection<Session> _SessionsList;
		public ObservableCollection<Session> SessionsList
		{

			get { return _SessionsList; }
			set
			{
				_SessionsList = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(this,
									new PropertyChangedEventArgs("SessionsList"));
					DataLoaded = false;
				}
			}
		}

		public SessionViewModel()
		{
			DataLoaded = true;
			FetchDataAsync();

		}

		/*
		public async Task FetchDataAsync()
		{
			//var list = await sessionsManager.FetchSessionsAsync();
			var list = await (new SessionsDataAccessService()).GetAllSessionsAsync();
			SessionsList = new ObservableCollection<Session>(list);

		}*/


		public async Task FetchDataAsync()
		{
			var AppCache = new AppCache();
			AppCache.SessionsCacheChanged +=
				(sender, e) => { SessionsList = new ObservableCollection<Session>((List<Session>)sender); };
			await AppCache.GetAllSessionsAsync();
		}

		/*
		public async Task FetchDataAsync()
		{
			var list = await sessionsManager.FetchSessionsAsync();
			SessionsList = new ObservableCollection<Session>(list);

		}*/
	}
}
