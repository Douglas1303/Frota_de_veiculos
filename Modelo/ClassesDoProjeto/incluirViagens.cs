using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo.ClassesDoProjeto
{
    public class incluirViagens
    {
        public string PlacaVeiculo { get; set; }
        public string MatriculaMotorista { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public string Abastecimento { get; set; }
        public float ValorAbastecimento { get; set; }
        public float Quilometragem { get; set; }

        public incluirViagens()
        {

        }

        public incluirViagens(string placaVeiculo, string matriculaMotorista, DateTime entrada, DateTime saida, string abastecimento, float valorAbastecimento, float quilometragem)
        {
            PlacaVeiculo = placaVeiculo;
            MatriculaMotorista = matriculaMotorista;
            Entrada = entrada;
            Saida = saida;
            Abastecimento = abastecimento;
            ValorAbastecimento = valorAbastecimento;
            Quilometragem = quilometragem;
        }
    }
}
