using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presença
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite sua média: ");
            double media = double.Parse(Console.ReadLine());

            Console.WriteLine("digite sua frequencia(sem a porcentagem): ");
            double fre =  double.Parse(Console.ReadLine());

            if (media >= 7 && fre >= 75) 
            {
                Console.WriteLine("o aluno passou ");
            }
            else if ((media < 7 && media >= 4)  && fre >= 75) 
            {
                Console.WriteLine("o aluno está de recuperação");
            }
            else if( media >= 7 && fre < 75) 
            {
                Console.WriteLine(" o aluno está de  recuperação");
            }
            else if ((media < 7 && media >= 4) && fre < 75) 
            {
                Console.WriteLine("o aluno retido");
            }
            else if (media < 4 )
            {
                Console.WriteLine("o aluno está retido");
            }
            else 
            {
                Console.WriteLine("a informação inserida está incorreta");
            }
            Console.ReadKey();
        }
    }
}
