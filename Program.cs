using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    internal class Program
    {
        //---СТРУКТУРА КНИГА---

        //struct Book
        //{
        //    public string name;//название
        //    public string author;//автор
        //    public ushort year; //год
        //    public string publisher; // издатель
        //    public bool censorship; // цензура
        //    // метод
        //    public void PrintInfo() //вывод информации о структуре
        //    {
        //        Console.Write($"Информация о книге:\nНазвание {name}\nАвтор {author}\nГод {year}\nИздатель {publisher}\nЦензура {censorship}");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Console.Clear();
        //    Book book1;
        //    book1.name = "1-ОПГ";
        //    book1.author = "Настасетта-Дарсия Абдутрух";
        //    book1.year = 2025;
        //    book1.publisher = "МЯУ";
        //    book1.censorship = true;
        //    book1.PrintInfo();
        //    Console.ReadKey();
        //}


        //---СТРУКТУРА РЮКЗАК---

        //struct BackPack
        //{
        //    public string brand; //брэнд
        //    public string type;//тип
        //    public ushort straps;//кол-во лямок
        //    public string color; //цвет
        //    public string clasp; //тип застежки
        //    public ushort pockets;//кол-во карманов
        //    public string size;//размер
        //    // метод
        //    public void PrintInfo() //вывод информации о структуре
        //    {
        //        Console.Write($"Информация о сумке:\nБрэнд: {brand}\nТип: {type}\nКоличество лямок: {straps}\nЦвет: {color}\nТип застежки: {clasp}\nКоличество карманов: {pockets}\nРазмер: {size}");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Console.Clear();
        //    BackPack bag;
        //    bag.brand = "YkycNcykY";
        //    bag.type = "Походный рюкзак";
        //    bag.straps = 3;
        //    bag.color = "Мультикам";
        //    bag.clasp = "Молния и липучка";
        //    bag.pockets = 10;
        //    bag.size = "Большой";
        //    bag.PrintInfo();
        //    Console.ReadKey();
        //}


        //---СТРУКТУРА ТРЕУГОЛЬНИК--- (1способ обхода приват)

        //struct Traingle
        //{
        //    public ushort sizeA;
        //    public ushort sizeB;
        //    public ushort sizeC;

        //    //1 способ обхода модификатора private (Вызов приватного метода из публичного)
        //    public void PrintInfo()
        //    {
        //        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        //        Console.ForegroundColor = ConsoleColor.White;
        //        Console.WriteLine("---Информация о треугольнике---");
        //        Console.Write($"Длины сторон\nСторона A: {sizeA}\nСторона B: {sizeB}\nСторона C: {sizeC}");
        //        Console.WriteLine($"\nПлощадь: {Area(sizeA, sizeB, sizeC)}");
        //    }
        //    double Area(ushort sizeA, ushort sizeB, ushort sizeC)
        //    {
        //        double semiperimeter = (sizeA + sizeB + sizeC) / 2; //полупериметр
        //        double temp = semiperimeter * (semiperimeter - sizeA) * (semiperimeter - sizeB) * (semiperimeter - sizeC);
        //        temp = Math.Round(Math.Sqrt(temp), 4);
        //        return temp;
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Console.Clear();
        //    Traingle obj;
        //    obj.sizeA = 5;
        //    obj.sizeB = 5;
        //    obj.sizeC = 5;
        //    obj.PrintInfo();

        //    //Console.ReadKey();
        //}

        //(2 способ обхода приват)

        struct UserInfo
        {
            string name;
            string login;
            string password;
            string email;
            //2 вариант
            //public UserInfo(string name, string login, string password, string email)
            //{
            //    this.name = name;
            //    this.login = login;
            //    this.password = password;
            //    this.email = email;
            //}
            //1 вариант
            public UserInfo(string _name, string _login, string _password, string _email)
            {
                name = _name;
                login = _login;
                password = _password;
                email = _email;
                PrintInfo();
            }
            void PrintInfo() //вывод информации о структуре
            {
                Console.Write($"---Информация о пользователе---\nИмя: {name}\nЛогин: {login}\nПароль: {password}\nПочта: {email}");
            }
        }
        static UserInfo CreateUserInfoForPrint()
        {
            Console.Write("Введите имя нового пользователя: ");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректное значение");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Попробуйте еще раз.");
                name = Console.ReadLine();
            }
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            while (string.IsNullOrEmpty(login))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректное значение");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Попробуйте еще раз.");
                login = Console.ReadLine();
            }
            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();
            while (string.IsNullOrEmpty(password))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректное значение");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Попробуйте еще раз.");
                password = Console.ReadLine();
            }
            Console.Write("Введите почта: ");
            string email = Console.ReadLine();
            while (string.IsNullOrEmpty(email))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректное значение");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Попробуйте еще раз.");
                email = Console.ReadLine();
            }
            return new UserInfo(name, login, password, email);
        }
        static void Main(string[] args)
        {
            Console.Clear();
            //UserInfo user = new UserInfo("Нася Вохмяша", "Vokhmyasha", "ZXCqwerty", "nasya@gmail.ru");
            UserInfo user = CreateUserInfoForPrint();
            Console.ReadKey();
        }

        //struct Traingle
        //{
        //    int sizeA;
        //    int sizeB;
        //    int sizeC;

        //    public Traingle(int sizeA, int sizeB, int sizeC)
        //    {
        //        this.sizeA = sizeA;
        //        this.sizeB = sizeB;
        //        this.sizeC = sizeC;
        //        PrintInfo();
        //    }
        //    void PrintInfo() //вывод информации о структуре
        //    {
        //        Console.Write($"Длины сторон\nСторона A: {sizeA}\nСторона B: {sizeB}\nСторона C: {sizeC}");
        //        Console.WriteLine($"\nПлощадь: {Area(sizeA, sizeB, sizeC)}");
        //    }
        //    double Area(int sizeA, int sizeB, int sizeC)
        //    {
        //        double semiperimeter = (sizeA + sizeB + sizeC) / 2; //полупериметр
        //        double temp = semiperimeter * (semiperimeter - sizeA) * (semiperimeter - sizeB) * (semiperimeter - sizeC);
        //        temp = Math.Round(Math.Sqrt(temp), 4);
        //        return temp;
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Console.Clear();
        //    Console.Write("Введите сторону А: ");
        //    int sizeA = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Введите сторону B: ");
        //    int sizeB = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Введите сторону C: ");
        //    int sizeC = Convert.ToInt32(Console.ReadLine());

        //    Console.ReadKey();
        //    }
    }
}
