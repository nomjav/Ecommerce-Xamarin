using Ecommerce.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ecommerce.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductDetailPage : ContentPage
	{
		ProductViewModel _viewModel;
		public ProductDetailPage()
		{
			InitializeComponent();
			BindingContext = _viewModel = new ProductViewModel();
		}

		protected override bool OnBackButtonPressed()
		{
			_viewModel.OnBackPress();
			return true;
		}
	}
}