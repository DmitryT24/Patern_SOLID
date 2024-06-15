using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Привет!");

            Account usualAccount = new Account("Обычный", 555);
            usualAccount.Interest = Calculator.CalculateInterest(usualAccount, new UsualMethod());
            Console.WriteLine($"\n  Вид счета - {usualAccount.Type}\n  Баланс - {usualAccount.Balance}\n  Процентная ставка - {usualAccount.Interest}\n\n");

            Account SalaryAccount = new Account("зарплатный", 999);
            SalaryAccount.Interest = Calculator.CalculateInterest(SalaryAccount, new PayDay());
            Console.WriteLine($"\n  Вид счета - {SalaryAccount.Type}\n  Баланс - {SalaryAccount.Balance}\n  Процентная ставка - {SalaryAccount.Interest}\n\n");

            Console.ReadKey();
        }
    }
}
