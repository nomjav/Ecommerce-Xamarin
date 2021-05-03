using Ecommerce.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
	public class ProductService : IDataStore<Item>
	{
		string url = "https://private-9591c-ecommerce87.apiary-mock.com/products";
		HttpClient client;
		List<Item> products;
		public ProductService()
		{
			client = new HttpClient();
			products = new List<Item>();
		}

		public Task<bool> AddItemAsync(Item item)
		{
			throw new NotImplementedException();
		}

		public Task<bool> DeleteItemAsync(string id)
		{
			throw new NotImplementedException();
		}

		public async Task<IList<Item>> GetProductsAsync(string id)
		{
			Uri uri = new Uri(string.Format(url, string.Empty));
			HttpResponseMessage response = await client.GetAsync(uri);
			if (response.IsSuccessStatusCode)
			{
				string content = await response.Content.ReadAsStringAsync();
				products = JsonConvert.DeserializeObject<List<Item>>(content);
				if(id != "0")
					products = products.Where(x => x.CategoryId == id).ToList();
			}
			return products;
		}

		public Task<IList<Item>> GetItemsAsync(bool forceRefresh = false)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateItemAsync(Item item)
		{
			throw new NotImplementedException();
		}
	}
}