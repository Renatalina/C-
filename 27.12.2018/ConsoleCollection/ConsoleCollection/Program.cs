using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace ConsoleCollection
{
    class Car
    {
        public string name { get; set; }

    }
    /*
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            //list.Add(78.23);
            list.Add(78);
            WriteLine(list[0]);


            object obj = 45;//boxing вот это называет упаковка 
                            //обратный процесс называется распаковка unboxing
            Car car = new Car();

            Dictionary<int, List<Car>> cars = new Dictionary<int,List<Car>>();
            cars.Add(2, new List <Car>());
            //cars.Add(3, car);
            cars[4].Add(new Car { name = "Mersedec" });
            cars[5].Add(new Car { name = "Volvo" });
            cars[6].Add(new Car { name = "BMV" });

            //if(cars.Contains(new KeyValuePair<int, Car>(2,car)))
            //{

            //}
            foreach (int key in cars.Keys)
            {
                WriteLine($"\t{key}");
                    
                    foreach(Car item in cars[key])
                    {
                    WriteLine(item.name);
                    }
           }




                    
            int num = (int)obj;//unboxing; для распаковки нужно сделать явное приведение типов


            ArrayList arrayList = new ArrayList();
            arrayList.Add(12);//boxing упаковка 

            short sh = (short)arrayList[0];

            //boxing 


            int n = Convert.ToInt32(arrayList[0]); //unboxing 


            foreach(int iteam in arrayList)
            {
                WriteLine(iteam.ToString());
            }
            Console.ReadKey();
        }

    }*/
    /// <summary>
    /// ///////////////////////////////////////////////////////////////
    /// </summary>
    /// <typeparam name=/// "T"></typeparam>
    /*
    public class Point2D<T>
    {
        //параметр типа используется для задания типа свойства
        public T X { get; set; }
        public T Y { get; set; }

        //параметр типа используется для задания типов параметров метода
        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }
        public Point2D()
        {
            X = default(T);
            Y = default(T);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //тестирование обобщенного класса - точки в 2D
            Point2D<int> p1 = new Point2D<int>();
            WriteLine($"x = {p1.X} y = {p1.Y}");
            WriteLine(typeof(Point2D<int>));

            Point2D<double> p2 = new Point2D<double>(10.5, 20.5);
            WriteLine($"\nx = {p2.X} y = {p2.Y}");
            WriteLine(typeof(Point2D<double>));
        }
    }*/

    /*
    class Myclass
{
    public void Swap<T>(ref T n1, ref T  n2) where T:struct
    {
        T tmp = n1;
        n1 = n2;
        n2 = tmp;
    }
}
class A<T>
{
    public class Inner
    {
    }
}

class B<T>
{
    //вложенный класс имеет собственный список параметров типа
    public class Inner<U>
    {
        public T P1 { get; set; }
    }
}
class Program
{
    static void Main(string[] args)
    {
        //для использования вложенного класса 
        //необходимо указать реальный тип вместо параметра типа внешнего класса
        A<int>.Inner a = new A<int>.Inner();
        WriteLine(a);
        A<double>.Inner a1 = new A<double>.Inner();
        WriteLine(a1);

        //для использования вложенного класса 
        //необходимо указать реальный тип вместо параметра типа вложенного класса
        B<int>.Inner<string> b = new B<int>.Inner<string>();
        WriteLine(b);
    }
}*/
    /*

        class Program
        {
            static T MaxElement<T>(T[] arr) where T : IComparable<T>
            {
                T max = arr[0];
                foreach (T item in arr)
                {
                    if (item.CompareTo(max) > 0)
                        max = item;
                }
                return max;
            }
            static void Main(string[] args)
            {
                int[] arrInt = new int[] { 22, 63, 718, 14, 5 };

                //реальный тип для параметра типа указывается явно
                WriteLine($"Максимальный элемент: {MaxElement<int>(arrInt)}");

                double[] arrDouble = new double[] { 45.62, 77.354, 18.48, 11.3 };

                //реальный тип определяется по типу переданного массива
                WriteLine($"Максимальный элемент: {MaxElement(arrDouble)}");


            }
        }*/

    class Program
    {
        //Подсчитать, сколько раз каждое слово встречается в заданном тексте. 
        //Результат записать в коллекцию Dictionary<TKey, TValue>

        static void Main(string[] args)
        {


            string str = "Cupertino, California — Apple today announced iPhone Xs and iPhone Xs Max, the most " +
                "advanced iPhones ever, taking the vision for the future of the smartphone to a new level. " +
                "The 5.8-inch iPhone Xs and 6.5-inch iPhone Xs Max feature stunning Super Retina displays, " +
                "a faster and improved dual camera system that offers breakthrough photo and video features, " +
                "the first 7-nanometer chip in a smartphone — the A12 Bionic chip with next-generation Neural " +
                "Engine — faster Face ID, wider stereo sound, a beautiful new gold finish and introduce Dual SIM " +
                "to iPhone. iPhone Xs and iPhone Xs Max will be available for pre-order beginning Friday," +
                " September 14 and in stores beginning Friday, September 21.";

            Dictionary<string, int> D= new Dictionary<string, int>();
            string s;
            foreach (string iteam in str.Split(' ')) 
            {
                if(D.ContainsKey(iteam))
                {
                    D[iteam]++;
                }
                else
                {
                    D.Add(iteam, 1);
                }


            }

            foreach(KeyValuePair<string,int> item in D)
            {
                WriteLine($"{item.Key} Count {item.Value}");
            }

        }
    }
}
