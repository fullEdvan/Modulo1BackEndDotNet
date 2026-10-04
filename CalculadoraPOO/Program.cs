namespace CalculadoraPOO
{
  class Program
  {
    static void Main(string[] args)
    {
      var calculadoraService = new CalculadoraService();
      var ui = new CalculadoraUI(calculadoraService);

      bool calculadoraLigada = true;

      while (calculadoraLigada)
      {
        CalculadoraUI.ExibirMenu();

        try
        {
          Opcao opcao = CalculadoraUI.ObterOpcao();

          if (opcao == Opcao.Sair)
          {
            calculadoraLigada = false;
            Console.WriteLine("Saindo do programa... Até logo!");
          }
          else
          {
            ui.ExecutarOperacao(opcao);
          }
        }
        catch (InvalidOperationException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
      }
    }
  }
}