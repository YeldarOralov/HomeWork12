using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork12
{
    class Program
    {
        static void Main(string[] args)
        {
            //В файле записана непустая последовательность целых чисел, являющихся числами Фибоначчи. Приписать еще столько же чисел этой последовательности.
            List<int> fibonacci = new List<int>();
            using (StreamReader sr = new StreamReader("E:\\1.txt", Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    fibonacci.Add(int.Parse(line));
                }
            }
            foreach(int x in fibonacci)
            {
                Console.WriteLine(x);
            }
            for(int i = 0, j = fibonacci.Count; i < j; i++)
            {
                fibonacci.Add(fibonacci[fibonacci.Count - 2] + fibonacci[fibonacci.Count-1]);
            }

            foreach (int x in fibonacci)
            {
                Console.WriteLine(x);
            }


            //Сложить два целых числа А и В.
            int sumOfNumbers = 0;
            using (StreamReader sr = new StreamReader("E:\\INPUT.txt", Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sumOfNumbers += int.Parse(line);
                }
            }
            using (StreamWriter sw = new StreamWriter("E:\\OUTPUT.txt", true, Encoding.Default))
            {
                sw.WriteLine(sumOfNumbers);
            }
            Console.Read();
        }
    }
}
