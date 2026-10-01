using System;
using System.Linq; //dispensável pelo Implicit Usings ativo em .csproj

namespace SistemaNotas
{
  public class Estudante
  {
    public string Nome { get; set; }
    public int[] Notas { get; set; }

    public Estudante(string nome, int[] notas)
    {
      Nome = nome;
      Notas = notas;
    }

    public decimal CalcularMedia()
    {
      if (Notas == null || Notas.Length == 0)
        return 0m;

      return (decimal)Notas.Sum() / Notas.Length; //ou (decimal)Notas.Average();  // Sum() do Linq
    }

    public string ObterNotaConceitual()
    {
      decimal media = CalcularMedia();

      if (media >= 97) return "A+";
      if (media >= 93) return "A";
      if (media >= 90) return "A-";
      if (media >= 87) return "B+";
      if (media >= 83) return "B";
      if (media >= 80) return "B-";
      if (media >= 77) return "C+";
      if (media >= 73) return "C";
      if (media >= 70) return "C-";
      if (media >= 67) return "D+";
      if (media >= 63) return "D";
      if (media >= 60) return "D-";
      return "F";
    }
  }
}