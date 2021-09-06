using System;

namespace Notaaluno
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notaAluno = new double[2];
            double res;

            notaAluno[0] = double.Parse(Console.ReadLine());
            while (notaAluno[0] < 0 || notaAluno[0] > 10)
            {
                Console.WriteLine("nota invalida");
                notaAluno[0] = double.Parse(Console.ReadLine());
            }
            notaAluno[1] = double.Parse(Console.ReadLine());
            while (notaAluno[1] < 0 || notaAluno[1] > 10)
            {
                Console.WriteLine("nota invalida");
                notaAluno[1] = double.Parse(Console.ReadLine());
            }
            res = (notaAluno[0] + notaAluno[1]) / 2;
            Console.WriteLine("media = " + res.ToString("N2"));
        }
    }
}