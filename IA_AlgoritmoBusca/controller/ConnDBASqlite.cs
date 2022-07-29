using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_AlgoritmoBusca.controller
{
    internal class ConnDBASqlite
    {
        private SQLiteConnection conn;

        public ConnDBASqlite()
        {
            GetConnSQLite();
            CreateTables();
        }

        public SQLiteConnection GetConnSQLite()
        {
            conn = new SQLiteConnection("Data Source=db.db; Version=3;");
            conn.Open();
            return conn;
        }

        private void CreateTables()
        {
            try
            {
                String sql = System.IO.File.ReadAllText(@"data\CreateData.sql");
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                String sql = System.IO.File.ReadAllText(@"data\DropData.sql");
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    CreateTables();
                }
            }
        }
    }
}
