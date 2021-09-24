using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_file2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("homework a.1.1.a");
            int n = Convert.ToInt32(Console.ReadLine());//n-количество секунд
            int hour = (n / 3600) % 24;// количество часов, прошедших с начала суток
            Console.WriteLine("C начала суток прошло"+hour+"часов");

            Console.WriteLine("a.1.1.b");
            int minut = (n / 60 - hour) % 60;//количество минут,прошедших с начала очередного часа
            Console.WriteLine("С начала очередного часа прошло"+minut+"минут");

            Console.WriteLine("a.1.1.c");
            int secund = (n - minut) % 60;//количество секунд,прошедших с очередной минуты
            Console.WriteLine("С начала очередной минуты прошло"+secund+"секунд");
            Console.ReadLine();

            Console.WriteLine("homework a.1.2");
            int a = 543;//длина прямоугольника
            int b = 130;//ширина прямоугольника
            double squares = (a * b) / (b * b);//количество квадратов
            Console.WriteLine("Столько квадратов можно отрезать от прямоугольника:"+squares);
            Console.ReadLine();

            Console.WriteLine("homework a.1.3");
            int x = Convert.ToInt32(Console.ReadLine());//номер последующего после n месяца
            n = Convert.ToInt32(Console.ReadLine());//количество месяцев,прошедших с начала 2020 года
            if (x < 0 && x > 13)
            {
                Console.WriteLine("Не существует такого месяца");
            }
            else
            {
                x = (n + 1) % 12;
                Console.WriteLine("Месяцев, прошедших с начала 2020 года"+x);
            }

            Console.WriteLine("homework 1.4");
            int number = Convert.ToInt32(Console.ReadLine());//двузначное число
            int tens = 0;//количество десятков в числе
            int ones = 0;//количество единиц в числе
            int summOfNumbers = 0;//сумма цифр
            int productOfNumbers = 0;//произведение цифр
            while (number >= 10 && number <= 99)
            {
                tens = number / 10;
                ones = number % 10;
                summOfNumbers = tens + ones;
                productOfNumbers = tens * ones;
            }
            Console.WriteLine("Кол-во единиц = " + ones + " Кол-во десятков = " + tens + " Сумма цифр = " + summOfNumbers + " произведение чисел = " + productOfNumbers);

            Console.WriteLine("homework a.1.5");
            number = Convert.ToInt32(Console.ReadLine());//трехзначное число
            int hundreds = (number / 100);//количество сотен
            int twoLastsNumbers = number % 100;//два последних числа
            Console.WriteLine($"Полученное число: {twoLastsNumbers}{hundreds}");

            Console.WriteLine("homework a.1.6");
            int z = 237;//полученное в итоге число
            int lastNumber = z / 100;//две последние цифры трехзначного числа х
            int y = 237 % 100;//первая цифра трехзначного числа х
            Console.WriteLine("x=" + y + lastNumber);

            Console.WriteLine("homework а.1.7");
            int a1 = Convert.ToInt32(Console.ReadLine());//число единиц в первом числе
            int a2 = Convert.ToInt32(Console.ReadLine());//число десятков в первом числе
            int b1 = Convert.ToInt32(Console.ReadLine());//число единиц в первом числе
            int b2 = Convert.ToInt32(Console.ReadLine());//число десятков в первом числе
            int summa = a2 + b2 + a1 + b1;//сумма всех чисел
            tens = (a2 + b1 + a1 + b2) / 10;//первая цифра в полученном числе
            ones = (a1 + a2 + b1 + b2) % 10;//вторая цифра в полученном числе
            Console.WriteLine("Число десятков:" + tens, "Число единиц:" + ones);

            Console.WriteLine("homework a.1.8");
            int k = Convert.ToInt32(Console.ReadLine());
            a = (k / 3) % 10;//к-я цифра в а)
            b = (k + 1) / 30;//к-я цифра в с)
            Console.WriteLine($"a){a}\nb)1\nc){b}");

            Console.WriteLine("homework a.1.9");
            bool A = true;//истина
            bool B = false;//ложь
            bool C = false;//ложь
            bool first = A || B;
            bool second = A && B;
            bool third = B || C;
            Console.WriteLine($"a) {first}\n b){second}  \n c) {third}");

            Console.WriteLine("homework a.1.10");
            bool X = true;
            bool Y = true;
            bool Z = true;
            first = !(X || Y) && (!X || !Z);
            second = !(!X && Y) || (X && !Z);
            third = X || !Y && !(X || !Z);
            Console.WriteLine($"При X,Y,Z-правда:a){first}\n b){second}\n c){third}");
            X = false;
            Y = false;
            Z = false;
            first = first = !(X || Y) && (!X || !Z);
            second = !(!X && Y) || (X && !Z);
            third = X || !Y && !(X || !Z);
            Console.WriteLine($"При X,Y,Z-ложь: a){first}\n b){second}\n c){third}");
            X = true;
            Y = true;
            Z = false;
            first = !(X || Y) && (!X || !Z);
            second = !(!X && Y) || (X && !Z);
            third = X || !Y && !(X || !Z);
            Console.WriteLine($"При X,Y-правда,Z-ложь:a){first}\n b){second}\n c){third}");
            X = false;
            Y = true;
            Z = true;
            first = !(X || Y) && (!X || !Z);
            second = !(!X && Y) || (X && !Z);
            third = X || !Y && !(X || !Z);
            Console.WriteLine($"При Z,Y-правда,X-ложь:a){first}\n b){second}\n c){third}");
            X = true;
            Z = true;
            Y = false;
            first = !(X || Y) && (!X || !Z);
            second = !(!X && Y) || (X && !Z);
            third = X || !Y && !(X || !Z);
            Console.WriteLine($"При X,Y-правда,Z-ложь:a){first}\n b){second}\n c){third}");
            X = false;
            Z = false;
            Y = true;
            first = !(X || Y) && (!X || !Z);
            second = !(!X && Y) || (X && !Z);
            third = X || !Y && !(X || !Z);
            Console.WriteLine($"При X,Z-ложь,Y-правда:a){first}\n b){second}\n c){third}");
            Y = true;
            X = true;
            Z = false;
            first = !(X || Y) && (!X || !Z);
            second = !(!X && Y) || (X && !Z);
            third = X || !Y && !(X || !Z);
            Console.WriteLine($"При Y,X-правда,Z-ложь:a){first}\n b){second}\n c){third}");
            Y = false;
            Z = false;
            X = true;
            first = !(X || Y) && (!X || !Z);
            second = !(!X && Y) || (X && !Z);
            third = X || !Y && !(X || !Z);
            Console.WriteLine($"При X-правда,Y,Z-ложь:a){first}\n b){second}\n c){third}");
            Console.ReadLine();
        }
    }
}
