using System;

namespace ExercicioDeFixacaoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o numero de colunas: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o numero de linhas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Entre com {0} numeros inteiros separados por espaço: ",n);
                string[] vet = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }


            Console.WriteLine("Entre com um numero da matriz na qual deseja saber a localização: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == numero)
                    {
                        Console.WriteLine("Position: " + i + "," + j);
                        Console.WriteLine("Left: " + mat[i, j - 1]);
                        if (j + 1 < n)
                        {
                            Console.WriteLine("Righ: " + mat[i, j + 1]);
                        }
                        if (i + 1 < n)
                        {
                            Console.WriteLine("Down: " + mat[i + 1,j]);
                        }
                        if (i - 1 >=0 && i - 1 < n)
                        {
                            Console.WriteLine("Up: " + mat[i - 1,j]);
                        }
                        

                    }

                }
            }


        }
    }
}