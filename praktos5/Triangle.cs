using System;
using System.Collections.Generic;
using System.Text;

namespace praktos4
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }  
        public void SetParams(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public bool Exists()
        {
            if ((a + b > c) && (b + c > a) && (a + c > b))
                return true;
            else
                return false;
        }
        public void SetParams()
        {
            a = a + 1;
            b = b + 1;
            c = c + 1;
        }

        public void SetParams2()
        {
            a = a - 1;
            b = b - 1;
            c = c - 1;
        }
        public string Show()
        {
            string text = "Сторона A = " + a + "\n";
            text = text + "Сторона B = " + b + "\n";
            text = text + "Сторона C = " + c + "\n";
            text = text + "Проверка = " + Exists() + "\n";
            return text;
        }
    }
}