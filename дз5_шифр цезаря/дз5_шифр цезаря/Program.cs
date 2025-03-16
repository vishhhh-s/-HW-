namespace дз5_шифр_цезаря
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choise = 0;
            while (true)
            {
                Console.WriteLine("Сделайте выбор: 1-зашифровать, 2-расшифровать");
                bool isValid = int.TryParse(Console.ReadLine(), out choise);
                if (!isValid)
                {
                    Console.WriteLine("Не число");
                }
                else if (choise > 2 || choise < 1)
                {
                    Console.WriteLine("Ошибка ввода");
                }
                else
                    break;
            }

                Console.WriteLine("Введите ключ для шифрования");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите сообщение");
                string str = Console.ReadLine();

                if (choise == 2)
                {
                    n = -n;
                }

                string alphabet = "абвгдеёжзиклмнопрстуфхцчшщъыьэюя";
                string alphabetUpp = alphabet.ToUpper();

                char[] result = str.ToCharArray();

                for (int i = 0; i < result.Length; i++)
                {
                    bool IsUpper = char.IsUpper(result[i]);
                    bool IsLower = char.IsLower(result[i]);

                    if (IsUpper == true)
                    {
                        int index = alphabetUpp.IndexOf(result[i]);
                        int newindex = ((index + n + alphabetUpp.Length) % alphabetUpp.Length);
                        result[i] = alphabetUpp[newindex];
                    }
                    else if (IsLower == true)
                    {
                        int index = alphabet.IndexOf(result[i]);
                        int newindex = ((index + n + alphabetUpp.Length) % alphabetUpp.Length);
                        result[i] = alphabet[newindex];
                    }
                    else
                    {
                        if (!char.IsLetter(result[i]))
                            continue;
                    }
                }
                Console.WriteLine("Результат: ");
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write(result[i]);
                }
                Console.WriteLine();
        }
    }
}
