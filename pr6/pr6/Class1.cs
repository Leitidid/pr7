using System;
using TriangleApp;

namespace TriangleApp
{
    public class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b; SideC = c;
        }
        //вычисление периметра
        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
        public void SetParams(double a, double b, double c)
        {
            SideA = a;
            SideB = b; SideC = c;
        }
        public void SetParams(double dvax)
        {
            SideA *= dvax;
            SideB *= dvax; SideC *= dvax;
        }
        public void SetParams(int Sidex, int Sidey, int Sidez)
        {
            SideA += Sidex;
            SideB += Sidey; SideC += Sidez;
        }
        public bool pravda()
        {
            return (SideA + SideB > SideC) && (SideA + SideC > SideB) && (SideB + SideC > SideA);
        }
        public static Triangle operator ++(Triangle triangle)
        {
            triangle.SideA++;
            triangle.SideB++; triangle.SideC++;
            return triangle;
        }
        public static Triangle operator --(Triangle triangle)
        {
            triangle.SideA--;
            triangle.SideB--; triangle.SideC--;
            return triangle;
        }
        public class Equilateral : Triangle
        {
            public double Pole { get; private set; }
            public Equilateral(double side):base(side,side,side)
            {
                CalculatePole();
            }
            private void CalculatePole()
            {
                double side = SideA;
                Pole = (side * side * Math.Sqrt(3)) ;
            }
            public void UpdatePole()
            {
                CalculatePole();
            }
        }
    }
}
