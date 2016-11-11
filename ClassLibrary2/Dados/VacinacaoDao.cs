﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;

namespace Backend.Dados
{
    interface VacinacaoDao
    {

        void insertVacinacao(Vacinacao vacinacao);
        
        void updateVacinacao(Vacinacao vacinacao);
        void deleteVacinacao(Vacinacao vacinacao);
        void insertDoseVacina(Vacinacao vacinacao);
        void updateDoseVacina(Vacinacao vacinacao);
        void deleteDoseVacina(List<DoseVacina> lDoseVacina);
        List<Vacinacao> listVacinacao();
        List<DoseVacina> getDoseVacina(Vacinacao vacinacao);
        
    }
}
