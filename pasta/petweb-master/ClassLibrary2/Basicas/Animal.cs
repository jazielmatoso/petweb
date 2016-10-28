using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Animal
    {

        private int codAnimal;
        private int idade;
        private string nome;
        private float peso;
        private string cor;
        private string raca;
        private DateTime dataCadastro;
        

        public Animal() { }

        public Animal(int codAnimal, int idade, string nome, float peso, string cor, string raca, DateTime dataCadastro)
        {
            this.codAnimal = codAnimal;
            this.idade = idade;
            this.nome = nome;
            this.peso = peso;
            this.cor = cor;
            this.raca = raca;
            this.dataCadastro = dataCadastro;
            
        }

        public int CodAnimal
        {
            get
            {
                return codAnimal;
            }

            set
            {
                codAnimal = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
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

        public float Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public string Cor
        {
            get
            {
                return cor;
            }

            set
            {
                cor = value;
            }
        }

        public string Raca
        {
            get
            {
                return raca;
            }

            set
            {
                raca = value;
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
