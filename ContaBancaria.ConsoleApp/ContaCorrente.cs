using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.ConsoleApp
{
    internal class ContaCorrente
    {
        private int numero { get; set; }
        private double saldo { get; set; }
        private double limite { get; set; }
        private List<Movimentacao> movimentacoes = new List<Movimentacao>();

        public void Sacar(double quantia)
        { }

        public void Depositar(double valor)
        { }

        public void Transferir(ContaCorrente destino, double quantia)
        { }

        public void ExibirExtrato()
        { }

        private void RegistrarMovimentacao(string tipo, double quantia)
        { }
    }
}