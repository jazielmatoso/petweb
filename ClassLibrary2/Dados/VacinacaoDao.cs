using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;

namespace Backend.Dados
{
    interface VacinacaoDao
    {

        public void insertVacinacao(Vacinacao vacinacao);
        public void updateVacinacao(Vacinacao vacinacao);
        public void deleteVacinacao(Vacinacao vacinacao);
        private void insertDoseVacina(Vacinacao vacinacao);
        private void updateDoseVacina(Vacinacao vacinacao);
        public void deleteDoseVacina(List<DoseVacina> lDoseVacina);
        public List<Vacinacao> listVacinacao();
        public List<DoseVacina> getDoseVacina(Vacinacao vacinacao);
        
    }
}
