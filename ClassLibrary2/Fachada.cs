using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;
using Backend.Dados;
using Backend.Negocio;

namespace Backend
{
  public class Fachada
    {

               
        
        private static Fachada instancia;
        private UsuarioController usuarioC;
        private ClienteController clienteC;
        private EspecieController especieC;
        private AnimalController animalC;
        private CorController corC;


       
        private Fachada() {
            usuarioC = new UsuarioController();
            clienteC = new ClienteController();
            especieC = new EspecieController();
            animalC = new AnimalController();
            corC = new CorController();


        }



        public static Fachada getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Fachada();
            }

            return instancia;
        }

        

        public void inserirUsuario(Usuario usuario)
        {

            usuarioC.cadastrar(usuario);

        }

        public List<Usuario> listarUsuario()
        {
            return usuarioC.listar();
        }


        public void alterarUsuario(Usuario usuario)
        {
            usuarioC.alterar(usuario);
        }


        public void deletarUsuario(Usuario usuario)
        {
            usuarioC.deletar(usuario);
        }



        /////////////////////////////////////////////



        public void inserirCliente(Cliente cliente)
        {

            clienteC.cadastrar(cliente);

        }

        public List<Cliente> listarCliente()
        {
            return clienteC.listar();
        }


        public void alterCliente(Cliente cliente)
        {
            clienteC.alterar(cliente);
        }


        public void deletarCliente(Cliente cliente)
        {
            clienteC.deletar(cliente);
        }

        /////////////////////////////////// Especie

        public void inserirEspecie(Especie especie)
        {

            especieC.cadastrar(especie);

        }

        public List<Especie> listarEspecie()
        {
            return especieC.listar();
        }


        public void alterarEspecie(Especie especie)
        {
           especieC.alterar(especie);
        }


        public void deletarEspecie(Especie especie)
        {
            especieC.deletar(especie);
        }
        /////////////////////Animal
        public void inserirAnimal(Animal animal)
        {

            animalC.cadastrar(animal);

        }

        public List<Animal> listarAnimal()
        {
            return animalC.listar();
        }


        public void AlterarAnimal(Animal animal)
        {
            animalC.alterar(animal);
        }


        public void deletarAnimal(Animal animal)
        {
            animalC.deletar(animal);
        }


        /////////////Cor
        public void inserirCor(Cor cor)
        {

            corC.Cadastrar(cor);

        }

        public List<Cor> listarCor()
        {
            return corC.listar();
        }


        public void AlterarCar(Cor cor)
        {
            corC.alterar(cor);
        }


        public void deletarCor(Cor cor)
        {
            corC.deletar(cor);
        }

    }
}
