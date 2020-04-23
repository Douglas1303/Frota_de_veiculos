using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo.ClassesDoProjeto
{
    public class incluirManutencao
    {
        private string placa { get; set; }
        private DateTime dataManutencao { get; set; }
        private string resultado { get; set; }
        private string motivo { get; set; }
        private string servicoRealizado { get; set; }
        private float valor { get; set; }
        private float revisao { get; set; }

        public string Placa { get {return placa ; } set { placa = value; } }
        public DateTime DataManutencao { get { return dataManutencao; } set { dataManutencao = value; } }
        public string Resultado { get { return resultado; } set { resultado = value; } }
        public string Motivo { get { return motivo; } set { motivo = value; } }
        public string ServicoRealizado { get { return servicoRealizado; } set { servicoRealizado = value; } }
        public float Valor { get { return valor; } set { valor = value; } }
        public float Revisao { get { return revisao; } set { revisao = value; } }

        public incluirManutencao()
        {

        }

        public incluirManutencao(string placa, DateTime DataManutencao, string resultado, string motivo, string servicoRealizado, float valor, float revisao)
        {
            Placa = placa;
            dataManutencao = DataManutencao;
            Resultado = resultado;
            Motivo = motivo;
            ServicoRealizado = servicoRealizado;
            Valor = valor;
            Revisao = revisao;
        }
    }
}
