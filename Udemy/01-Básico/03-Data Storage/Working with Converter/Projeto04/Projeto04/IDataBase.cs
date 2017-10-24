using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace Projeto04
{
    public interface IDatabase
    {
        SQLiteConnection GetConnection();
    }
}
