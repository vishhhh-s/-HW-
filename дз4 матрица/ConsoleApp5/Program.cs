using System.Diagnostics.Metrics;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы, количество строк:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("количество столбцов:");
            int m = int.Parse(Console.ReadLine());

            int[,] arr = new int[n,m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = Random.Shared.Next(-50, 50);
                }
            }

            Console.WriteLine("Матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }


            while (true)
            {
                Console.WriteLine("Выберите действие: (1-количество положительных чисел, 2-количество отрицательных чисел, 3-сортировка, 4-выход)");
                string op = Console.ReadLine();

                int counter1 = 0;
                int counter2 = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (arr[i, j] > 0)
                            counter1++;
                        if (arr[i, j] < 0)
                            counter2++;
                    }
                }


                switch (op)
                {
                    case "1":
                        Console.WriteLine($"количество положительных чисел-{counter1}");
                        break;
                    case "2":
                        Console.WriteLine($"количество отрицательных чисел-{counter2}");
                        break;
                    case "3":
                        int temp;
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                for (int a = 0; a < m - 1 - j; a++)
                                {
                                    if (arr[i, a] < arr[i, a + 1])
                                    {
                                        temp = arr[i, a];
                                        arr[i, a] = arr[i, a + 1];
                                        arr[i, a + 1] = temp;
                                    }
                                }
                            }
                        }

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write(arr[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
        }
    }
}
