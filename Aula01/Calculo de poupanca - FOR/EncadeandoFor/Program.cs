using System;

class EncadenadoFor
{
    static public void Main(string[] args)
    {
        for(int linhas = 0; linhas < 10; linhas++)
        {
            for(int coluna = 0; coluna < 10; coluna++)
            {
                Console.Write("*");
                if(coluna >= linhas)
                {
                    break;
                }
            }
            Console.WriteLine();
            
        }
    }
}