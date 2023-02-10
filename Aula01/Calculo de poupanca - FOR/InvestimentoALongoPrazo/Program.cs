using System;
using System.IO.Pipes;

class InvestimentoALongoPrazo
{
    static public void Main(string[] args)
    {
        double FatorRendimento = 1.005;
        double crescimento = 0.001;
        double valorInvestido = 1000;

        for(int anos = 1;anos <= 5; anos++)
        {
            for(int mes = 1; mes <= 12; mes++) {

                valorInvestido *= FatorRendimento;
            }
            FatorRendimento += crescimento;
        }
        Console.WriteLine($"depois de 5 anos terá: {valorInvestido}");
    }
}