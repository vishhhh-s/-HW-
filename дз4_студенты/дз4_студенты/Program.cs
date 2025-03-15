namespace дз4_студенты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество студентов");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Введите оценку студента {i + 1}");
                int mark = int.Parse(Console.ReadLine());
                if (mark <= 0 || mark > 10)
                {
                    Console.WriteLine("Ошибка");
                    return;
                }
                else
                    arr[i] = mark;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"студент {i + 1}-оценка {arr[i]}");
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double average = (double)sum/n;
            Console.WriteLine($"Средняя оценка группы: {average}");

            int max = arr[0]; 
            int min=arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine($"Cамая высокая оценка: {max}, cамая низкая оценка: {min}");

            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > average)
                    counter++;
            }
                Console.WriteLine($"Количество студентов, получивших оценки выше среднего- {counter}");
        }
    }
}
