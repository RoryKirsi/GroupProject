using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SIT313GroupProject2
{
	public partial class MountPage : ContentPage
	{
		public MountPage()
		{
			InitializeComponent();
		}

		async void NavigateToFeedback(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Advise());
		}

		async void NavigateToList(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new SIT313GroupProject2Page());
		}

		async void NavigateToHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new SIT313GroupProject2Page());
		}
	}
}
