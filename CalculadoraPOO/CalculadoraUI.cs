namespace CalculadoraPOO
{
  public class CalculadoraUI
  {
    private readonly CalculadoraService _calculadoraService;

    public CalculadoraUI(CalculadoraService calculadoraService)
    {
      _calculadoraService = calculadoraService;
    }

    public static void ExibirMenu()
    {
      Console.WriteLine("\n\t\t\t\t=== CALCULADORA DIDÁTICA EM C# ===");
      Console.WriteLine("1 - Somar\t2 - Subtrair\t3 - Multiplicar\t4 - Dividir\t5 - Potência\t6 - Raiz Quadrada\t0 - Sair");
      Console.Write("Selecione a operação desejada: ");
    }

    public static Opcao ObterOpcao()
    {
      string entrada = Console.ReadLine() ?? "";

      if (int.TryParse(entrada, out int valorOpcao) && Enum.IsDefined(typeof(Opcao), valorOpcao))
      {
        return (Opcao)valorOpcao;
      }

      throw new InvalidOperationException("Opção inválida.");
    }

    public void ExecutarOperacao(Opcao opcao)
    {
      switch (opcao)
      {
        case Opcao.Somar:
          ExecutarSoma();
          break;
        case Opcao.Subtrair:
          ExecutarSubtracao();
          break;
        case Opcao.Multiplicar:
          ExecutarMultiplicacao();
          break;
        case Opcao.Dividir:
          ExecutarDivisao();
          break;
        case Opcao.Potencia:
          ExecutarPotencia();
          break;
        case Opcao.RaizQuadrada:
          ExecutarRaizQuadrada();
          break;
      }
    }

    private static void ExecutarSoma()
    {
      Console.Write("\nDigite o primeiro número: ");
      double a = LerNumero();

      Console.Write("Digite o segundo número: ");
      double b = LerNumero();

      double resultado = CalculadoraService.Somar(a, b);
      Console.WriteLine($"Resultado da soma: {a} + {b} = {resultado}");
    }

    private static void ExecutarSubtracao()
    {
      Console.Write("\nDigite o primeiro número (minuendo): ");
      double a = LerNumero();

      Console.Write("Digite o segundo número (subtraendo): ");
      double b = LerNumero();

      double resultado = CalculadoraService.Subtrair(a, b);
      Console.WriteLine($"Resultado da subtração: {a} - {b} = {resultado}");
    }

    private static void ExecutarMultiplicacao()
    {
      Console.Write("\nDigite o primeiro fator: ");
      double a = LerNumero();

      Console.Write("Digite o segundo fator: ");
      double b = LerNumero();

      double resultado = CalculadoraService.Multiplicar(a, b);
      Console.WriteLine($"Resultado da multiplicação: {a} * {b} = {resultado}");
    }

    private static void ExecutarDivisao()
    {
      Console.Write("\nDigite o dividendo: ");
      double a = LerNumero();

      Console.Write("Digite o divisor (diferente de 0): ");
      double b = LerNumero();

      while (b == 0)
      {
        Console.Write("Divisão por zero não é permitida. Digite um divisor válido: ");
        b = LerNumero();
      }

      double resultado = CalculadoraService.Dividir(a, b);
      Console.WriteLine($"Resultado da divisão: {a} / {b} = {resultado}");
    }

    private static void ExecutarPotencia()
    {
      Console.Write("\nDigite a base: ");
      double basePotencia = LerNumero();

      Console.Write("Digite o expoente: ");
      double expoente = LerNumero();

      double resultado = CalculadoraService.Potencia(basePotencia, expoente);
      Console.WriteLine($"Resultado da potência: {basePotencia} ^ {expoente} = {resultado}");
    }

    private static void ExecutarRaizQuadrada()
    {
      Console.Write("\nDigite o número para calcular a raiz quadrada: ");
      double numero = LerNumero();

      while (numero < 0)
      {
        Console.WriteLine("Não existe raiz quadrada de número negativo nos números reais.");
        Console.Write("Digite um número não negativo (>= 0): ");
        numero = LerNumero();
      }

      double resultado = CalculadoraService.RaizQuadrada(numero);
      Console.WriteLine($"Resultado da raiz quadrada: √{numero} = {resultado}");
    }

    private static double LerNumero()
    {
      while (true)
      {
        string entrada = Console.ReadLine() ?? "";
        if (double.TryParse(entrada, out double numero))
        {
          return numero;
        }
        Console.Write("Número inválido. Digite novamente: ");
      }
    }
  }
}