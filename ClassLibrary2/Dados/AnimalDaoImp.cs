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
    public class AnimalDaoImp
    {

        public Conexao conn;
        
        public AnimalDaoImp() {

            this.conn = new Conexao();
        }




        public Animal getAnimal(int animalId)
        {


            try
            {
                
                EspecieDaoImp especieImp = new EspecieDaoImp();

                this.conn.openConnection();
                Animal animal = new Animal();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT id,nome FROM animal WHERE id = @animal";
                cmd.Connection = this.conn.SqlConn;
                cmd.Parameters.AddWithValue("@animal", animalId);
                 SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    
                    animal.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    animal.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    animal.Idade = reader.GetInt32(reader.GetOrdinal("idade"));
                    animal.Peso = reader.GetFloat(reader.GetOrdinal("peso"));
                    int especieId =  reader.GetInt32(reader.GetOrdinal("especie_id"));
                    animal.Especie = especieImp.getEspecie(especieId);
                    animal.DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro"));


                }
                this.conn.closeConnection();

                return animal;
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Animals :" + ce.Message);
            }

            



        }





    }
}
