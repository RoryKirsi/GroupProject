using System;
using System.ComponentModel;
using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;

namespace SIT313GroupProject2
{
	public class ConnectivityViewModel
	{
		string _connectionStatus = "";

		public event PropertyChangedEventHandler PropertyChanged;

		public string ConnectionStatus
		{
			get { return _connectionStatus; }
			set
			{
				_connectionStatus = value;
				if (PropertyChanged != null)
					PropertyChanged(this, new PropertyChangedEventArgs("ConnectionStatus"

																	  ));
			}
		}

		public ConnectivityViewModel()
		{

			UpdateConnectionStatus();
			CrossConnectivity.Current.ConnectivityChanged +=
				(sender, e) =>
				{
					this.UpdateConnectionStatus();

				};
		}

		void UpdateConnectionStatus()
		{
			if (CrossConnectivity.Current != null &&
				   CrossConnectivity.Current.IsConnected == true)
			{
				var str = "";
				foreach (ConnectionType type in CrossConnectivity.Current.ConnectionTypes)
					str += type.ToString() + " ";
				ConnectionStatus = string.Format("Connected to {0}",
												 str);
			}
			else
			{
				ConnectionStatus = "Not Connected!";
			}
		}
	}
}
