using Backend;
using Backend.Basicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Erro;

namespace FrontEnd
{
    public partial class AlterarUsuarioView : Form
    {

        private Usuario usuario = null;

        public AlterarUsuarioView()
        {
            InitializeComponent();
        }

        public AlterarUsuarioView(Usuario usuario)
        {

            InitializeComponent();
            this.loadUser(usuario);
            
        }


        public void loadUser(Usuario usuario) {
            this.tNomeUsuario.Text = usuario.Nome;
            this.usuario = usuario;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string msg = "";
            try {

                Fachada f = Fachada.getInstancia();

                string nome = this.tNomeUsuario.Text;
                if (!usuario.Nome.Equals(nome))
                {
                    usuario.Nome = tNomeUsuario.Text;
                    f.alterarUsuario(usuario);
                }

                msg = "Alterado com sucesso";
                 

            }catch(GeralException g){
                msg = g.Message;
            }
            
            MessageBox.Show(msg);

        }
    }
}
