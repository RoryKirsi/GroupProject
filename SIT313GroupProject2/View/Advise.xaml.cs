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

		async void NavigateToMyAdvise(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new AdviseList());
		}

		async void Submit(object sender, EventArgs args)
		{
			AdviseDataAccessService a = new AdviseDataAccessService();
			AdviseField temp = new AdviseField { Title = Convert.ToString(title.Text), Name = Convert.ToString(name.Text), Email = Convert.ToString(email.Text), 
				Phone = Convert.ToString(phone.Text), Score = Convert.ToString(Math.Floor(score.Value)), Advise = Convert.ToString(advise.Text), Date = DateTime.Now};
			await a.AddSessionAsync(temp);
		}
	}
}
