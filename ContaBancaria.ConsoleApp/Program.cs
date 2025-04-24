namespace ContaBancaria.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente
            {
                numero = 121314,
                saldo = 0,
                limite = 100,
            };

            conta1.Depositar(300);

            Console.ReadLine();

            ContaCorrente conta2 = new ContaCorrente
            {
                numero = 13141516,
                saldo = 0,
                limite = 50,
            };

            conta1.Transferir(conta2, 400);
            conta2.Depositar(300);
            conta1.ExibirExtrato(new DateTime(2025, 4, 24));
            Console.WriteLine();

            conta1.ExibirSaldo();
            conta2.ExibirSaldo();
            Console.WriteLine();
        }
    }
}