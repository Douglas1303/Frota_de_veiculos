using ProjetoLogin.Dal;
using ProjetoLogin.Dao.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo
{
   public class Controle
    {
        private readonly IRepository<UsuarioEntity> repository;

        public Controle(IRepository<UsuarioEntity> repository)
        {
            this.repository = repository;
        }

        public bool tem;
        public String mensagem =""; 

        public bool acessar(String login, String senha)
        {
            LoginDalComandos loginDao = new LoginDalComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem; 
            }
            return tem; 
        }
        public String cadastrar(String usuario, String senha, String confSenha)
        {
            LoginDalComandos loginDao = new LoginDalComandos();
            this.mensagem = loginDao.cadastrar(usuario, senha, confSenha);
            if (loginDao.tem)
            {
                this.tem = true; 
            }

            return mensagem; 
        }

        /// <summary>
        /// Este metodo retorna se o usuario informado para login existe
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool existeUsuario(string usuario)
        {
            var usuarios = retornausuariosssss();
            return repository.getByUser(usuario);
        }


        /// <summary>
        /// /Este metodo retorna todos usuários ativos.
        /// </summary>
        /// <returns></returns>
        public UsuarioEntity retornaUsuarios()
        {
            return repository.getuser();
        }

        public List<UsuarioEntity> retornausuariosssss()
        {
            return repository.GetUsuarios();
        }

        public bool CadastrarUsuario(string usuario, string senha, string email)
        {
            return repository.InserirUsuario(usuario, senha, email);
        }

    }
}
