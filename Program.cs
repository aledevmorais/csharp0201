using Alura0201;

contaCorrente contadoAndre = new contaCorrente();
contadoAndre.titular = "André Silva";
contadoAndre.numero_agencia = 15;
contadoAndre.conta = "1011-X";
contadoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do Andre:  " + contadoAndre.saldo);

contadoAndre.depositar(100);

Console.WriteLine("Saldo da conta do Andre Atual :  " + contadoAndre.saldo);