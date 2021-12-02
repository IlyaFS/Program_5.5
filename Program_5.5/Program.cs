using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите целое число: ");
            int N = Convert.ToInt32(Console.ReadLine());
           
            int[,] mas = new int [N,N];
            for (int i = 0; i <N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mas[i, j]= 1 - (i + j) % 2;
                    Console.Write("{0} ", mas[i,j]);                    
                }
                Console.WriteLine();                
            }
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите на любого клавиша");
            Console.ReadKey();
        }
    }
}
