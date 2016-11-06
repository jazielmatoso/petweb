using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Cliente : Usuario {


        private int cpf;
        private int rg;
        private Usuario cod_usuario;

        public int Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public int Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }
        public Usuario cd_usuario
        {
            get
            {
                return cd_usuario;
            }

            set
            {
                cd_usuario = value;
            }
        }
    }
}
