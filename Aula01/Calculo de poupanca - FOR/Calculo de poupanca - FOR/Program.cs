using System;

class CalcularPoupanca
{
    static public void Main(string[] args)
    {
        double investimento = 1000;
        double taxaPercentual = 0.005;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= taxaPercentual;
            Console.WriteLine($"No Mês: {mes} voce têm R$: {investimento}" );
        }
        Console.ReadLine();
    }
}