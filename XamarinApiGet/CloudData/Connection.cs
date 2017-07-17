using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XamarinApiGet
{
	public class Connection
	{

private HttpClient client;
private List<User> users;
				public Connection()
				{
					client = new HttpClient();
					users = new List<User>();

				}



			async public Task<List<User>> userAll(string connUrl)
			{

				
				client.BaseAddress = new Uri(connUrl);
				var response = await client.GetAsync("api/values");

				var jsondata = response.Content.ReadAsStringAsync().Result;

				var root = JsonConvert.DeserializeObject<List<User>>(jsondata);
				return root;


					}
	}
}
