using System;
using TriangleApp;

namespace practika
{
    public class ArrayTasks
    {
        // Задание 1: Проверка на одинаковые цифры в трехзначном числе
        public static bool AreDigitsEqual(int num)
        {
            string numStr = num.ToString();
            return numStr.Length == 3 && numStr.Distinct().Count() == 1;
        }

        // Задание 2: Подсчет положительных и отрицательных чисел
        public static (int positiveCount, int negativeCount) CountPositiveNegative(int num1, int num2, int num3)
        {
            int positiveCount = 0;
            int negativeCount = 0;

            if (num1 > 0) positiveCount++; else if (num1 < 0) negativeCount++;
            if (num2 > 0) positiveCount++; else if (num2 < 0) negativeCount++;
            if (num3 > 0) positiveCount++; else if (num3 < 0) negativeCount++;

            return (positiveCount, negativeCount);
        }

        // Задание 3: Разница между максимальным и минимальным элементами массива
        public static int MaxMinDifference(int[] arr)
        {
            // проверка на пустой массив
            if (arr == null || !arr.Any()) return 0;

            return arr.Max() - arr.Min();
        }

        // Задание 4: Создание массива из количества элементов в диапазоне столбцов матрицы
        public static int[] CreateArrayFromMatrix(int[,] matrix, int a, int b)
        {
            if (matrix == null ) return null; //ниче не возвращаем, если матрица пуста

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Проверка границ диапазона 
            if (a < 0 || b >= cols || a > b) return null;


            int[] result = new int[rows];
            for (int i = 0; i < rows; i++)
            {
               result[i] = b-a + 1; //подсчет количества элементов
            }
            return result;
        }

        // Метод создания матрицы с рнд значениями
        public static int[,] CreateRandomMatrix(int rows, int cols)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = random.Next(1, 101);
            return matrix;
        }
    }
}
   