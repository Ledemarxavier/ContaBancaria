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
    }
}