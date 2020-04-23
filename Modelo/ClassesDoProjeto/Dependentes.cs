using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo.ClassesDoProjeto
{
    class Dependentes
    {
        //Atributos
        private string _Nome;
        private DateTime _DataNascimento;
        private string _CPF;
        private string _NomeMae;
        private string _GrauParentesco;
        //Propriedades 
        public string Nome { get { return this._Nome; } set { this._Nome = value; } }
        public DateTime Data_Nascimento { get { return this._DataNascimento; } set { this._DataNascimento = value; } }
        public string CPF { get { return this._CPF; } set { this._CPF = value; } }
        public string Nome_Mae { get { return this._NomeMae; } set { this._NomeMae = value; } }
        public string Grau_Parestesco { get {return this._GrauParentesco; } set { this._GrauParentesco = value; } }


        public Dependentes()
        {

        }

        //public Dependentes( string nome, DateTime dataNascimento, string cpf, string nomeMae, string grauParentesco)
        //{
        //    this._Nome = nome;
        //    this._DataNascimento = dataNascimento;            
        //    this._CPF = cpf;
        //    this._NomeMae = nomeMae;
        //    this._GrauParentesco = grauParentesco;
        //}
    }
}
