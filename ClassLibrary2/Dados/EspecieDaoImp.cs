using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;
using Backend.Util;
using Backend.Erro;


namespace Backend.Dados
{
    public class EspecieDaoImp
    {

        public Conexao conn;

        public EspecieDaoImp()
        {

            this.conn = new Conexao();
        }




        public Especie getEspecie(int especieId)
        {


            try
            {
                this.conn.openConnection();
                Especie especie = new Especie();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT id,nome FROM especie WHERE id = @especie";
                cmd.Connection = this.conn.SqlConn;
                cmd.Parameters.AddWithValue("@especie", especieId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    especie.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    especie.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    especie.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
                    especie.DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro"));



                }
                this.conn.closeConnection();

                return especie;
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Especies :" + ce.Message);
            }





        }





    }



    }
}
