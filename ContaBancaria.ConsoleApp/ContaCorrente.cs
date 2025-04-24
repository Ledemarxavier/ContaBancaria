using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.ConsoleApp
{
    public class ContaCorrente
    {
        public int numero { get; set; }
        public double saldo { get; set; }
        public double limite { get; set; }
        public List<Movimentacao> movimentacoes = new List<Movimentacao>();

        public void Sacar(double quantia)
        {
            if (quantia <= saldo + limite)
            {
                saldo -= quantia;
                RegistrarMovimentacao("Débito", quantia);
            }
        }

        public void Depositar(double quantia)
        {
            saldo += quantia;
            RegistrarMovimentacao("Crédito", quantia);
        }

        public void Transferir(ContaCorrente destino, double quantia)
        {
            if (quantia <= saldo + limite)
            {
                Sacar(quantia);
                destino.Depositar(quantia);
            }
        }

        public void ExibirExtrato(DateTime dataBusca)
        {
            foreach (var mov in movimentacoes)

                if (mov.data.Date == dataBusca.Date)
                {
                    Console.WriteLine($"{mov.data:HH:mm} - {mov.tipo}: R$ {mov.valor:F2}");
                }
        }

        public void RegistrarMovimentacao(string tipo, double quantia)
        {
            movimentacoes.Add(new Movimentacao
            {
                data = DateTime.Now,
                tipo = tipo,
                valor = quantia
            });
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
        }
    }
}