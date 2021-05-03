using Ecommerce.Models;
using Ecommerce.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ecommerce.ViewModels
{
	public class MainViewModel : BaseViewModel
	{
		public List<Slides> slides { get; }
		public ICommand ShopCommand { get; }
		public ICommand ItemTapped { get; }
		public MainViewModel()
		{
			slides = new List<Slides>()
			{
				new Slides { Title = "Men's Wear", Image = "banner.jpg", Description="40 - 50 % Off" },
				new Slides { Title = "Women's Wear", Image = "womenBanner.jpg", Description="10 - 20 % Off" },
				new Slides { Title = "Kid's Wear", Image = "kidBanner.jpg", Description="50 % Off" }
			};

			ShopCommand = new Command<string>(ExecuteShopCommand);
			ItemTapped = new Command<string>(ViewAllCollections);
		}

		private async void ViewAllCollections(string Title)
		{
			IsBusy = true;
			try
			{
				await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?CategoryId=0&isBackPressed=false");
			}
			catch (Exception ex)
			{

			}
			finally
			{
				IsBusy = false;
			}
		}

		private async void ExecuteShopCommand(string Title)
		{
			IsBusy = true;
			try
			{
				if (Title.Contains("Men's"))
				{
					await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?CategoryId=1&isBackPressed=false");
				}
				else if (Title.Contains("Women's"))
				{
					await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?CategoryId=2&isBackPressed=false");
				}
				else
				{
					await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?CategoryId=3&isBackPressed=false");
				}
			}
			catch(Exception ex)
			{

			}
			finally
			{
				IsBusy = false;
			}
		}
	}
}
