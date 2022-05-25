using System;
using System.Collections;
namespace 스택
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());
            int i = 0;
            int[] arr = new int[index];
            int j = 1;
            Stack stack = new Stack();
            while (i < index)
            {
                arr[i] = int.Parse(Console.ReadLine());
                i++;
            }
            int arrnum = arr[0];
            i = 1;
            while (i <= arr.Length)
            {
                if (i <= arrnum)
                {
                    stack.Push(i);
                    Console.WriteLine("+");
                    i++;
                } else
                {
                    Console.WriteLine("-");
                    //Console.WriteLine(arrnum);
                    arrnum = arr[j++];
                    stack.Pop();
                }
            }
            while (stack.Count > 0)
            {
                Console.WriteLine("-");
                //Console.WriteLine(arrnum);
                arrnum = arr[j++];
                stack.Pop();
            }
        }
    }
}