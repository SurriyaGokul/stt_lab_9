using System;

namespace Lab9
{
    class FirstQuestion
    {
        static void Main()
        {
            string name = "surr";
            Console.Beep();
            Console.WriteLine($"My name is {name}");
        }
    }

    class SecondQuestion
    {
        static void Main()
        {
            Console.WriteLine("Enter first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2;
            if (sum % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }

    class ThirdQuestion
    {
        static int FactorialDemo(int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else
            {
                return i * FactorialDemo(i - 1);
            }
        }

        static void Main()
        {
            Console.WriteLine("Printing Numbers using for loop");
            for (int i = 1; i <= 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Printing Numbers using foreach loop");
            foreach (var num in new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })
            {
                Console.WriteLine(num);
            }
            string input = "first";
            do
            {
                input = Console.ReadLine();
                Console.WriteLine($"You entered: {input} which is not exit so still inside the loop only");
            }
            while (input != "exit");

            Console.WriteLine($"Input number to get factorial of:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of {number} is {FactorialDemo(number)}");
        }
    }

    class FourthQuestion
    {
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static int[] Flatten2DArrayRowMajor(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] flattened = new int[rows * cols];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    flattened[index++] = matrix[i, j];
                }
            }

            return flattened;
        }
        static int[] Flatten2DArrayColumnMajor(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] flattened = new int[rows * cols];
            int index = 0;

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    flattened[index++] = matrix[i, j];
                }
            }

            return flattened;
        }
        static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            if (colsA != rowsB)
            {
                throw new ArgumentException("Number of columns in matrix A must equal number of rows in matrix B");
            }

            int[,] resultC = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    resultC[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        resultC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return resultC;
        }
        static void Print1DArray(int[] arr)
        {
            Console.Write("Array: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void Print2DArray(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            Console.WriteLine("Bubble Sort --->");
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Original array:");
            Print1DArray(numbers);
            BubbleSort(numbers);
            Console.WriteLine("Sorted array:");
            Print1DArray(numbers);

            Console.WriteLine("\n2D Array Flattening --->");
            int[,] matrix2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Original 2D array:");
            Print2DArray(matrix2D);

            Console.WriteLine("Flattened (Row Major Order):");
            int[] flattenedRowMajor = Flatten2DArrayRowMajor(matrix2D);
            Print1DArray(flattenedRowMajor);

            Console.WriteLine("Flattened (Column Major Order):");
            int[] flattenedColumnMajor = Flatten2DArrayColumnMajor(matrix2D);
            Print1DArray(flattenedColumnMajor);

            Console.WriteLine("\nMatrix Multiplication --->");
            int[,] matrixA = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] matrixB = { { 7, 8 }, { 9, 10 }, { 11, 12 } };

            Console.WriteLine("Matrix A (2x3):");
            Print2DArray(matrixA);

            Console.WriteLine("Matrix B (3x2):");
            Print2DArray(matrixB);

            int[,] matrixC = MultiplyMatrices(matrixA, matrixB);
            Console.WriteLine("Result Matrix C (2x2):");
            Print2DArray(matrixC);
        }
    }
}