using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Usuario
    {
        private int codUsuario;
        private string nome;
        private string telefone;
        private string login;
        private string senha;
        private Permissao permissao;
 


        public Usuario() {


            this.Permissao = new Permissao();

        }


        public int CodUsuario
        {
            get
            {
                return codUsuario;
            }

            set
            {
                codUsuario = value;
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

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public Permissao Permissao
        {
            get
            {
                return permissao;
            }

            set
            {
                permissao = value;
            }
        }
    }
}
