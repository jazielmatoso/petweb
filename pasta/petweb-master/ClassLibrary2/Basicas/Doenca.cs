using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
   public class Doenca
    {
        private int codDoenca;
        private string nome;
        private string descricao;


        public Doenca() { }
            
            
        public Doenca(int codDoenca, string nome, string descricao)
        {
            this.codDoenca = codDoenca;
            this.nome = nome;
            this.descricao = descricao;
        }

        public int CodDoenca
        {
            get
            {
                return codDoenca;
            }

            set
            {
                codDoenca = value;
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
