namespace дз6_creditcard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creditcard number1 =new Creditcard("1234",1000);
            Creditcard number2 = new Creditcard("2345", 3000);
            Creditcard number3 = new Creditcard("3456", 5000);

            while(true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1-Начислить сумму на счёт");
                Console.WriteLine("2-Снять сумму со счёта");
                Console.WriteLine("3-Информация о счёте");
                Console.WriteLine("4-Выход");

                int choice2 = int.Parse(Console.ReadLine());
                if (choice2 == 4)
                    return;

                Console.WriteLine("Введите номер счета");
                Console.WriteLine("1-1234");
                Console.WriteLine("2-2345");
                Console.WriteLine("3-3456");
                int choice1 = int.Parse(Console.ReadLine());

                Creditcard choicenumber = new Creditcard(null, 0);

                switch(choice1)
                {
                    case 1: 
                        choicenumber = number1;
                        break;
                    case 2:
                        choicenumber = number2;
                        break;
                    case 3:
                        choicenumber = number3;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }

                switch (choice2)
                {
                    case 1: 
                        choicenumber.Add();
                        break;
                    case 2:
                        choicenumber.Withdraw();
                        break;
                    case 3:
                        choicenumber.Showinfo();
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
        }

    }
}
