using System;

namespace C__Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
           string str1 = "nhbdsslkdoieoidlj";

           Console.WriteLine("Please enter a string of 5 letters");

           string str2 = Console.ReadLine();

           Console.WriteLine(str2);

           bool status = str1.Contains(str2);

           if(status == true)
           {
               Console.WriteLine("The string is a part of the original one!");
           }
           else
           {
               Console.WriteLine("The string is not a part of the original one!");
           } 

           str1 = str2;

           Console.WriteLine("The new copied string is: {0}", str1);

           char[] arr = str1.ToCharArray();

           Array.Sort(arr);

           int len = arr.Length;

           Console.WriteLine("The Final array size is:" + len);

           Console.Write("The sorted array is:");

           for(int i = 0; i<5; i++)
           {
               Console.Write(arr[i]);
           }

        }

    }
}
