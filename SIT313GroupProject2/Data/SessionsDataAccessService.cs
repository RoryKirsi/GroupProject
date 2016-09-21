using System;
using SQLite;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace SIT313GroupProject2
{
	public class SessionsDataAccessService
	{
		SQLiteAsyncConnection DBConnection;

		public SessionsDataAccessService()
		{
			DBConnection = DependencyService.Get<IDBConnection>().GetSQLiteAsyncConnection();

			DBConnection.CreateTableAsync<Session>();

		}

		public async Task<List<Session>> GetAllSessionsAsync()
		{
			return await DBConnection.Table<Session>().ToListAsync();
		}

		public async Task AddSessionAsync(Session newSession)
		{
			await DBConnection.InsertAsync(newSession);
		}
	}
}
