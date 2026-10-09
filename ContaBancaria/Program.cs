namespace ContaBancaria
{
  class Program
  {
    static void Main(string[] args)
    {
      Conta ana = new ContaCorrente("Ana", 1000);
      Conta bia = new ContaPoupanca("Bia", 2000);
      Conta caio = new ContaCorrente("Caio");

      ana.Depositar(200);
      bia.Depositar(500, "salário");
      ana.Sacar(1500);
      caio.Sacar(400);
      caio.Sacar(200); // Negado! Ultrapassa o limite de R$ 500

      List<Conta> contas = new List<Conta> { ana, bia, caio };

      foreach (Conta c in contas)
      {
        c.FimDoMes();
        c.ExibirExtrato();
      }

      Console.WriteLine($"Total de contas: {Conta.GetTotalContas()}");
    }
  }
}