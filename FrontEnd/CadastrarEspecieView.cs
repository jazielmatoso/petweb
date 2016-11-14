using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;
using Backend.Basicas;

namespace FrontEnd
{
    public partial class CadastrarEspecieView : Form
    {
        Fachada f;
        public CadastrarEspecieView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            f = Fachada.getInstancia();
            Especie especie = new Especie();
            especie.Nome = txtNome.Text;
            especie.Descricao = txtDescricao.Text;
            f.inserirEspecie(especie);
            MessageBox.Show("Espécie cadastrada com sucesso!");
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
