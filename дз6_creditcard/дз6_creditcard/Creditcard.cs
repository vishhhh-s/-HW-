using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace дз6_creditcard
{
    class Creditcard
    {
        public string accountnumber;
        public double balance;

        public Creditcard(string accountnumber, double balance)
            {
            this.accountnumber = accountnumber;
            this.balance = balance;
            }

        public void Add()
        {
            Console.WriteLine("Введите сумму для зачисления");
            double ammount = int.Parse(Console.ReadLine());
            this.balance += ammount;
            Console.WriteLine($"На счет{this.accountnumber} зачислено {ammount}");
        }

        public void Withdraw()
        {
            Console.WriteLine("Введите сумму для снятия");
            double ammount = int.Parse(Console.ReadLine());

            if (ammount>0 || ammount<=this.balance)
            {
                this.balance -= ammount;
                Console.WriteLine($"Со счета{this.accountnumber} сняли {ammount}");
            }
            else
                Console.WriteLine("Недосататочно средств");
        }

        public void Showinfo()
        {
            Console.WriteLine($"Номер счета:{this.accountnumber}, баланс:{this.balance}");
        }

    }
}
