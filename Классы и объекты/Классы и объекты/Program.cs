using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы_и_объекты
{
    class Date
    {
        enum Dimas { Января = 1, Ферваля, Марта, Апреля, Мая, Июня, Июля, Августа, Сентября, Октября, Ноября, Декабря };

        static int CountOfObjects = 0;
        private int DayValue;
        private int MonthValue;
        private int YearValue;
        //

        //
      
        //
        public void InfoOfDate(int i)
        {
            Console.WriteLine("[][][][][][][][][][][] Информация о объекте - " + (i+1));
            Console.WriteLine("[][][][][][][][][][][] {0} {1} {2}", this.day, (Dimas)this.month, this.year);

            Console.WriteLine();
        }
        //
        public int day
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
        /// <summary>
        /// /////////////////////////////
        /// </summary>
        private int month
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
        /// <summary>
        /// ///////////
        /// </summary>
        public int year
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

        public Date()
        {
            day = 22;
            month = 9;
            year = 2017;
            CountOfObjects++;
            Console.WriteLine("Количество объектов: " + CountOfObjects);
        }

        static Date()
        {

            Console.WriteLine("Статический конструктор");

        }

        public Date(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
            if (d < 1 || d > 31 || m < 1 || m > 12 || y < 1 || y > 9999)
            {
                Console.WriteLine("Некорректно введены данные");
            }
            CountOfObjects++;
            Console.WriteLine("Количество объектов: " + CountOfObjects);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            Date stud = (Date)obj;
            return (this.day == stud.day && this.month == stud.month && this.year == stud.year);
        }

        public override int GetHashCode()
        {
            int hash = 269;
            hash = (day < 0) ? 0 : day.GetHashCode();
            hash = (hash * 47) + year.GetHashCode();
            return hash;
        }
    }


    class MainClass
    {
        static void Main(string[] args)
        {
         
            int day; int month; int year;
            
            int size = 0;

            Console.WriteLine("[][][][][][][][][][][] 1 - Введите размер объекта");
            Console.WriteLine("[][][][][][][][][][][] 2 - Заполнить объект и печать");
            Console.WriteLine("[][][][][][][][][][][] 3 - Печать");
            Console.WriteLine("[][][][][][][][][][][] 4 - Сравнение двух объектов");
            Console.WriteLine("[][][][][][][][][][][] 5 - Вывод хеша");
            Console.WriteLine("[][][][][][][][][][][] 6 - Поиск по году");
            Console.WriteLine("[][][][][][][][][][][] 7 - Поиск по дню");

            size = Convert.ToInt32(Console.ReadLine());
            Date[] D = new Date[size];
          
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Введите день: ");
                day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите месяц: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите год: ");
                year = Convert.ToInt32(Console.ReadLine());

                D[i] = new Date(day, month, year);

            }
               
            for (int i = 0; i < size; i++)
            {
                D[i].InfoOfDate(i);

            }

            Console.WriteLine("Сравнение первого и второго объекта: " + D[0].Equals(D[1]));

            Console.WriteLine("Вывод кэша");
            for (int i = 0; i < size; i++)
            {
               Console.WriteLine(D[i].GetHashCode());

            }

            Console.WriteLine("Введите год");
            int ye;

            ye = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                if (ye == D[i].year)
                {
                    D[i].InfoOfDate(i);
                }
            }


            Console.WriteLine("Введите день");
            int da;

            da = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                if (da == D[i].day)
                {
                    D[i].InfoOfDate(i);
                }
            }

            Console.ReadKey();
            var user = new { Name = "Tom", Age = 34 };
            var student = new { Name = "Alice", Age = 21 };
            var manager = new { Name = "Bob", Age = 26, Company = "Microsoft" };

            Console.WriteLine(user.GetType().Name); // <>f__AnonymousType0'2
            Console.WriteLine(student.GetType().Name); // <>f__AnonymousType0'2
            Console.WriteLine(manager.GetType().Name); // <>f__AnonymousType1'3
        }
    }

}