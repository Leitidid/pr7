using System.Linq.Expressions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using practika;
using ArrayTasks;

namespace pr6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
     
           // Обработчик для Задания 1
        private void Task1_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(task1.Text, out int num) && num >= 100 && num <= 999) //смотрим трехзначное ли число
            {
                 bool areEqual = Array.AreDigitsEqual(num);
                 task1Result.Text = areEqual ? "Все цифры одинаковые" : "Цифры разные";
            }
            else
            {
                task1Result.Text = "ошибка. Введите трехзначное число.";
            }
        }

        // Обработчик для Задания 2
        private void Task2_Click(object sender, RoutedEventArgs e)
        {
            string[] input = task2.Text.Split(' ');
            if (input.Length == 3 && int.TryParse(input[0], out int num1) 
                && int.TryParse(input[1], out int num2) && int.TryParse(input[2], out int num3))
            {
                (int positiveCount, int negativeCount) = ArrayTasks.CountPositiveNegative(num1, num2, num3);
                task2Result.Text = $"Положительных: {positiveCount}, Отрицательных: {negativeCount}";
            }
            else
            {
                task2.Text = "Ошибка. Введите три целых числа через пробел.";
            }
        }

        // Обработчик для Задания 3
        private void Task3_Click(object sender, RoutedEventArgs e)
        {
            string[] input = task3.Text.Split(' ');
            if (input.All(x => int.TryParse(x, out _))) //Проверка на то, что все введенные значения - числа
            {
                int[] arr = input.Select(int.Parse).ToArray();
                int difference = Array.MaxMin(arr); 
                task3Result.Text = $"Разница между макимальным и минимальным числом: {difference}";
            }
            else
            {
                task3ResultTextBlock.Text = "ошибка. Введите целые числа через пробел.";
            }
        }

        // Обработчик для Задания 4
        private void Task4_Click(object sender, RoutedEventArgs e)
        {
            string[] input = task4.Text.Split(' ');
            
            if (input.Length == 4 && int.TryParse(input[0], out int rows) && int.TryParse(input[1], out int cols)
                && int.TryParse(input[2], out int a) && int.TryParse(input[3], out int b))
           {
                int[,] matrix = Array.CreateRandomMatrix(rows, cols);
                int[] result = Array.CreateArrayFromMatrix(matrix, a, b);

                if (resultArray != null) //Проверка, что массив был создан успешно
                    task4Result.Text = string.Join(" ", result);
                else
                    task4Result.Text = "Ошибка: введите правильные значения";
            }
            else
            {
                task4Result.Text = "ошибка. Введите размер матрицы и диапазон a-b (через пробел)";
            }
        }
    }
}
  