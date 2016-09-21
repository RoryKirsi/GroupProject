using Xamarin.Forms;
using System;

namespace SIT313GroupProject2
{
	public partial class SIT313GroupProject2Page : ContentPage
	{
		public SIT313GroupProject2Page()
		{
			InitializeComponent();
		}

		async void NavigateToList(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new MountList());
		}

		async void NavigateToFeedback(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Advise());
		}
	}
}
