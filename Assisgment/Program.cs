using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisgment
{
    /* Create a function that determines whether elements in an array can be re-arranged 
        * to form a consecutive list of numbers where each number appears exactly once.
        * Examples
Cons([5, 1, 4, 3, 2]) ➞ true
// Can be re-arranged to form [1, 2, 3, 4, 5]

Cons([5, 1, 4, 3, 2, 8]) ➞ false

Cons([5, 6, 7, 8, 9, 9]) ➞ false
// 9 appears twice*/
    class Program
    {
        //function
        static Boolean Checking(int[] arr)

        {
            //this Arry sort the function to asending order///
            Array.Sort(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1] || arr[i] != arr.Min() + i)
                {
                    return false;
                }
            }


            return true;


        }
        static void Main(string[] args)

        {

            Console.WriteLine(Checking(new int[] { 5, 1, 4, 3, 2 }));
            Console.WriteLine(Checking(new int[] { 5, 1, 4, 3, 2, 8 }));
            Console.WriteLine(Checking(new int[] { 3, 2, 1, 5, 4 }));
            Console.WriteLine(Checking(new int[] { 5, 6, 7, 8, 9, 9 }));
            Console.ReadLine();


        }

    }
}
