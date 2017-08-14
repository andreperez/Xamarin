using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto04.UWP;
using SQLite;
using System.IO;
using Windows.Storage;

[assembly: Xamarin.Forms.Dependency(typeof(Database_UWP))]
namespace Projeto04.UWP
{
    public class Database_UWP : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var nomeDB = "projeto04.db3";

            var caminhoDB = Path.Combine(ApplicationData.Current.LocalFolder.Path, nomeDB);

            return new SQLiteConnection(caminhoDB);
        }
    }
}
