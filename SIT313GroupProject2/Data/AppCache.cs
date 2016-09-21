using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Akavache;
namespace SIT313GroupProject2
{
	public class AppCache
	{
		IBlobCache Cache = null;

		public AppCache()
		{
			Cache = BlobCache.LocalMachine;
		}

		public event PropertyChangedEventHandler SessionsCacheChanged;

		public async Task GetAllSessionsAsync()
		{
			var cachedSessions = Cache.GetOrFetchObject<List<Session>>(
							"AllSessions",
				async () => await (new SessionsManager()).FetchSessionsAsync(), DateTimeOffset.Now.AddSeconds(3)
			).Subscribe((List<Session> obj) =>

						SessionsCacheChanged(obj,
								  new PropertyChangedEventArgs("SessionsCache"))
					   );
		}
	}
}
