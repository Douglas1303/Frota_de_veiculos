using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo
{
    public class UsuarioEntity
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string email { get; set; }
        public bool Ativo { get; set; }
    }
}
