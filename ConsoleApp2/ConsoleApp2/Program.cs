using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание");
            Task1();
            Console.WriteLine("Второе задание");
            Task2();
            Console.WriteLine("Третье задание");
            Task3();
            Console.WriteLine("4 задание");
            Task4();
            Console.WriteLine("5 задание");
            Console.WriteLine("Введите массив");
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            var tup =  Task5(num, s);
            Console.WriteLine("Минимальный элемент " + tup.Item1 + " Максимальный " + tup.Item2 + " Их сумма " + tup.Item3 + " Первая Буква "+ tup.Item4 );
        }



        static void Task1()
        {
            Console.WriteLine("Инициализания всех примитивных типов");
            sbyte Sbyte = 1;
            short Short = 2;
            int Int = 3;
            long Long = 4;
            System.Byte Byte = 4;
            ushort Ushort = 5;
            ulong Ulong = 6;
            char Char = 's';
            bool Bool = false;
            float FLOAT = 31;
            double Double = 12312.432;
            decimal Decimal = 123;

            Int16 i16 = 32; ;
            Int32 i32 = 5;
            Int64 i64 = i32;
            Single s = i32;
            Single s2 = i64;
            Double B = i32;
            //Неявное преобразование


            i32 = (Int32)i16;
            i64 = (Int64)i32;
            i32 = (Int32)s;
            i64 = (Int64)s;
            //Явное преобразование

            Object o = Int;
            byte m = (byte)(int)o;

            //Упаковка и распаковка

            var mas1 = new[] { 2, 4, 5, 6, 7, 3 };
            Console.WriteLine(mas1.GetType());

            var mas2 = new[] { 2, 2.4, 3.55, 6, 7, 3 };
            Console.WriteLine(mas2.GetType());

            var mas3 = new[] { "dsgddddf", "sggff"};
            Console.WriteLine(mas3.GetType());

            // Неявное типизированная переменая

            int? x1 = null;
            int? x2 = null;
            Console.WriteLine(x1 == x2);
             x1 = 43;
            Console.WriteLine((int)x1);

            //Type Nullable

        }

        static void Task2()
        {
            Console.WriteLine("Строки----------");
            string s1 = "string1";
            string s2 = "string2";
            string s3 = "string3";
            string s4 = "";
            Console.WriteLine("Строки равны: " + (s1 == s2));
            s4 = s1 + s2 + s3;
            Console.WriteLine("Контантенация строк: " +s4);
            s4 = s2;
            Console.WriteLine("Копирование строки s2 в s4: " + s4);
            Console.WriteLine();
 
            string text = "this is a text.New string";

            char[] delims = ".,:;!?\n\xD\xA\' ' ".ToCharArray();
            string[] words = text.Split(delims);

            foreach (string word in words)
                Console.WriteLine(word);
            Console.WriteLine();
            Console.WriteLine("Четверное слово в нашей строке " + words[3]);

            string s5 = s1.Substring(2, 4);
            Console.WriteLine("Подстрока s5 и вставка ее в s1 в 3 позицию: " + s1.Insert(2,s5));

            StringBuilder sb = new StringBuilder();
            sb.Append("asdas");
            sb.Insert(0, "asdasdsa");
            Console.WriteLine(sb);
            ////////////////////////////////////////////

 
        }

        static void Task3()
        {
            int[][] a = { new int[3] { 1, 2, 3 }, new int[3] { 2, 3, 3 }, new int[3] { 345, 456, 46 } };
            foreach (int[] x in a)
            {
                foreach (int b in x)
                    Console.Write("\t" + b);
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            string[] str = new string[] { "11111111", "2222222222", "333333333" };
            foreach (string b in str)
                Console.WriteLine("\t" + b);
 
                Console.WriteLine(str.Length + " -- Length of array");

            Console.WriteLine("Введите значение");
            string value = Console.ReadLine();

            Console.WriteLine("Введите позицию");
            int  num = int.Parse(Console.ReadLine());

            for (int i = 0; i < str.Length; i++)
            {
                if (num == i)
                {
                    str[num] = value;
              
                }
                Console.WriteLine(str[i]);
            }


            double[][] c = { new double[1], new double[2], new double[3] };

            int n = 1;
            int k = 7;
            int[][] с = new int[5][];
            for (int i = 0; i < a.Length; i++)
            {
                с[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    с[i][j] = k;
                    Console.Write("{0} ", с[i][j]);
                }
                Console.WriteLine();
                k--;
                n++;
            }

            var varstr1 = new[] { "asgfdg", "DSFDFDSF"};
       
        }

        static void Task4()
        {
            (int first, string second, char third, string four, ulong five) tuple = (123, "sdfsg", 'x', "four", 123) ;
            Console.Write(tuple.first);
            Console.WriteLine(tuple.second + " " + tuple.third + " " + tuple.four + " " + tuple.five);
            ///////

            (int first1, string second2, char third3, string four4, ulong five5) = tuple;
            (int first, string second, char third, string four, ulong five) tuple2 = (123, "sdfsg", 'x', "four", 123);
            Console.WriteLine(first1);

            tuple.CompareTo(tuple2);
        }

        static Tuple<int, int, int, string> Task5(int[] num, string s)
        {
            int min = num[0];
            int max = num[0];
           
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
            }

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
            }

            int sum = max + min;
            string firstLetter = s.Substring(0, 1);

            return Tuple.Create<int, int, int, string>(min, max, sum, firstLetter);
        }

    }
}
