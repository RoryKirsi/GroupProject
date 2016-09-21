using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SIT313GroupProject2
{
	public partial class Advise : ContentPage
	{
		public Advise()
		{
			InitializeComponent();
		}

		async void NavigateToHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new SIT313GroupProject2Page());
		}
	}
}
