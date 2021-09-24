using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("classwork1");
            Console.WriteLine("Максимальное значение byte:" + byte.MaxValue + "Минимальное значение byte:" + byte.MinValue);
            Console.WriteLine("Ьаксимальное значение int:" + int.MaxValue + "Минимальное значение int:" + int.MinValue);
            Console.WriteLine("Максимальное значение char:" + char.MaxValue + "Минимальное значение char:" + char.MinValue);
            Console.WriteLine("Максимальное значение decimal:" + decimal.MaxValue + "Минимальное значение decimal:" + decimal.MaxValue);
            Console.WriteLine("Максимальное значение double:" + double.MaxValue + "Минимальное значение double:" + double.MinValue);
            Console.WriteLine("Максимальное значение float:" + float.MaxValue + "Минимальное значение float:" + float.MinValue);
            Console.WriteLine("Максимальное значение long:" + long.MaxValue + "Минимальное значение long:" + long.MinValue);
            Console.WriteLine("Максимальное значение sbyte:" + sbyte.MaxValue + "Минимальное значение sbyte:" + sbyte.MinValue);
            Console.WriteLine("Максимальное значение short:" + short.MaxValue + "Минимальное значение short:" + short.MinValue);
            Console.WriteLine("Максимальное значение unit:" + uint.MaxValue + "Минимальное значение uint:" + uint.MinValue);
            Console.WriteLine("Максимальное значение ulong:" + ulong.MaxValue + "Минимальное значение ulong:" + ulong.MinValue);
            Console.WriteLine("Максимальное значение ushort:" + ushort.MaxValue + "Минимальное значение ushort:" + ushort.MinValue);
            Console.WriteLine("bool принимает значение правды true и значение отрицания false");
            Console.WriteLine("object переменная ссылочного типа может ссылаться на объект любого другого типа");
            Console.WriteLine("string хранит упорядоченные значения объектов переменного типа char");

            Console.WriteLine("classwork 2");
            string name =Console.ReadLine();
            string city = Console.ReadLine();
            byte age = Convert.ToByte(Console.ReadLine());
            int pinCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Данные пользователя:\nИмя:{name}\nГород:{city}\nВозраст{age}\nПин-Код{pinCode}");
            
            Console.WriteLine("classwork 3");
            string s = Console.ReadLine();//входная строка
            string str = "";
            
            for (int i = 0; i < s.Length;i++)
            {
                bool isLower = char.IsLower(s[i]);
                if (isLower)
                {
                    str = str + char.ToUpper(s[i]);
                }
                else
                {
                    str = str + char.ToLower(s[i]);
                }
                
            }
            Console.WriteLine(str);

            Console.WriteLine("classwork 4");
            Console.WriteLine("Введите строку");
            string inputStr = Console.ReadLine();//строка
            Console.WriteLine("Введите подстроку");
            string inputStr2 = Console.ReadLine();//подстрока
            Console.WriteLine((inputStr.Length-inputStr.Replace(inputStr2,"").Length)/inputStr2.Length);

            Console.WriteLine("classwork 5");
            Console.WriteLine("Введите скорость таракана в км/ч");
            double v1 = Convert.ToDouble(Console.ReadLine());//скорость таракана в км/ч
            double v2 = v1 * 10000 / 3600;//скорость таракана в см/с
            Console.WriteLine("Скорость таракана в см/с:"+Math.Round(v2,0));
            

            Console.WriteLine("classwork 6");
            age = Convert.ToByte(Console.ReadLine()); //возраст отца
            byte age1 = Convert.ToByte(Console.ReadLine()); //возраст сына
            age = (byte)(age - age1);
            age1 = 0;
            while (age1*2 != age)
            {
                age+=1;
                age1+=1;
            }
            Console.WriteLine("Возраст отца, при котором он старше сына в 2 раза"+age);
            Console.WriteLine("Возраст сына,при котором он в два раз младше отца"+age1);
            
            Console.WriteLine("classwork 7");
            int normPrice = 10;//цена без учета скидки
            int salePrice =(normPrice - 10) / 100;//цена с учетос скидки
            int holidayPrice = 500;//цена отпуска
            int bottles = holidayPrice / (normPrice - salePrice);//количество бутылок, при котором окупится отпуск
            Console.WriteLine("количество бутылок, при котором окупится отпуск"+bottles);
            Console.ReadLine();
        }
    }
}
