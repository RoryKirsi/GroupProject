using System;
using SQLite;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace SIT313GroupProject2
{
	public class AdviseDataAccessService
	{
		SQLiteAsyncConnection DBConnection;

		public AdviseDataAccessService()
		{
			DBConnection = DependencyService.Get<IDBConnection>().GetSQLiteAsyncConnection();

			DBConnection.CreateTableAsync<AdviseField>();

		}

		public async Task<List<AdviseField>> GetAllSessionsAsync()
		{
			return await DBConnection.Table<AdviseField>().ToListAsync();
		}

		public async Task AddSessionAsync(AdviseField newAdvise)
		{
			await DBConnection.InsertAsync(newAdvise);
		}

	}
}
