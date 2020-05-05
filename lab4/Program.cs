using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee() { name = "Вася Пупкин", company = "Яблоко", hireDate = new DateTime(2015, 7, 12), salesSum = 5623.5m, currency = '€' };
            employees[1] = new Employee() { name = "Анатолий Едкий", company = "ООО Груша", hireDate = new DateTime(2020, 2, 29), salesSum = 950m, currency = '€' };
            employees[2] = new Employee() { name = "Геннадий Ковбойский", company = "Телемагазин", hireDate = new DateTime(2014, 5, 1), salesSum = 19000500m, currency = '₽' };
            employees[3] = new Employee() { name = "Екатерина Змеиная", company = "Яд и копыта", hireDate = new DateTime(2011, 12, 1), salesSum = 2140954352.99m, currency = '₽' };
            Console.OutputEncoding = Encoding.Unicode;
            for (int i = 0; i < 4; i++)
            {
                employees[i].Write();

            }

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            String symblos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ";
            for (int i = 0; i < 100; i++)
            {
                int length = rnd.Next(20, 101);
                string temp = new String(Enumerable.Repeat(symblos, length).Select(s => s[rnd.Next(symblos.Length)]).ToArray());
                sb.Append(temp);
            }
            String result = sb.ToString();
            Console.WriteLine(result);
        }

    }

    public class Employee
    {
        public String name;
        public String company;
        public DateTime hireDate;
        public Decimal salesSum;
        public char currency;

        public void Write()
        {
            Console.WriteLine("{0,25} | {1,25} | {2:d} | {3}{4}", name, $"\"{company}\"", hireDate, salesSum, currency);
        }
    }
}
