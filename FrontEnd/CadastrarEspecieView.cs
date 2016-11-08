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
using Backend.Basicas.Especie;

namespace FrontEnd
{
    public partial class CadastrarEspecieView : Form
    {
        Fachada f = new Fachada();
        Especie especie;
        public CadastrarEspecieView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           f.getInstancia();
             especie = new Especie();
            especie.nome = txtNome.Text;
            especie.descricao = txtDescricao.Text;
            f.inserirEspecie(especie);
            MessageBox.Show("Espécie cadastrada com sucesso!");
            
        }
    }
}
