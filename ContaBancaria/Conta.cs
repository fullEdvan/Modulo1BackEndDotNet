namespace ContaBancaria
{
  public class Conta
  {
    // Requisito 1: Titular e Saldo
    public string Titular { get; } // 1. Titular não muda -> get público, sem set externo
    public decimal Saldo { get; protected set; } // 2. Saldo (DICA 2) -> get público para leitura, protected set para as filhas alterarem
                                                 // Requisito 5 / Dica 4: Atributo/Propriedade static para contar todas as contas
    private static int totalContas = 0;

    // Requisito 2: Construtor 1 (Titular e Saldo Inicial)
    public Conta(string titular, decimal saldoInicial)
    {
      Titular = titular;
      Saldo = saldoInicial;
      totalContas++; // Incrementa a contagem a cada nova conta
    }

    // Requisito 2: Construtor 2 (Só Titular, saldo inicia em 0)
    // O ": this(titular, 0)" reaproveita o construtor acima!
    // Veja o segundo construtor: usando : this(titular, 0m), ele chama o primeiro construtor repassando o 0m como saldo inicial. Isso evita duplicar o código do TotalContasCriadas++ e da atribuição do Titular!
    public Conta(string titular) : this(titular, 0m)
    {
    }

    public static int GetTotalContas()
    {
      return totalContas;
    }

    // Depósito simples
    public virtual void Depositar(decimal valor)
    {
      Saldo += valor;
    }

    // Sobrecarga de Depósito aceitando uma descrição (ex: "salário")
    public virtual void Depositar(decimal valor, string descricao)
    {
      Depositar(valor);
      Console.WriteLine($"Depósito: {descricao}");
    }

    // Sacar padrão da classe base
    public virtual bool Sacar(decimal valor)
    {
      if (valor > Saldo)
      {
        return false;
      }

      Saldo -= valor;
      return true;
    }

    public virtual void FimDoMes()
    {
      // Será sobrescrito nas classes filhas
    }

    // Formatação solicitada na Saída Esperada: Nome: R$ Saldo (com F0)
    public virtual void ExibirExtrato()
    {
      Console.WriteLine($"{Titular}: R$ {Saldo:F0}");
    }

    /* public void Depositar(decimal valor)
    {
      if (valor <= 0)
      {
        Console.WriteLine("O valor do depósito deve ser maior que zero.");
        return;
      }

      Saldo += valor;
      Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso.");
    } */
  }
}