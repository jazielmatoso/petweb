using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Vacinacao
    {
        private int codVacinacao;
        private DateTime dataVacinacao;
        private Animal animal;
        private Veterinario veterinario;

        public Vacinacao() { }

        public Vacinacao(int codVacinacao, DateTime dataVacinacao, Animal animal, Veterinario veterinario)
        {
            this.codVacinacao = codVacinacao;
            this.dataVacinacao = dataVacinacao;
            this.animal = animal;
            this.Veterinario = veterinario;
        }

        public int CodVacinacao
        {
            get
            {
                return codVacinacao;
            }

            set
            {
                codVacinacao = value;
            }
        }

        public DateTime DataVacinacao
        {
            get
            {
                return dataVacinacao;
            }

            set
            {
                dataVacinacao = value;
            }
        }

        public Animal Animal
        {
            get
            {
                return animal;
            }

            set
            {
                animal = value;
            }
        }

        public Veterinario Veterinario
        {
            get
            {
                return veterinario;
            }

            set
            {
                veterinario = value;
            }
        }
    }
}
