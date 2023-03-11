using System;

namespace MatrixTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int cols = 3;
            int[,] matrix = GenerateRandomMatrix(rows, cols);
            Console.WriteLine("Original matrix:");
            PrintMatrix(matrix);

            Task task = new Task(matrix);
            task.TransformMatrix();
            Console.WriteLine("Transformed matrix:");
            PrintMatrix(task.Matrix);

            Console.ReadLine();
        }

        static int[,] GenerateRandomMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Task
    {
        public int[,] Matrix { get; set; }

        public Task(int[,] matrix)
        {
            Matrix = matrix;
        }

        public void TransformMatrix()
        {
            int rows = Matrix.GetLength(0);
            int cols = Matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (Matrix[i, j] % 3 == 0)
                    {
                        Matrix[i, j] = Matrix[i, j] * Matrix[i, j];
                    }
                }
            }
        }
    }
}