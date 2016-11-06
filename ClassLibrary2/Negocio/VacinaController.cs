

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;
using Backend.Dados;
using Backend.Erro;

namespace Backend.Negocio
{
    public class VacinaController
    {

        private VacinaDaoImp VacinaDao = null;

        public VacinaController() { 
            


        }

        
        public void cadastrar(Vacina vacina) {

            try {
                this.VacinaDao = new VacinaDaoImp();
                if (vacina.Equals(null) || vacina.Equals(""))
                {
                    throw new Exception("Não existe vacina no estoque");
                }
                this.VacinaDao.inserirVacina(vacina);
             

             }catch(ConexaoException c){
                throw new GeralException(c.Message);
             }catch(DaoException d){
                throw new GeralException(d.Message);
             }

        }


        public void alterar(Vacina vacina)
        {

            try
            {
                this.VacinaDao = new VacinaDaoImp();
                if (vacina.Equals(null) || vacina.Equals(""))
                {
                    throw new Exception("Objeto Usuario Nulo");
                }
                this.VacinaDao.alterarVacina(vacina);


            }
            catch (ConexaoException c)
            {
                throw new GeralException(c.Message);
            }
            catch (DaoException d)
            {
                throw new GeralException(d.Message);
            }

        }


        public void deletar(Usuario usuario)
        {

            try
            {
                this.usuarioDao = new UsuarioDaoImp();
                if (usuario.Equals(null) || usuario.Equals(""))
                {
                    throw new Exception("Objeto Usuario Nulo");
                }
                this.usuarioDao.deletarUsuario(usuario);


            }
            catch (ConexaoException c)
            {
                throw new GeralException(c.Message);
            }
            catch (DaoException d)
            {
                throw new GeralException(d.Message);
            }

        }

        public List<Usuario> listar()
        {
            try{
        
                UsuarioDaoImp usuarioDao = new UsuarioDaoImp();
                return usuarioDao.listUsuario();
            }catch(ConexaoException c){
                throw new GeralException(c.Message);
            }catch(DaoException d){
                throw new GeralException(d.Message);
            }
        
        }

    }
}
