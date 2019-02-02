﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProject
{
    public class Methods
    {
        // В классе Methods реализуйте публичный статический метод task1860.
        // принимает в качестве аргумента 1 строку.
        //В теле метода task1860 напечатайте в консоль решение задачи, используя значение аргумента в качестве исходных данных.
        public static void task1860(string x) // 1
        {
            Console.WriteLine("Мы стремимся к " + x);
        }
        public static void task4140(string l, string f) //2
        {
            Console.WriteLine("Меня зовут " + l + "," + f + " " + l);
        }
        public static void task2632(int cx ,int cy ,int r ,string fill)//3
        {
            Console.WriteLine(@"<circle cx=""{0}"" cy=""{1}"" r=""{2}"" fill=""{3}""/>",cx,cy,r,fill);
        }
        public static void task7474(int a , int b, int c) //4
        {

            Console.WriteLine(" Квадратное уравнение "+a+"* x*x + "+b+"* x + "+c+" = 0.");
            Console.WriteLine(@"Его дискриминант вычисляется по формуле: d = "+b+" *"+b+" - 4 *"+a+" *"+c+"");
        }
        public static double task4411(double x) // 5
        {
            double result;
            result = x + 7;
            return result;
        }
        public static double task2790(double x) // 6
        {
            double cR;
            double res;
            cR = x * Math.PI / 180;
            res = Math.Sqrt(1 - Math.Pow(Math.Sin(cR), 2));
            return res;
        }
        public static string Task5662(int a, int b, int c) //7
        {
            string d = "";
            double D;
            D = Math.Pow(b, 2)-4*a*c;
            string a1 = a.ToString();
            string b1 = b.ToString();
            string c1 = c.ToString();
            if (a == 0) { d="Данное уравнение не является квадратным"; }
            else if (D == 0) { d="Уравнение " + a1 + "x ^ 2 + " + b1 + "x + " + c1 + " = 0 имеет один корень"; }
            else if (D > 0) {d = "У уравнения" + a1 + "x ^ 2 + " + b1 + "x + " + c1 + " = 0 два вещественных корня"; }
            else if (D < 0) { d="Вещественных корней уравнения" + a1 + "x ^ 2 + " + b1 + "x + " + c1 +"= 0 нет"; }
            return d;
        }
        public static  long Task3669(int a, int b)//8
        {
            long res1 = 1; ;
            if (a > b)
            {
                while (b<=a)
                {
                    res1 = b * res1;
                    b++;
                }
                return res1;
            }
            else
            {
                while (b >= a)
                {
                    res1 = a * res1;
                    a++;
                }
                return res1;
            }
        }
        public static string Task1292(string a) //9
        {
            int i = 0;
            string res = "";
            string[] str =new string[] {"a","b","c","d","e","f","g","h" };
            while(i<str.Length)
            {
                res = res + str[i];
                if (str[i] == a) { return res; }
                i++;
            }
            return res;
        }
        public static double task3946(int[] arr) //10
        {
            int i = 0;
            double res = 0;
            if (arr.Length == 0) { return 0; }
            while (i<arr.Length)
            {
                res = arr[i] + res;
                i++;
            }
            res = res / arr.Length;
            return res;
        }
        //11

        public static void task9774(int x,int[] arr) // 13
        {
            int i = 0;
            while(i<arr.Length)
            {
                arr[i] = arr[i] * x;
                i++;
            }
        }
        public static bool task4847(int x, int y , int c) // 15
        {
            bool res = x == y || x == c || y == c;
            return res;
        }

    }
}
