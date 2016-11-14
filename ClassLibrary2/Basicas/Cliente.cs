﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Cliente
    {


        private int cpf;
        private int rg;
        private Usuario usuario;

        public Cliente()
        {
        
            this.usuario = new Usuario();
        }
       
        
        
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
        public Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

    }
}

