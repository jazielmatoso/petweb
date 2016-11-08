using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Util;
using Backend.Basicas;
using Backend.Erro;

namespace Backend.Dados
{
    class EspecieDaoImp : EspecieDao
    {
        Conexao conn;


        public EspecieDaoImp()
        {
            this.conn = new Conexao();
        }


        public void inserirEspecie(Especie especie)
        {
            try
            {

                this.conn.openConnection();
                string sql = "INSERT INTO especie (nome,descricao) VALUES (@nome,@descricao)";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;


                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Espécie :" + ce.Message);
            }


        }



        public void alterarEspecie(Especie especie)
        {
            try
            {

                this.conn.openConnection();
                string sql = "UPDATE especie SET nome = @nome,descricao = @descricao WHERE codEspecie = @id_especie";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id_especie", txtId.Text);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Alterar Espécie :" + ce.Message);
            }


        }


        public void deletarEspecie(Especie especie)
        {
            try
            {

                this.conn.openConnection();
                string sql = "DELETE FROM especie WHERE codEspecie = @especie_id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@especie_id", txtId.Text);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Alterar Especie :" + ce.Message);
            }


        }


        public List<Usuario> listarEspecie()
        {

            Listar<Especie> lEspecie = new List<Especie>();

            try
            {
                this.conn.openConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select especie_id,nome,descricao from especie";
                cmd.Connection = this.conn.SqlConn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Especie especie = new Especie();
                    especie.CodEspecie = reader.GetInt32(reader.GetOrdinal("especie_id"));
                    especie.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    especie.descricao = reader.GetString(reader.GetOrdinal("descricao"));

                    lEspecie.Add(especie);
                }
                this.conn.closeConnection();
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Espécies :" + ce.Message);
            }

            return lEspecie;



        }
    }
}
