namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");

            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Random.Shared.Next(-50,50);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] +" "); ;
            }

            Console.WriteLine("Введите номер элемента");

            int g = int.Parse(Console.ReadLine());

            int[] arr2 = new int[n-1];

            for (int i=0; i<n-1;i++)
            {
                if (i <g)
                    arr2[i]=arr[i];
                else
                    arr2[i] = arr[i + 1];
            }

            for (int i = 0; i < arr2.Length ; i++)
            {
                Console.WriteLine(arr2[i]+" ");
            }

        }
    }
}
