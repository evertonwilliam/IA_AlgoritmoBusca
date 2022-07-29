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
    internal class CAdjacente
    {
        readonly ConnDBASqlite conn;

        public CAdjacente()
        {
            conn = new ConnDBASqlite();
        }

        public void AddAdjacente(Adjacente adjacente)
        {
            try
            {
                using (var cmd = conn.GetConnSQLite().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Adjacente ('IdCidadeOrigem', 'IdCidadeDestino', 'DistRodEntreCidades') " +
                                      "VALUES (@IdOrigem, @IDestino, @DistanciaEntreCidades)";
                    cmd.Parameters.AddWithValue("@IdCidadeOrigem", adjacente.IdCidadeOrigem);
                    cmd.Parameters.AddWithValue("@IdCidadeDestino", adjacente.IdCidadeDestino);
                    cmd.Parameters.AddWithValue("@DistRodEntreCidades", adjacente.DistRodEntreCidades);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAllAdjacentes()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conn.GetConnSQLite().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Adjacente";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, conn.GetConnSQLite());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAdjacenteCidade(int IdCidadeOrigem)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conn.GetConnSQLite().CreateCommand())
                {
                    cmd.CommandText = "SELECT CO.NomeCidade ORIGEM, CD.NomeCidade DESTINO, AD.DistRodEntreCidades DISTANCIA " +
                                      "FROM Adjacente AD " +
                                      "INNER JOIN Cidade CO ON CO.IdCidade = AD.IdCidadeOrigem " +
                                      "INNER JOIN Cidade CD ON CD.IdCidade = AD.IdCidadeDestino " +
                                      "WHERE " +
                                      "AD.IdCidadeOrigem = " + IdCidadeOrigem;

                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, conn.GetConnSQLite());
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
