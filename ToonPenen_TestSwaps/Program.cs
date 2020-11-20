using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] list2 = new int[] { 6, 5, 4, 3, 2, 1 };

            int temp;

            for (int i = 0; i < list1.Length; i++)
            {
                temp = list1[i];
                list1[i] = list2[i];
                list2[i] = temp;
            }
            Console.WriteLine("eerste lijst is:");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*******************************");
            Console.WriteLine("tweede lijst is : ");

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
