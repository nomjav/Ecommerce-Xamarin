using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Models
{
	public class CategoryModel
	{
		[JsonProperty("Id")]
		public string Id { get; set; }
		[JsonProperty("Name")]
		public string Name { get; set; }
		[JsonProperty("Description")]
		public string Description { get; set; }
		[JsonProperty("Sale")]
		public string Sale { get; set; }
	}
}
