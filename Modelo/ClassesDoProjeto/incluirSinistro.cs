using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo.ClassesDoProjeto
{
    public class incluirSinistro
    {
        public int NumeroSinistro { get; set; }
        public string PlacaVeiculo { get; set; }
        public string MatriculaMotorista { get; set; }
        public DateTime DataOcorrido { get; set; }
        public float ValorOrçamento { get; set; }
        public string TipoSinistro { get; set; }
        public string ContatoTerceiro { get; set; }
        public string DescricaoSinistro { get; set; }

        public incluirSinistro()
        {

        }

        public incluirSinistro(int numeroSinistro, string placaVeiculo, string matriculaMotorista, DateTime dataOcorrido, float valorOrçamento, string tipoSinistro, string contatoTerceiro, string descricaoSinistro)
        {
            NumeroSinistro = numeroSinistro;
            PlacaVeiculo = placaVeiculo;
            MatriculaMotorista = matriculaMotorista;
            DataOcorrido = dataOcorrido;
            ValorOrçamento = valorOrçamento;
            TipoSinistro = tipoSinistro;
            ContatoTerceiro = contatoTerceiro;
            DescricaoSinistro = descricaoSinistro;
        }
    }
}
