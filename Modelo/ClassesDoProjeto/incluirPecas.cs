using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo.ClassesDoProjeto
{
   public class incluirPecas
    {
        public string NomePeca { get; set; }
        public string CodigoPeca { get; set; }
        public string Fornecedor{ get; set; }
        public string Modelo{ get; set; }
        public int Quantidade { get; set; }
        public string Disponibilidade { get; set; }
        public float DemandaMedia { get; set; }

        public incluirPecas()
        {

        }

        public incluirPecas(string nomePeca, string codigoPeca, string fornecedor, string modelo, int quantidade, string disponibilidade, float demandaMedia)
        {
            NomePeca = nomePeca;
            CodigoPeca = codigoPeca;
            Fornecedor = fornecedor;
            Modelo = modelo;
            Quantidade = quantidade;
            Disponibilidade = disponibilidade;
            DemandaMedia = demandaMedia;
        }
    }
}
