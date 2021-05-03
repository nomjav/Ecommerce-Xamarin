using System;

namespace Ecommerce.Models
{
	public class Item
	{
		public string CategoryId { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public string Description { get; set; }
		public string Price { get; set; }
		public string Sale { get; set; }
		public string Rating { get; set; }
	}
}