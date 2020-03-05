using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    class Program
    {
        class Student // клас студент
        {
            public string family; // прізвище
            public string name; // ім'я
            public int year; // рік народження
            public int gruppa; // група
            public void Show()
            {
                 Console.WriteLine("Вивід студентів:");
                Console.WriteLine("прізвище " + " " + family + "\n ім'я студента "
                + " " + name + "\n рік народження " + " " + year + " \n навчальна група " + " "
               + gruppa);
                Console.ReadKey();
            }
            public void Input()
            {
                Console.WriteLine("Введення студентів:");
                Console.WriteLine("Введіть прізвище :");
                family = Console.ReadLine();
                Console.WriteLine("Введіть ім'я студента ");
                name = Console.ReadLine();
                Console.WriteLine("Введіть рік народження ");
                year = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть навчальну групу ");
                gruppa = int.Parse(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();
            }
            static void Main(string[] args)// головна функція
            {
                string str = "да";
                while (str == "да")
                {
                    Student s = new Student();// об’єкт
                    Console.WriteLine("\n\n\n\n\n\n\n\n " + " Програма Студент");
                    Console.WriteLine("\n Виконав Прізвище ");
                    Console.ReadKey();
                    Console.Clear();
                    s = new Student();
                    s.Input();
                    s.Show();
                    Console.WriteLine("\n повторити рішення (да/ні)");
                    str = Console.ReadLine();
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
