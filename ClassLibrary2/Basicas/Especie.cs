using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Especie
    {
        private int codEspecie;
        private string nome;
        private string descricao;

        public Especie(int codEspecie, string nome, string descricao)
        {
            this.codEspecie = codEspecie;
            this.nome = nome;
            this.descricao = descricao;
        }

        public int CodEspecie
        {
            get
            {
                return codEspecie;
            }

            set
            {
                codEspecie = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

      
    }
}
