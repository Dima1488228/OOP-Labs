using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class Program
    {

        static void Main(string[] args)
        {
            Printer print = new Printer();
            Plant p1 = new Rose(25, "red") as Rose;
            print.IAmPrinting(p1);
            Console.WriteLine("\n");
              Plant p2 = new Gladiolus(100, "green");
           print.IAmPrinting(p2);
            Plant p3 = new Cactus(1231, "black");

            Plant[] arr = new Plant[2];
            arr[0] = p1;
            arr[1] = p2

            foreach (Plant item in arr)
            {
                Console.WriteLine("----------------------------------------------------------------");
               print.IAmPrinting(item);

            }


            Container b = new Container();
            b.byk = new List<Plant>();
            b.Add(p3);
            b.Add(p2);
            b.Add(p1);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            b.Info();

            b.PriceOfFlowers();

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------");
            Controller cont = new Controller();
             cont.Search(b.byk);
            cont.PriceSorting(b.byk);
            b.Info();
        }

    }
        interface IPlant
        {
            void Pour();
            void Cut();
            void Sell();
            String ToString();
        }


       public abstract class Plant : Printer
        {
         protected string type;
        protected string location;
        protected int price;
        protected string color;
        public int Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }
    }

       public abstract class Flower : Plant, IPlant
        {
  
            public abstract void Pour();
            public abstract void Cut();
            public abstract void Sell();
            public Flower()
        {
            type = "Цветок";
            location = "Магазин";
        }
        }

    public class Rose : Flower
        {
            public Rose(int pric, string col)
            {
            Color = col;
            Price = pric;
            }
            public override void Pour() {
                Console.WriteLine("Вы полили розу");
            }
            public override void Cut()
            {
                Console.WriteLine("Вы срезали розу");
            }
            public override void Sell()
            {
                Console.WriteLine("Вы продали розу");
            }
        public override string ToString()
        {
            return ("Информация о розах\n type -"+type+" \n location - "+location+" \n color - "+color+" \n price - "+price+" ");
        }

    }

    public class Gladiolus : Flower
    {
        public Gladiolus(int pric, string col)
        {
            color = col;
            price = pric;
        }
        public override void Pour()
        {
            Console.WriteLine("Вы полили gladiolus");
        }
        public override void Cut()
        {
            Console.WriteLine("Вы срезали gladiolus");
        }
        public override void Sell()
        {
            Console.WriteLine("Вы продали gladiolus");
        }

        public override string ToString()
        {
            return ("Информация о gladiolus\n type -" + type + " \n location - " + location + " \n color - " + color + " \n price - " + price + " ");
        }

    }

    public class Cactus : Flower
    {
        public Cactus(int pric, string col)
        {
            color = col;
            price = pric;
        }
        public override void Pour()
        {
            Console.WriteLine("Вы полили Cactus");
        }
        public override void Cut()
        {
            Console.WriteLine("Вы срезали Cactus");
        }
        public override void Sell()
        {
            Console.WriteLine("Вы продали Cactus");
        }

        public override string ToString()
        {
            return ("Информация о Cactus\n type -" + type + " \n location - " + location + " \n color - " + color + " \n price - " + price + " ");
        }

    }

    public partial class Paper
    {
        public override bool Equals(object obj)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 123;
        }



        public Paper()
        {
            Console.WriteLine("Просто бумага)00)");
        }
    }

    public sealed class Bush : Plant, IPlant
    {
        public Bush (string typ, string loc)
        {
            location = loc;
            type = typ;
        }
        public  void Pour()
        {
            Console.WriteLine("Вы полили куст");
        }
        public  void Cut()
        {
            Console.WriteLine("Вы срезали куст");
        }
        public  void Sell()
        {
            Console.WriteLine("Вы продали куст");
        }

        public override string ToString()
        {
            return ("Информация о Bush\n type -" + type + " \n location - " + location + " \n color - \n");
        }


    }

    public class Container
    {
        public List<Plant> byk;
        protected int priceOfFlowers { get; set; }

        public List<Plant> Add(Plant p)
        {
            byk.Add(p);
            return byk;
        }

        public  void Info()
        {
            foreach (Plant pp in byk)
            {
                Console.WriteLine(pp.ToString());

            }
        }

        public void PriceOfFlowers()
        {
            foreach (Plant pp in byk)
            {
                priceOfFlowers += pp.Price;
            }
            Console.WriteLine("Price -- " + priceOfFlowers + "$");
        }



    }

    enum blabla {
        Rodion, Bydai, Buiko,
    }

    struct prekol
    {
        int dsdfghhfd;
        string fd;
    }

    public class Controller : Container
    {


        public void Search(List<Plant> byk)
        {
            string color;
            Console.WriteLine("Input the color");
            color = Console.ReadLine();

            foreach (Plant pp in byk)
            {
                if (pp.Color == color)
                {
                    Console.WriteLine("Найдено совпадение");
                    Printer printer = new Printer();
                    printer.IAmPrinting(pp);
                }
            }

            return ;
        }

        public List<Plant> PriceSorting(List<Plant> byk)
        {
         
            for (int i = 0; i < byk.Count - 1; i++)
            {
                for (int j = i + 1; j < byk.Count; j++)
                {
                    if (byk[i].Price > byk[j].Price)
                    {
                       var temp = byk[i].Price;
                        byk[i].Price = byk[j].Price;
                        byk[j].Price = temp;
                    }
                }
            }

            return byk;
        }
    }


    public class Printer
    {
   
        public void IAmPrinting(Plant p)
        {
            Console.WriteLine("Type: " + p.GetType());
            Console.WriteLine(p.ToString());
        }
    }

}
