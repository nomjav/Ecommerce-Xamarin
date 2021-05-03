using Ecommerce.ViewModels;
using Ecommerce.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Ecommerce
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ProductDetailPage), typeof(ProductDetailPage));
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
		}

	}
}
