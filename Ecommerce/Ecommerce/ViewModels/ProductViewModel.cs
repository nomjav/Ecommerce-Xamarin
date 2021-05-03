using System;
using System.Collections.Generic;
using System.Web;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ecommerce.ViewModels
{
	public class ProductViewModel : BaseViewModel, IQueryAttributable
	{
		public ICommand BackCommand { get; }
		public ICommand ShareCommand { get; }
		public string Id { get; set; }
		public void ApplyQueryAttributes(IDictionary<string, string> query)
		{
			Id = HttpUtility.UrlDecode(query["CategoryId"]);
		}
		public ProductViewModel()
		{
			BackCommand = new Command(OnBackPress);
		}

		public async void OnBackPress()
		{
			try
			{
				await Shell.Current.GoToAsync($"..?CategoryId={Id}&isBackPressed=true");
			}
			catch(Exception ex)
			{

			}
		}
	}
}
