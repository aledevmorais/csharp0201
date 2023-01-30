using Alura0201;

contaCorrente contadoAndre = new contaCorrente();
contadoAndre.titular = "André Silva";
contadoAndre.numero_agencia = 15;
contadoAndre.conta = "1011-X";
contadoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do Andre:  " + contadoAndre.saldo);

contadoAndre.depositar(100);

Console.WriteLine("Saldo da conta do Andre Atual :  " + contadoAndre.saldo);

if (contadoAndre.sacar(300)== true)
{
    Console.WriteLine("Saldo da conta do Andre Atual pós saque :  " + contadoAndre.saldo);
}
else
{
    Console.WriteLine("Saldo insuficente para esta operação de saque");
}

contaCorrente contaDaFulana = new contaCorrente();
contaDaFulana.titular = "Yvonne Strahovski";
contaDaFulana.numero_agencia = 17;
contaDaFulana.conta = "100200 - 1";
contaDaFulana.saldo = 350;

Console.WriteLine("Saldo da Conta da Yvonne : " + contaDaFulana.saldo);

contadoAndre.transferir(50, contaDaFulana);
Console.WriteLine("saldo da conta do André : " + contadoAndre.saldo);
Console.WriteLine("saldo da conta da Yvonne : " + contaDaFulana.saldo);


