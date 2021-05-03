using Ecommerce.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
	public class CategoriesService : IDataStore<CategoryModel>
	{
		string url = "https://private-9591c-ecommerce87.apiary-mock.com/categories";
		HttpClient client;
		List<CategoryModel> categories;
		public CategoriesService()
		{
			client = new HttpClient();
			categories = new List<CategoryModel>();
		}
		public Task<bool> AddItemAsync(CategoryModel item)
		{
			throw new NotImplementedException();
		}

		public Task<bool> DeleteItemAsync(string id)
		{
			throw new NotImplementedException();
		}


		public async Task<IList<CategoryModel>> GetItemsAsync(bool forceRefresh = false)
		{
			Uri uri = new Uri(string.Format(url, string.Empty));
			HttpResponseMessage response = await client.GetAsync(uri);
			if (response.IsSuccessStatusCode)
			{
				string content = await response.Content.ReadAsStringAsync();
				categories = JsonConvert.DeserializeObject<List<CategoryModel>>(content);
			}
			return categories;
		}

		public Task<IList<CategoryModel>> GetProductsAsync(string name)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateItemAsync(CategoryModel item)
		{
			throw new NotImplementedException();
		}
	}
}
