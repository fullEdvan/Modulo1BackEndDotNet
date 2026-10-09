// class Program
// {
//   static void Main()
//   {
//     // double n1 = 9, n2 = 7, n3 = 5;     // Ex. 1
//     // double n1 = 4, n2 = 5, n3 = 3;  // Ex. 2
//     double n1 = 6, n2 = 5, n3 = 4;  // Ex. 3

//     double media = (n1 + n2 + n3) / 3;
//     string situacao = "";

//     if (media >= 7)
//     {
//       situacao = "Aprovado";
//     }
//     else if (media >= 5 && media < 7)
//     {
//       situacao = "Recuperação";
//     }
//     else
//     {
//       situacao = "Reprovado";
//     }

//     Console.WriteLine($"Média: {media:F2}");
//     Console.WriteLine($"Situação: {situacao}");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     // int n = 10;      // Exemplo 1
//     int n = 20;   // Exemplo 2

//     int soma = 0;
//     int qtdMultiplos3 = 0;

//     for (int i = 1; i <= n; i++)
//     {
//       if (i % 2 == 0)
//       {
//         soma += i;
//       }
//       if (i % 3 == 0)
//       {
//         qtdMultiplos3++;
//       }
//     }
//     Console.WriteLine($"Soma dos pares: {soma}");
//     Console.WriteLine($"Múltiplos de 3: {qtdMultiplos3}");
//   }
// }





// class Program
// {
//     static void Main()
//     {
//         // int[] numeros = { 4, 9, 2, 15, 10 };
//         int[] numeros = { 5, 5, 5, 5 };

//      int min = numeros[0];
//      int max = numeros[0];
//      int media = 0;
//      int qtdAcimaMedia = 0;

//       for (int i = 0; i < numeros.Length; i++)
//           {
//               if (numeros[i] < min)
//               {
//                   min = numeros[i];
//               }
//               if (numeros[i] > max)
//               {
//                   max = numeros[i];
//               }
//               media += numeros[i]; 
//           }

//           media /= numeros.Length;

//           for (int i = 0; i < numeros.Length; i++)
//           {
//               if (numeros[i] > media)
//               {
//                   qtdAcimaMedia++;
//               }
//           }

//           Console.WriteLine($"Mínimo: {min}");
//           Console.WriteLine($"Máximo: {max}");
//           Console.WriteLine($"Média: {media}");
//           Console.WriteLine($"Quantidade acima da média: {qtdAcimaMedia}");
//     }
// }



class Program
{
  static bool EhPrimo(int numero)
  {
    if (numero == 2 || numero == 3 || numero == 5 || numero == 7)
    {
      return true;
    } else if (numero % 2 == 0 || numero % 3 == 0 || numero % 5 == 0 || numero % 7 == 0)
    {
      return false;
    }
    return true;
  }

  static void Main()
  {
    int limite = 20;     // Exemplo 1
                         // int limite = 10;  // Exemplo 2
    List<int> primos = new List<int>();

    for (int i = 2; i <= limite; i++)
    {
      if (EhPrimo(i))
      {
        primos.Add(i);
      }
    }

    Console.WriteLine($"Números primos até {limite}: {string.Join(", ", primos)}");
    Console.WriteLine($"Quantidade de números primos: {primos.Count}");
    Console.WriteLine($"Soma dos números primos: {primos.Sum()}");
  }
}

