using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Util;
using Backend.Basicas;
using Backend.Erro;

namespace Backend.Dados
{
    public class VacinaDaoImp : VacinaDao
    {
        Conexao conn;

        public VacinaDaoImp()
        {
            this.conn = new Conexao();
        }


        public void inserirVacina(Vacina vacina)
        {
            try
            {

                this.conn.openConnection();
                string sql = "INSERT INTO vacina (nome,descricao,data_cadastro) VALUES (@nome,@descricao,@data_cadastro)";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                //cmd.Parameters.AddWithValue("@nome,@descricao,@data_cadastro", vacina.Nome, vacina.Descricao);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException e)
            {

                throw new DaoException("Erro ao Inserir a vacina :" + e.Message);
            }
            
                
        }



        public void alterarVacina(Vacina vacina)
        {
            try
            {

                this.conn.openConnection();
                string sql = "UPDATE vacina SET nome = @nome,descricao = @descricao,data_cadastro = @data_cadastro WHERE id = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@nome", vacina.Nome);
                cmd.Parameters.AddWithValue("@id", vacina.CodVacina);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException e)
            {

                throw new DaoException("Erro ao Alterar a vacina :" + e.Message);
            }


        }


        public void deletarUsuario(Usuario usuario)
        {
            try
            {

                this.conn.openConnection();
                string sql = "DELETE FROM usuario WHERE id = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@id", usuario.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }catch (SqlException ce){

                throw new DaoException("Erro ao Alterar Usuario :" + ce.Message);
            }


        }


        public List<Usuario> listUsuario() { 
        
            List<Usuario> lUsuario = new List<Usuario>();
            
            try
            {
                this.conn.openConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select id,nome from usuario";
                cmd.Connection = this.conn.SqlConn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    usuario.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    lUsuario.Add(usuario);
                }
                this.conn.closeConnection();
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Usuarios :" + ce.Message);
            }

            return lUsuario;



        }
    }
}

