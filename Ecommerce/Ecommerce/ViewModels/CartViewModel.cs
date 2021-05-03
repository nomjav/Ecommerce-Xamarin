using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ecommerce.ViewModels
{
	public class CartViewModel : BaseViewModel
	{
		public ObservableCollection<CartItem> Items { get; }
		public ICommand LoadCartItemsCommand { get; }
		public string GrandTotal { get; set; }
		public CartViewModel()
		{
			Items = new ObservableCollection<CartItem>();
			LoadCartItemsCommand = new Command(() => ExecuteLoadCartItemsCommand());
		}

		void ExecuteLoadCartItemsCommand()
		{
			List<CartItem> CartItems = new List<CartItem> {
				new CartItem { Name = "Shirt", Image = "MensWearCollectionLogo.png", Quantity="2", UnitPrice="20", Total="40", Description="" },
				new CartItem { Name = "Tie", Image = "MensWearCollectionLogo.jpg", Quantity="1", UnitPrice="10", Total="10", Description="" },
				new CartItem { Name = "Pants", Image = "MensWearCollectionLogo.jpg", Quantity="2", UnitPrice="50", Total="100", Description="" }
			};
			var cart = new Cart();
			cart.CartItems = new List<CartItem>();
			cart.CartItems = CartItems;
			GrandTotal = cart.GrandTotal = "150";
			Items.Clear();
			foreach (var item in cart.CartItems)
			{
				Items.Add(item);
			}
		}
	}
}
