using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SIT313GroupProject2
{
	public partial class AdviseList : ContentPage
	{
		void AdviseList_OnBindingContextChanged()
		{

			this.myList.BeginRefresh();
		}

		public AdviseList()
		{
			InitializeComponent();
			BindingContextChanged += (sender, e) =>
			{

				AdviseList_OnBindingContextChanged();

			};
		}

		public void OnAdviseSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
			{ return; }
			else
			{
				var adviseVM = new AdviseDetailViewModel();
				adviseVM.CurrentAdvise = (AdviseField)e.SelectedItem;

				var adviseDetailsPage = new MyAdvisePage();
				adviseDetailsPage.BindingContext = adviseVM;
				Navigation.PushModalAsync(adviseDetailsPage);


			}
		}
	}
}
