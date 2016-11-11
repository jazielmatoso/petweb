using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Dados;



namespace Backend.Negocio
{
    public class AnimalController
    {


        private AnimalDaoImp animalDaoImp = null;

        public AnimalController()
        {

            this.animalDaoImp = new AnimalDaoImp();
            
        }





    }
}
