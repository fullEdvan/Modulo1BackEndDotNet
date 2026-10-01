using System; //dispensável pelo Implicit Usings ativo em .csproj

namespace SistemaNotas
{
  class Program
  {
    static void Main(string[] args)
    {
      var calculadora = new CalculadoraNotas();

      calculadora.AdicionarEstudante(new Estudante("Sophia", new int[] { 90, 86, 87, 98, 100 }));
      calculadora.AdicionarEstudante(new Estudante("Andrew", new int[] { 92, 89, 81, 96, 90 }));
      calculadora.AdicionarEstudante(new Estudante("Emma", new int[] { 90, 85, 87, 98, 68 }));
      calculadora.AdicionarEstudante(new Estudante("Logan", new int[] { 90, 95, 87, 88, 96 }));

      calculadora.ExibirRelatorio();

      Console.WriteLine("\nPressione a tecla Enter para continuar...");
      Console.ReadLine();
    }
  }
}