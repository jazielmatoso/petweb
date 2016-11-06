using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;
using Backend.Negocio;

namespace Backend
{
    public class Fachada
    {

        private static Fachada instancia;
        private UsuarioController usuarioC;
        private ClienteController clienteC;


        private Fachada()
        {
            usuarioC = new UsuarioController();
            clienteC = new ClienteController();
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
    }
}

