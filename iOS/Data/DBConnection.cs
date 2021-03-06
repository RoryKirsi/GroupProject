﻿using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using SIT313GroupProject2.iOS;

[assembly: Dependency(typeof(DBConnection))]
namespace SIT313GroupProject2.iOS
{
	public class DBConnection : IDBConnection
	{

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
