
// Question: You are given an array of numbers [1,2,4,5,7,2,8] ,
// Find the number that occurs more than once in the array


using System;

namespace repeatedNum
{
    class Program
    {
            static void Main(string[] args)
        {
           int[] array = new int[] { 1,2,4,5,7,2,8 };
            Array.Sort(array);
            for(int i=0; i <array.Length;i++)
            {
               if (array[i] == array[i+1])
               continue;
               {
                   System.Console.WriteLine("number {0} is repeated in the array", array[i]);

               }
             
                    
               return;
            }
            

        }
    }
}
