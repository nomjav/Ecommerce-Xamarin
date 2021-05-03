using Ecommerce.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ecommerce.SharedViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CollectionItems : ContentView
	{

		ItemsViewModel _viewModel;
		public CollectionView itemLayout
		{
			get
			{
				return ItemsListView;
			}
		}
		public CollectionItems()
		{
			InitializeComponent();
			BindingContext = _viewModel = new ItemsViewModel();
			_viewModel.LoadItemsCommand.Execute(null);
			
		}

	}
}