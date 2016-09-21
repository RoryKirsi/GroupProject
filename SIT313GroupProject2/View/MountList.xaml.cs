using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SIT313GroupProject2
{
	public partial class MountList : ContentPage
	{
		void MountList_OnBindingContextChanged()
		{

			this.myList.BeginRefresh();
		}

		public MountList()
		{
			InitializeComponent();
			BindingContextChanged += (sender, e) =>
			{

				MountList_OnBindingContextChanged();

			};
		}

		public void OnSessionSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
			{ return; }
			else
			{
				var sessionVM = new SessionDetailViewModel();
				sessionVM.CurrentSession = (Session)e.SelectedItem;

				var sessionDetailsPage = new MountPage();
				sessionDetailsPage.BindingContext = sessionVM;
				Navigation.PushModalAsync(sessionDetailsPage);


			}
		}
	}
}
