using System;
using SQLite;
using Xamarin.Forms;
using SIT313GroupProject2.Droid;
using System.IO;

[assembly: Dependency(typeof(DBConnection))]
namespace SIT313GroupProject2.Droid
{
	public class DBConnection : IDBConnection
	{
		public DBConnection()
		{
		}

		SQLiteAsyncConnection IDBConnection.GetSQLiteAsyncConnection()
		{
			var personalFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var lirbraryFolder = Path.Combine(personalFolder, "..", "Library");
			var dbPath = Path.Combine(lirbraryFolder, CONSTANTS.DATABASEPATH);
			var connection = new SQLiteAsyncConnection(dbPath);

			return connection;
		}
	}
}
