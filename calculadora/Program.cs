namespace Calculadora;

class Program
{
  static void Main(string[] args)
  {
    //Exemplo didático procedural, para estudar lógica e funções sem introduzir objetos, propriedades ou herança.
    bool cauculadoraLigada = true;
    while (cauculadoraLigada)
    {
      Console.WriteLine("\n\t\t\t\t=== CALCULADORA DIDÁTICA EM C# ===\n");
      Console.WriteLine("1 - Somar\t2 - Subtrair\t3 - Multiplicar\t  4 - Dividir\t5 - Potência\t6 - Raiz Quadrada\t0 - Sair");
      Console.Write("Selecione a operação desejada:");

      string entrada = Console.ReadLine() ?? "";
      if (!int.TryParse(entrada, out int valorOpcao) || !Enum.IsDefined(typeof(Opcao), valorOpcao))
      {
        Console.WriteLine("Opção inválida.");
        continue;
      }

      Opcao opcao = (Opcao)valorOpcao;

      switch (opcao)
      {
        case Opcao.Sair:
          cauculadoraLigada = false;
          Console.WriteLine("Saindo do programa... Até logo!");
          break;

        case Opcao.Somar:
          Operacoes.ExecutarSoma();
          break;

        case Opcao.Subtrair:
          Operacoes.ExecutarSubtracao();
          break;

        case Opcao.Multiplicar:
          Operacoes.ExecutarMultiplicacao();
          break;

        case Opcao.Dividir:
          Operacoes.ExecutarDivisao();
          break;

        case Opcao.Potencia:
          Operacoes.ExecutarPotencia();
          break;

        case Opcao.RaizQuadrada:
          Operacoes.ExecutarRaizQuadrada();
          break;
      }
    }
  }

  enum Opcao
{
  Sair = 0,
  Somar = 1,
  Subtrair = 2,
  Multiplicar = 3,
  Dividir = 4,
  Potencia = 5,
  RaizQuadrada = 6,
}

public static class Operacoes
  {
    public static double Somar(double a, double b) => a + b;
    public static double Subtrair(double a, double b) => a - b;
    public static double Multiplicar(double a, double b) => a * b;
    public static double Dividir(double a, double b)
    {
      if (b == 0)
      {
        throw new DivideByZeroException("Divisão por zero não é permitida.");
      }
      return a / b;
    }
    public static double Potencia(double basePotencia, double expoente) => Math.Pow(basePotencia, expoente);
    public static double RaizQuadrada(double numero)
    {
      if (numero < 0)
      {
        throw new ArgumentException("Não é possível calcular a raiz quadrada de um número negativo.");
      }
      return Math.Sqrt(numero);
    }

    public static void ExecutarSoma()
    {
      Console.Write("\nDigite o primeiro número: ");
      double a = LerNumero();

      Console.Write("Digite o segundo número: ");
      double b = LerNumero();

      double resultado = Somar(a, b);
      Console.WriteLine($"Resultado da soma: {a} + {b} = {resultado}");
    }

    public static void ExecutarSubtracao()
    {
      Console.Write("\nDigite o primeiro número (minuendo): ");
      double a = LerNumero();

      Console.Write("Digite o segundo número (subtraendo): ");
      double b = LerNumero();

      double resultado = Subtrair(a, b);
      Console.WriteLine($"Resultado da subtração: {a} - {b} = {resultado}");
    }

    public static void ExecutarMultiplicacao()
    {
      Console.Write("\nDigite o primeiro fator: ");
      double a = LerNumero();

      Console.Write("Digite o segundo fator: ");
      double b = LerNumero();

      double resultado = Multiplicar(a, b);
      Console.WriteLine($"Resultado da multiplicação: {a} * {b} = {resultado}");
    }

    public static void ExecutarDivisao()
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

      double resultado = Dividir(a, b);
      Console.WriteLine($"Resultado da divisão: {a} / {b} = {resultado}");
    }

    public static void ExecutarPotencia()
    {
      Console.Write("\nDigite a base: ");
      double basePotencia = LerNumero();

      Console.Write("Digite o expoente: ");
      double expoente = LerNumero();

      double resultado = Potencia(basePotencia, expoente);
      Console.WriteLine($"Resultado da potência: {basePotencia} ^ {expoente} = {resultado}");
    }

    public static void ExecutarRaizQuadrada()
    {
        Console.Write("\nDigite o número para calcular a raiz quadrada: ");
        double numero = LerNumero();

        while (numero < 0)
        {
            Console.WriteLine("Não existe raiz quadrada de número negativo nos números reais.");
            Console.Write("Digite um número não negativo (>= 0): ");
            numero = LerNumero();
        }

        double resultado = RaizQuadrada(numero);
        Console.WriteLine($"Resultado da raiz quadrada: √{numero} = {resultado}");
    }

    private static double LerNumero()
    {
      while (true)
      {
        string entrada = Console.ReadLine() ?? ""; //Operador de Coalescência Nula / Null-Coalescing Operator: proteção contra null
        if (double.TryParse(entrada, out double numero))
        {
          return numero;
        }
        Console.Write("Número inválido. Digite novamente: ");
      }
    }
  }
}
