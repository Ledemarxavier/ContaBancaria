namespace ContaBancaria.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente
            {
                numero = 121314,
                saldo = 2000,
                limite = 100,
                movimentacoes = new List<Movimentacao>()
            };

            conta1.Depositar(300);

            conta1.ExibirExtrato();
            Console.ReadLine();
        }
    }
}