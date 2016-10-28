using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Basicas
{
    public class Dose
    {
        private int codDose;
        private int dosagem;
        private int numDose;


        public Dose() { }

        public Dose(int codDose, int dosagem, int numDose)
        {
            this.codDose = codDose;
            this.dosagem = dosagem;
            this.numDose = numDose;
        }

        public int CodDose
        {
            get
            {
                return codDose;
            }

            set
            {
                codDose = value;
            }
        }

        public int Dosagem
        {
            get
            {
                return dosagem;
            }

            set
            {
                dosagem = value;
            }
        }

        public int NumDose
        {
            get
            {
                return numDose;
            }

            set
            {
                numDose = value;
            }
        }
    }
}
