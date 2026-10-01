using System;
using System.Collections.Generic; //dispensável pelo Implicit Usings ativo em .csproj

namespace SistemaNotas
{
  public class CalculadoraNotas
  {
    private readonly List<Estudante> _estudantes;

    public CalculadoraNotas()
    {
      _estudantes = new List<Estudante>();
    }

    public void AdicionarEstudante(Estudante estudante)
    {
      _estudantes.Add(estudante); //do Collections.Generic
    }

    public void ExibirRelatorio()
    {
      Console.WriteLine("Student\t\tGrade\tLetter\n");

      foreach (var estudante in _estudantes)
      {
        decimal media = estudante.CalcularMedia();
        string letra = estudante.ObterNotaConceitual();

        Console.WriteLine($"{estudante.Nome}:\t\t{media:F1}\t{letra}");
      }
    }
  }
}