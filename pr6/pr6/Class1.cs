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
            public Equilateral(double a, double b , double c ):base(a,b,c)
            {
                if (SideA == SideB && SideB == SideC)
                {
                    CalculatePole();
                }
                else
                {
                    throw new Exception("равносторонний");
                }
                try { }
                catch (Exception e) { }
            }
            private void CalculatePole()
            {
                Pole = (SideA * SideA * Math.Sqrt(3) / 4);
            }
            public void UpdatePole()
            {
                CalculatePole();
            }
            
        }
    }
}
//double p = SideA + SideB + SideC;
//double Pole = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
