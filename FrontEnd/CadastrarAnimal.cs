using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEnd;

namespace FrontEnd
{
    public partial class CadastrarAnimal : Form
    {
        public CadastrarAnimal()
        {
            InitializeComponent();
        }

        private void buttonNovaEspecie_Click(object sender, EventArgs e)
        {
            CadastrarEspecieView cadastrarEspecie = new CadastrarEspecieView();
            cadastrarEspecie.Show();
        }

        private void ButtonNovaRaca_Click(object sender, EventArgs e)
        {
            CadastrarRaca cadastrarRaca = new CadastrarRaca();
            cadastrarRaca.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarCor cadastraCor = new CadastrarCor();
            cadastraCor.Show();
        }

        private void ButtonInserir_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
