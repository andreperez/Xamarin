using System;
using System.Collections.Generic;
using System.Linq;
using People.Models;
using SQLite;
using System.Threading.Tasks;

namespace People
{
	public sealed class PersonRepository
	{
		private static PersonRepository instance;
		public static PersonRepository Instance
		{
			get
			{
				if (instance == null)
					throw new Exception("You must call Initialize before retrieving the singleton for the PersonRepository.");

				return instance;
			}
		}

		public static void Initialize(string filename)
		{
			if (filename == null)
				throw new ArgumentNullException(nameof(filename));

			// TODO: dispose any existing connection
			if (instance != null)
				instance.conn.GetConnection().Dispose();

			instance = new PersonRepository(filename);
		}

		public string StatusMessage { get; set; }

		private SQLiteAsyncConnection conn;
		private PersonRepository(string dbPath)
		{
			// TODO: Initialize a new SQLiteConnection
			conn = new SQLiteAsyncConnection(dbPath);
			// TODO: Create the Person table
			conn.CreateTableAsync<Person>().Wait();
		}

		public async Task AddNewPersonAsync(string name)
		{
			int result = 0;
			try
			{
				//basic validation to ensure a name was entered
				if (string.IsNullOrEmpty(name))
					throw new Exception("Valid name required");

				// TODO: insert a new person into the Person table
				result = await conn.InsertAsync(new Person { Name = name });

				StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
			}
			catch (Exception ex)
			{
				StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
			}
		}

		public async Task<IEnumerable<Person>> GetAllPeopleAsync()
		{
			try
			{
				// TODO: return the Person table in the database
				return await conn.Table<Person>().ToListAsync();
			}
			catch (Exception ex)
			{
				StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
			}

			return Enumerable.Empty<Person>();
		}
	}
}