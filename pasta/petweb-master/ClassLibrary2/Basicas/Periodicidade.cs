using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Periodicidade
    {
        private int codPeriodicidade;
        private int qtdeDias;

        public Periodicidade() { }

        public Periodicidade(int codPeriodicidade, int qtdeDias)
        {
            this.codPeriodicidade = codPeriodicidade;
            this.qtdeDias = qtdeDias;
        }

        public int CodPeriodicidade
        {
            get
            {
                return codPeriodicidade;
            }

            set
            {
                codPeriodicidade = value;
            }
        }

        public int QtdeDias
        {
            get
            {
                return qtdeDias;
            }

            set
            {
                qtdeDias = value;
            }
        }
    }
}
