using Akavache;
using Xamarin.Forms;

namespace SIT313GroupProject2
{
	public partial class App : Application
	{
		SIT313GroupProject2Page home = new SIT313GroupProject2Page();
		public App()
		{
			InitializeComponent();
			BlobCache.ApplicationName = "SIT313GroupProject2";
			MainPage = home;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
