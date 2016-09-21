using System;
using SQLite;

namespace SIT313GroupProject2
{
	public interface IDBConnection
	{
		SQLiteAsyncConnection GetSQLiteAsyncConnection();

	}
}
