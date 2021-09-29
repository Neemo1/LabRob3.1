using System;
using System.IO;

namespace LabRob3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; // для того, щоб консоль розпізнавала українські літери
            string s;
            double x, y;
            StreamWriter f = new StreamWriter("Lab3.res"); // виведення значень
            StreamReader f1 = new StreamReader("Lab3.txt"); // введення значень
            f.WriteLine("Таблиця значень\n+-------------------------------------+\n+     Аргумент    +   Функція         +\n+-------------------------------------+");
        metka: s = f1.ReadLine();
            if (s == null) goto metka1;
            x = Convert.ToDouble(s);
            y = Math.Log(Math.PI*Math.Sqrt(Math.Pow(x, 3) + Math.Pow(x, 2)));
            f.WriteLine("+  X = {0:f3} + Y = {1:e3} +\n", x, y);
            goto metka;
        metka1: f.WriteLine("+-------------------------------------+\nСклав Кобрін Ілля Павлович {0} \n", s);
            f.Close();
            f1.Close();
        }
    }
}
