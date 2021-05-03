using Ecommerce.Models;
using Ecommerce.Services;
using Ecommerce.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Web;
using Xamarin.Forms;

namespace Ecommerce.ViewModels
{

	public class ItemDetailViewModel : BaseViewModel, IQueryAttributable
	{
		public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();
		public ObservableCollection<Item> Items { get; }
		public Command LoadProductsCommand { get; }
		public Command ItemTapped { get; }
		public string Id { get; set; }
		public string BackPressed { get; set; }
		public void ApplyQueryAttributes(IDictionary<string, string> query)
		{
			Id = HttpUtility.UrlDecode(query["CategoryId"]);
			BackPressed = HttpUtility.UrlDecode(query["isBackPressed"]);   
		}

		public ItemDetailViewModel()
		{
			Title = "Browse";
			Items = new ObservableCollection<Item>();
			LoadProductsCommand = new Command(async () => await ExecuteLoadProductsCommand(Id));
			ItemTapped = new Command(OnItemSelected);
		}

		public async Task ExecuteLoadProductsCommand(string category)
		{
			IsBusy = true;
			try
			{
				Items.Clear();
				var item = await DataStore.GetProductsAsync(category);
				foreach (var product in item)
				{
					Items.Add(product);
				}
			}
			catch (Exception)
			{
				Debug.WriteLine("Failed to Load Item");
			}
			finally
			{
				IsBusy = false;
			}
		}

		public void OnAppearing()
		{
			if (BackPressed == "true")
				IsBusy = false;
			else
				IsBusy = true;
			//SelectedItem = null;
		}

		async void OnItemSelected()
		{
			await Shell.Current.GoToAsync($"{nameof(ProductDetailPage)}?CategoryId={Id}");
		}
	}
}
