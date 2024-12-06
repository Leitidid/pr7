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
using TriangleApp;

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
       //вычисления периметра
            private void Bt1_Click(object sender, RoutedEventArgs e)
            {
                double sideA = double.Parse(tb1.Text); double sideB = double.Parse(tb2.Text);
                double sideC = double.Parse(tb3.Text); Triangle triangle = new Triangle(sideA, sideB, sideC);
                if (triangle.pravda())
                {
                    double perimeter = triangle.GetPerimeter();
                    tbResult.Text = perimeter.ToString(); MessageBox.Show("такой треугольник существует");
                }
                else
                {
                    MessageBox.Show("такой треугольник не существует");
                }
                // Вычисление периметра и результат
            }
            private void Bt2_Click(object sender, RoutedEventArgs e)
            {
                double sideA = double.Parse(tb1.Text);
                double sideB = double.Parse(tb2.Text); double sideC = double.Parse(tb3.Text);
                Triangle triangle = new Triangle(sideA, sideB, sideC);
                // Увеличение треугольника в 2 раза
                triangle.SetParams(2);
                // Обновление            tb1.Text = triangle.SideA.ToString();
                tb2.Text = triangle.SideB.ToString(); tb3.Text = triangle.SideC.ToString();
            }
            private void MenuItem_Click(object sender, RoutedEventArgs e)
            {
                string developer = "Дудина Екатерина";
                int job = 6; string task = "Использовать класс Triangle (треугольник) с полями-сторонами. Разработать\r\nоперацию для определения возможности существование треугольника с заданными \r\nсторонами true/false. Разработать операции для увеличения/уменьшения сторон на \r\n1.";
                MessageBox.Show($"Разработчик: {developer}\nНомер работы: {job}\nЗадание: {task}", "О программе");
            }
            // "Выход"
            private void MenuItem_Exit(object sender, RoutedEventArgs e)
            {
                this.Close();
            }
            private void btbig_Click(object sender, RoutedEventArgs e)
            {
                double sideA = double.Parse(tb1.Text); double sideB = double.Parse(tb2.Text);
                double sideC = double.Parse(tb3.Text);
                Triangle triangle = new Triangle(sideA, sideB, sideC); triangle.SetParams(sideA, sideB, sideC);
                triangle++; tb1.Text = triangle.SideA.ToString();
                tb2.Text = triangle.SideB.ToString();
                tb3.Text = triangle.SideC.ToString();
            }
            private void btmen_Click(object sender, RoutedEventArgs e)
            {
                double sideA = double.Parse(tb1.Text);
                double sideB = double.Parse(tb2.Text); double sideC = double.Parse(tb3.Text);
                Triangle triangle = new Triangle(sideA, sideB, sideC);
                triangle.SetParams(sideA, sideB, sideC); triangle--;
                tb1.Text = triangle.SideA.ToString(); tb2.Text = triangle.SideB.ToString();
                tb3.Text = triangle.SideC.ToString();
            }
            private void UpdateTriangle(double all)
            {
                try
                {
                    double sideA = double.Parse(tb1.Text);
                    double sideB = double.Parse(tb2.Text); double sideC = double.Parse(tb3.Text);
                    Triangle triangle = new Triangle(sideA, sideB, sideC);
                    triangle.SetParams(sideA, sideB, sideC); // Увеличиваем/уменьшаем все стороны
                    triangle++; triangle--;
                    if (triangle.pravda())
                    {
                        tb1.Text = triangle.SideA.ToString(); tb2.Text = triangle.SideB.ToString();
                        tb3.Text = triangle.SideC.ToString();
                    }
                    else
                    {
                        MessageBox.Show("изменения: стороны не удовлетворяют треугольник");
                    }
                }
                catch
                {
                    MessageBox.Show("введите правильные числовые значения.");
                }
            }
        
    }
}