using Atv._07;

ContaCorrente conta1 = new ContaCorrente
{
    Banco = "Nubank",
    Agencia = "Araras",
    Conta = "Corrente",
    Saldo = "R$13.567,99",
    limite = 20000
};

ContaCorrente conta2 = new ContaCorrente
{
    Banco = "Banco do Brasil",
    Agencia = "Brasil",
    Conta = "Corrente",
    Saldo = "R$16.386,99",
    limite = 25789
};

ContaCorrente conta3 = new ContaCorrente
{
    Banco = "PicPay",
    Agencia = "Araras",
    Conta = "Corrente",
    Saldo = "R$156.876,99",
    limite = 348782
};


Console.WriteLine($"O banco é: {conta1.Banco}, sua agencia é: {conta1.Agencia}, sua conta é: {conta1.Conta}, seu saldo é de: {conta1.Saldo}, seu limite é de: {conta1.limite}.");
Console.WriteLine($"O banco é: {conta2.Banco}, sua agencia é: {conta2.Agencia}, sua conta é: {conta2.Conta}, seu saldo é de: {conta2.Saldo}, seu limite é de: {conta2.limite}.");
Console.WriteLine($"O banco é: {conta3.Banco}, sua agencia é: {conta3.Agencia}, sua conta é: {conta3.Conta}, seu saldo é de: {conta3.Saldo}, seu limite é de: {conta3.limite}.");

conta1.Depositar();
conta1.Sacar();


Console.ReadKey();