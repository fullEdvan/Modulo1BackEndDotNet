namespace CalculadoraPOO
{
  public class CalculadoraService
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
  }
}