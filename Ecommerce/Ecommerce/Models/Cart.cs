using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Models
{
	public class CartItem
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Total { get; set; }
		public string UnitPrice { get; set; }
		public string Quantity { get; set; }
		public string Image { get; set; }
	}

	public class Cart
	{
		public List<CartItem> CartItems { get; set; }
		public string GrandTotal { get; set; }
	}
}
