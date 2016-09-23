using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SIT313GroupProject2
{
	public partial class MyAdvisePage : ContentPage
	{
		public MyAdvisePage()
		{
			InitializeComponent();
		}

		async void NavigateToHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new SIT313GroupProject2Page());
		}

		async void NavigateToMyAdvise(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new AdviseList());
		}
	}
}
