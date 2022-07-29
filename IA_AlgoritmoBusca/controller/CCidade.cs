using IA_AlgoritmoBusca.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_AlgoritmoBusca.controller
{
    internal class CCidade
    {
        readonly ConnDBASqlite conn;
 
        public CCidade()
        {
            conn = new ConnDBASqlite();
        }

        public void AddCidade(Cidade cidade)
        {
            try
            {
                using (var cmd = conn.GetConnSQLite().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO CIDADE ('NomeCidade') VALUES (@nomeCidade);";
                    cmd.Parameters.AddWithValue("@nomeCidade", cidade.NomeCidade);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAllCidades()
        {
            try
            {
                SQLiteDataAdapter da = null;
                DataTable dt = new DataTable();

                using (var cmd = conn.GetConnSQLite().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM cidade";
                    da = new SQLiteDataAdapter(cmd.CommandText, conn.GetConnSQLite());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
