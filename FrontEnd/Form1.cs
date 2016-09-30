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
    public partial class Form1 : Form
    {

        private List<Usuario> listaUsuario = new List<Usuario>();
        
        
        public Form1()
        {
            InitializeComponent();
            listarUsuarios();
            
        }


        private void listarUsuarios() {
           try
            {

               Fachada f = new Fachada();

               this.listaUsuario = f.listarUsuario();

               listView1.Items.Clear();
               foreach (Usuario usuario in this.listaUsuario)
               {
                  ListViewItem item =  listView1.Items.Add("" + usuario.Id);
                  item.SubItems.Add(usuario.Nome);
               }
 
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
               
                Fachada f = new Fachada();
                Usuario usuario = new Usuario();
                usuario.Nome = textBox1.Text;
                f.cadastrarUsuario(usuario);    
                MessageBox.Show("Usuario cadastrado com sucesso!");
                this.listarUsuarios();    
            }
            catch (Exception ex) {
               MessageBox.Show(ex.Message);
            } 



        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
        
            int test = Convert.ToInt32(listView1.SelectedItems[0].Index.ToString());
            AlterarUsuario fAlterarUsuario = new AlterarUsuario(this.listaUsuario[test]);
            fAlterarUsuario.ShowDialog();
            listView1.SelectedItems[0].SubItems[1].Text = this.listaUsuario[test].Nome;  
            //listarUsuarios();
            //
        
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
                  }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0) {

                int test = Convert.ToInt32(listView1.SelectedItems[0].Index.ToString());
                DialogResult dialogResult = MessageBox.Show("Deseja deletar Usuário " + this.listaUsuario[test].Nome.ToString(),"Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    Fachada f = new Fachada();
                    f.deletarUsuario(this.listaUsuario[test]);
                   // listarUsuarios();
                    listView1.SelectedItems[0].Remove();
                }
                
            }
            
            

        }

        

    }
}
