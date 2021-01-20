using System;

namespace Task1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Start();
        }

        private static void Start()
        {
            int n = GetMatrixSize();
            int[,] matrix = GetMatrix(n);
            int min = GetMinSum(matrix);

            PrintMatrix(matrix);
            Console.WriteLine($"Ответ: {min}");
        }

        private static void Test()
        {
            int[,] matrix;
            matrix = new int[,] {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 }
            };
            DoTest(matrix, 1);

            matrix = new int[,] {
                { -1, -2, -3, -4, -5 },
                { -6, -7, -8, -9, -10 },
                { -11, -12, -13, -14, -15 },
                { -16, -17, -18, -19, -20 },
                { -21, -22, -23, -24, -25 }
            };
            DoTest(matrix, 2);

            matrix = new int[,] { { 0, 0 }, { 0, 0 } };
            DoTest(matrix, 3);
        }

        private static void DoTest(int[,] matrix, int numberOfTest)
        {
            Console.WriteLine($"Тест {numberOfTest}");
            PrintMatrix(matrix);
            Console.WriteLine($"Ответ: {GetMinSum(matrix)}");
            Console.WriteLine();
        }

        private static int GetMinSum(int[,] matrix)
        {
            int min = int.MaxValue;

            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                int sum = 0;
                for (var i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += Math.Abs(matrix[i, j]);
                }
                if (sum < min) min = sum;
            }

            return min;
        }

        private static int GetMatrixSize()
        {
            Console.Write("Введите размер квадратной матрицы (n) :");
            var n = Convert.ToInt32(Console.ReadLine());
            return n;
        }

        private static int[,] GetMatrix(int matrixSize)
        {
            Console.WriteLine($"Введите матрицу в виде {matrixSize} строк," +
                              $" и в каждой строке по {matrixSize} элементов разделенных пробелами.");

            var matrix = new int[matrixSize, matrixSize];

            for (var i = 0; i < matrixSize; i++)
            {
                var line = Console.ReadLine();
                var numbers = line?.Split(new char[] { ' ' });
                for (var j = 0; j < matrixSize && numbers != null; j++)
                {
                    matrix[i, j] = Convert.ToInt32(numbers[j]);
                }
            }

            return matrix;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine("Матрица:");
            for (var i = 0; i < matrix.GetLength(0); i++, Console.WriteLine())
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4} ", matrix[i, j]);
                }
            }
        }

    }
}
