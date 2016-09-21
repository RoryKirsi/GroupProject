using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SIT313GroupProject2
{
	public class SessionsManager
	{
		HttpClient client = new HttpClient();

		List<Session> list = null;
		//This is an async method to avoid blocking, if we expect big data 
		public async Task<List<Session>> FetchSessionsAsync()
		{
			//URI of my Web API
			string uri = "http://192.168.1.8:8080/api/ConferenceSessions";

			//Call it
			var response = await client.GetAsync(uri);


			//If the request succeeded, response code is 200, then get the data
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();

				//now, we should deserialise (convert from JSON to real objects)
				list = JsonConvert.DeserializeObject<List<Session>>(content);

			}
			return list;

		}
	}
}
