namespace ContaBancaria
{
  public class ContaPoupanca : Conta
  {
    // Construtor completo repassando para o construtor da classe base
    public ContaPoupanca(string titular, decimal saldoInicial)
        : base(titular, saldoInicial)
    {
    }

    // Construtor só com titular repassando para o construtor da classe base
    public ContaPoupanca(string titular)
        : base(titular)
    {
    }

    // No fim do mês, a poupança rende 1% (multiplica o saldo por 1.01)
    public override void FimDoMes()
    {
      Saldo *= 1.01m;
    }
  }
}