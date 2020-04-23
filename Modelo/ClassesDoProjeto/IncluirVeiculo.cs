using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo.ClassesDoProjeto
{
   public  class IncluirVeiculo
    {
        public int CodVeiculo { get; set; }
        public string Ano { get; set; }
        public string Placa{ get; set; }
        public string Modelo { get; set; }
        public string Chassi { get; set; }
        public string Renavam { get; set; }
        public string Combustivel { get; set; }
        public string Categoria { get; set; }
        public string KM { get; set; }

        public IncluirVeiculo()
        {

        }

        public IncluirVeiculo(int codigoVeiculo, string ano, string placa, string modelo, string chassi, string renavam, string combustivel, string categoria, string kM)
        {
            CodVeiculo = codigoVeiculo; 
            Ano = ano;
            Placa = placa;
            Modelo = modelo;
            Chassi = chassi;
            Renavam = renavam;
            Combustivel = combustivel;
            Categoria = categoria;
            KM = kM;
        }
    }
}
