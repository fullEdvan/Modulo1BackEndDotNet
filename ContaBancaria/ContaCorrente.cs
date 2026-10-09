namespace ContaBancaria
{
  public class ContaCorrente : Conta
  {
    // Construtor com titular e saldo inicial
    public ContaCorrente(string titular, decimal saldoInicial)
        : base(titular, saldoInicial)
    {
    }

    // Construtor apenas com titular
    public ContaCorrente(string titular)
        : base(titular)
    {
    }

    // Sobrescreve o Sacar permitindo saldo negativo até o limite de R$ 500
    public override bool Sacar(decimal valor)
    {
      // O valor limite disponível para saque é Saldo + 500
      if (valor > Saldo + 500m)
      {
        return false; // Saque negado
      }

      Saldo -= valor;
      return true;
    }

    // Sobrescreve o FimDoMes aplicando a tarifa de R$ 10
    public override void FimDoMes()
    {
      Saldo -= 10m;
    }
  }
}