using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo
{
    public class incluirMotorista
    {
        
        public  string Matricula { get; set; }
        public string  Nome { get; set; }
        public string Cargo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
        public string Categoria { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataExame { get; set; }
        public string AntCriminais { get; set; }
       

        public  incluirMotorista()
        {

        }

        public incluirMotorista(string matricula, string nome, string cargo, DateTime dataNascimento, string rg, string cpf, string cnh, string categoria, string cep, string endereco, string uf, string cidade, string bairro, DateTime dataAdmissao, DateTime dataExame, string antCriminais)
        {
            
            Matricula = matricula;
            Nome = nome;
            Cargo = cargo;
            DataNascimento = dataNascimento;
            Rg = rg;
            Cpf = cpf;
            Cnh = cnh;
            Categoria = categoria;
            Cep = cep;
            Endereco = endereco;
            Uf = uf;
            Cidade = cidade;
            Bairro = bairro;
            DataAdmissao = dataAdmissao;
            DataExame = dataExame;
            AntCriminais = antCriminais;
        }
    }
}
