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
        public VacinacaoController vacinacaoC;
        public Fachada() {
           this.usuarioC = new UsuarioController();
           this.vacinacaoC = new VacinacaoController();
        }

        public void cadastrarUsuario(Usuario usuario) {
            this.usuarioC.cadastrar(usuario);
        }

        public List<Usuario> listarUsuario()
        {
            return this.usuarioC.listar();
        }


        public void alterarUsuario(Usuario usuario)
        {
            this.usuarioC.alterar(usuario);
        }


        public void deletarUsuario(Usuario usuario)
        {
            this.usuarioC.deletar(usuario);
        }


        public void cadastrarVacinacao(Vacinacao vacinacao) {

            this.vacinacaoC.cadastrar(vacinacao);
        }

    }
}
