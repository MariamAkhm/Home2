using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_met
{
    class Program
    {
        enum BankAccountType { checking, savings}
        public struct Information
        {
            public uint number;
            public string type;
            public double balance;
        }
        public enum ВУЗ { КГУ, КАИ, КХТИ}
        public struct Employee
        {
            public string name;
            public ВУЗ univercity;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("exercise 1");
            BankAccountType firstType;
            firstType = (BankAccountType)0;
            Console.WriteLine(firstType);
            BankAccountType secondType;
            secondType = (BankAccountType)1;
            Console.WriteLine(secondType);

            Console.WriteLine("exercise 2");
            Information companyInformation;
            companyInformation.number = Convert.ToUInt32(Console.ReadLine());
            companyInformation.type = Console.ReadLine();
            companyInformation.balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"номер банковского счета: {companyInformation.number}\n тип:{companyInformation.type}\n баланс:{companyInformation.balance}");

            Console.WriteLine("exercise 3");
            Employee information;
            information.name = Console.ReadLine();
            information.univercity = (ВУЗ)byte.Parse(Console.ReadLine());
            Console.WriteLine("Имя сотрудника:"+information.name+"ВУЗ:"+information.univercity);
            Console.ReadLine();
        }
    }
}
