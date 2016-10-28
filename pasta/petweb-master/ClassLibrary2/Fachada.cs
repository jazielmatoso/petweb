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

        public UsuarioController usuarioC;

        public Fachada() {
             usuarioC = new UsuarioController();  
        }

        public void cadastrarUsuario(Usuario usuario) {
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

    }
}
