using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBanco
{
    public class ContaBancaria
    {
        public string Tipo { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(string tipo, int numero, int agencia, double saldo)
        {
            Tipo = tipo;
            Numero = numero;
            Agencia = agencia;
            Saldo = saldo;
        }

        public string ExibirDadosConta()
        {
            return $"A conta Bancária pesquisada é do tipo {Tipo} com a agencia {Agencia}, inscrita no número de conta {Numero} e com o saldo de {Saldo}";
        }
    }
}
