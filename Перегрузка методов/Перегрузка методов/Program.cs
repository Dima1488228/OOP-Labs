using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_методов
{
  

class Program
    {

       


        static void Main(string[] args)
        {
            string c123 = " lvfvf ";
            c123.Dots();
            bool compare;
            Set s1 = new Set(3, 44, 5, 7, 8);// множество 
            Set s2 = new Set(3, 44, 5, 7, 8);
            Set s3;
            s1.Output();
            s1 = s1 - 3; //delete of element
            Console.WriteLine();
            Console.Write('{');
            for (int i = 0; i < s1.Elements.Length-1; i++)
            {
                Console.Write(s1.Elements[i].ToString() + ' '); //вывод с1
            }
            Console.Write('}');
            Console.WriteLine();
            s3 = s1 * s2; //пересечение элементов 
            s3.Output();
            Console.WriteLine();
            Set s5 = new Set(10, 44, 5, 7, 8);
            Set s4 = new Set(1, 2, 9, 7, 9);
            compare = s4 < s5; //сравнение множеств
            Console.WriteLine("Comparsion s1 and s2:  " + compare);
            compare = s4 > s5; //сравнение подмножеств
            Console.WriteLine("subset s1 and s2:  " + compare);

            String st = "Точка";
            Console.WriteLine(st.Dots());// метод расширеня мой

            Console.WriteLine(MathObject.Min(s5.Elements));
            Console.WriteLine(MathObject.Max(s5.Elements));
            Console.WriteLine(MathObject.Count(s5.Elements));


            s3 = s1 & s2;//сложение 
            s3.Output();

        }
    }


    class Set
    {

        Owner Own = new Owner(123123, "Dima", "BGTU");
        Date segodnya = new Date(18, 10, 2017);

        public class Date
        {

            private int DayValue;
            private int MonthValue;
            private int YearValue;

            public Date(int day, int month, int year)
            {
                this.Day = day;
                this.Month = month;
                this.Year = year;
            }

            public int Day // свойства для дня мес и года
            {
                get
                {
                    return DayValue;
                }
                set
                {

                    DayValue = value;

                }
            }

            private int Month
            {
                get
                {
                    return MonthValue;
                }
                set
                {
                    MonthValue = value;
                }
            }

            public int Year
            {
                get
                {
                    return YearValue;
                }
                set
                {
                    YearValue = value;
                }
            }

        }

        public int[] Elements = new int[5];

        public int this[int index] // индексатор чтобы представлять объект как массив элементов
        {
            get
            {

                return Elements[index];
            }
            set
            {
                for (int i = 0; i < Elements.Length; i++)
                {
                    if (Elements[i] == value) // value - слово которое мы вводим(ключевое)
                    {
                        return;
                    }
                }
                Elements[index] = value;
            }

        }
       
        public Set(params int[] arr)//конструкотор калсса сет
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Elements[i] = arr[i];
            }
        }

        public void Output()
        {
            int n = 5;
            Console.Write('{');
            for (int i = 0; i < Elements.Length; i++)
            {
                if (Elements[i] == 0)
                {
                    n = i;
                    break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(Elements[i].ToString() + ' ');
            }
            Console.Write('}');
        }


        public static Set operator -(Set s, int n) //перегрузка оператора -
        {
            for (int i = 0; i < s.Elements.Length; i++)
            {
                if (s[i] == n) // скрываем n элемент в множестве 
                {
                    for (int j = i; j < s.Elements.Length - 1; j++)
                    {
                        s.Elements[j] = s.Elements[j + 1];
                    }
                    break;
                }
            }
            return s;
        }

        public static Set operator *(Set s1, Set s2) // перегрузка оператора *
        {
            Set s3 = new Set();
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (s1[i] == s2[j]) //элементы с1 по очереди сравниваются с элемеентами с2 
                    {
                        s3[index] = s1[i]; //выводим подобные элементы
                        index++;
                    }
                }

            }
            return s3;
        }

        public static bool operator > (Set s1, Set s2)//перегрузка оператора >
        {
            bool compare = false;
            for (int i = 1; i < 5; i++)
            {
                for (int j  = 1; j < 5; j++)
                {
                    if (s1[i] == s2[j] && s1[i-1] == s2[j-1] )// сравнение подмножеств. 
                    {
                        compare = true;
                        return compare;
                    }
                }
            }
            return compare;
        }

        public static bool operator < (Set s1, Set s2) // перегрузка оператора < 
        {
            bool compare = true;
            for (int i = 0; i < 5; i++)
            {
                if (s1[i] != s2[i])// сравнение множеств.
                {
                    compare = false;
                }
            }
            return compare;
        }


        public static Set operator &(Set s1, Set s2)// перегрузка оператора & 
        {
            Set s3 = new Set();
            for (int i = 0; i < s1.Elements.Length; i++)
            {
                s3.Elements[i] = s1.Elements[i] + s2.Elements[i]; // сложение элементов множества 
            }
            return s3;
        }

    }

    static class MathObject
    {
        public static int Min(params int[] arr)
        {
            Array.Sort(arr);
            return arr[0];
        }

        public static int Max(params int[] arr)
        {
            Array.Sort(arr);
            return arr[arr.Length-1];
        }

        public static int Count(params int[] arr)
        {
        
            return arr.Length;
        }
    }

}
