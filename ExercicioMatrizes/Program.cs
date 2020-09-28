using System;

namespace ExercicioMatrizes {
    class Program {
        static void Main(string[] args) {

            int N, M;
            int valor;

            Console.Write("ENTRE COM A DIMENSÃO 1 DA MATRIZ: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("ENTRE COM A DIMENSÃO 2 DA MATRIZ: ");
            M = int.Parse(Console.ReadLine());


            int[,] mat = new int[N, M];

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < M; j++) {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Insira o valor a ser pesquisado: ");
            valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < M; j++) {
                    
                    if (mat[i,j] == valor) {
                        Console.WriteLine("Posição "+i+","+j+":");
                       
                        if (j > 0) {
                            Console.WriteLine("Left: "+mat[i,j-1]);
                        }
                        if (j < M-1) {
                            Console.WriteLine("Right: "+mat[i,j+1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (i < N-1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                       
                    }


                }
            }




        }
    }
}
