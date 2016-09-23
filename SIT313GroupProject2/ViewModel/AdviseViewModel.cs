using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SIT313GroupProject2
{
	public class AdviseViewModel : INotifyPropertyChanged
	{

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
		ObservableCollection<AdviseField> _AdviseList;
		public ObservableCollection<AdviseField> AdviseList
		{

			get { return _AdviseList; }
			set
			{
				_AdviseList = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(this,
									new PropertyChangedEventArgs("AdviseList"));
					DataLoaded = false;
				}
			}
		}

		public AdviseViewModel()
		{
			DataLoaded = true;
			FetchDataAsync();
		}

		public async Task FetchDataAsync()
		{
			var list = await (new AdviseDataAccessService()).GetAllSessionsAsync();
			AdviseList = new ObservableCollection<AdviseField>(list);

		}
	}
}

