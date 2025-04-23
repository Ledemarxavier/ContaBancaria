using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ContaBancaria.ConsoleApp
{
    internal class Movimentacao
    {
        public DateTime data { get; set; }
        public string tipo { get; set; }
        private double valor { get; set; }

        public override string ToString()
        {
            return $"{data:dd/MM/yyyy HH:mm} - {tipo}: R$ {valor:F2}";
        }
    }
}