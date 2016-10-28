using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Permissao
    {

        private int codPermissao;
        private string nome;
        private string descricao;
        private DateTime dataCadastro;



        public int CodPermissao
        {
            get
            {
                return codPermissao;
            }

            set
            {
                codPermissao = value;
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

        public DateTime DataCadastro
        {
            get
            {
                return dataCadastro;
            }

            set
            {
                dataCadastro = value;
            }
        }
    }
}
