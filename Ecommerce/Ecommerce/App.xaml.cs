using Ecommerce.Services;
using Ecommerce.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ecommerce
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();

			DependencyService.Register<ProductService>();
			DependencyService.Register<CategoriesService>();
			MainPage = new AppShell();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
