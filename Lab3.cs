using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Lab3
    {
        static int[] intArray = {17,  166,  288,  324,  531,  792,  946,  157,  276,  441, 533, 355, 228, 879, 100, 421, 23, 490, 259, 227,
                                 216, 317, 161, 4, 352, 463, 420, 513, 194, 299, 25, 32, 11, 943, 748, 336, 973, 483, 897, 396,
                                 10, 42, 334, 744, 945, 97, 47, 835, 269, 480, 651, 725, 953, 677, 112, 265, 28, 358, 119, 784,
                                 220, 62, 216, 364, 256, 117, 867, 968, 749, 586, 371, 221, 437, 374, 575, 669, 354, 678, 314, 450,
                                 808, 182, 138, 360, 585, 970, 787, 3, 889, 418, 191, 36, 193, 629, 295, 840, 339, 181, 230, 150};


        static void Main(string[] args)
        {
            Console.WriteLine("The initial unsorted array is:" + "\n");
            PrintArray(intArray); // Printing unsorted numbers
            Console.WriteLine();
            Console.Write("Enter an integer: ");
            int comparisonNumber = 1;
            LinearSearch(intArray, 0, ref comparisonNumber);
            BubbleSort(intArray); //invoking bubble sort method
            Console.WriteLine("The sorted array is:" + "\n");
            PrintArray(intArray); //printing sorted array
            Console.WriteLine();
            Console.Write("Enter an integer: ");
            BinarySearch(intArray, 0, ref comparisonNumber);
            Console.WriteLine();
            Console.Write("Press Enter to exit");
            Console.Read();
        }

        //This method returns the index of a given niddle (an int) in the haystack (an int array)
        //by using linear search. It also returns the value of the number of comparison used to 
        //find the given niddle through the reference parameter numOfComparison.
        static int LinearSearch(int[] haystack, int niddle, ref int numOfComparison) //
        {
            int niddleIndex = -1;
            //Add your code here searching for the niddle in the haystack.
            niddle = int.Parse(Console.ReadLine());
            bool ifFound = true;
            int countInteger = 0;


            while (ifFound)
            {
                for (countInteger = 0; countInteger < haystack.Length; countInteger++)
                {
                    if (niddle == haystack[countInteger] && countInteger != haystack.Length)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Linear search made {0} comparisons to find out that {1} is at index {2} in this unsorted array", numOfComparison += countInteger, niddle, Array.IndexOf(haystack, haystack[countInteger]));
                        Console.WriteLine();
                        ifFound = false;
                    }

                    if (niddle != haystack[countInteger] && countInteger == (haystack.Length - 1) && ifFound)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Linear search made {0} comparisons to find out that {1} is not in this unsorted array", numOfComparison += countInteger, niddle);
                        Console.WriteLine();
                        ifFound = false;
                    }
                }
            }
            return niddleIndex;
        }


        static int BubbleSort(int[] arr)
        {
            int numOfSwaps = 0;

            //Add your code here to implement the bubble sort to sort the integer array arr.
            int B = intArray.Length;
            int temp;
            for (int countInteger = 0; countInteger <= B - 2; countInteger++)
            {
                for (int i = 0; i <= B - 2; i++)
                {
                    if (intArray[i] > intArray[i + 1])
                    {
                        /* swap them and remember something changed */
                        temp = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = temp;
                        numOfSwaps++;
                    }
                }
            }
            Console.WriteLine("Bubble sort made {0} swaps to sort this array", numOfSwaps);
            Console.WriteLine();
            return numOfSwaps;
        }

        //This method returns the index of a given niddle (an int) in the haystack (an int array)
        //by using binary search. It also returns the value of the number of comparison used to 
        //find the given niddle through the reference parameter numOfComparison.

        static int BinarySearch(int[] haystack, int niddle, ref int numOfComparison)
        {
            int niddleIndex = -1;

            //Add your code here to implement the binary search to find the niddle in the haystack.
            niddle = int.Parse(Console.ReadLine());
            numOfComparison = 1;
            int min = 0;
            int x = 0;
            int max = haystack.Length - 1;

            
                while (min <= max)
                {
                    int mid = (min + max) / 2;
                    if (niddle == haystack[mid])
                    {
                        Console.WriteLine();
                        Console.WriteLine("The binary search made {0} comparisons to find out that {1} is at index {2} in the sorted array", numOfComparison += x, niddle, Array.IndexOf(haystack, haystack[mid]));
                        break;
                    }
                    else if (niddle < haystack[mid])
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                    x++;
                }
            
            if (min > max)
            {
                numOfComparison = 0;
                Console.WriteLine();
                Console.WriteLine("The binary search made {0} comparisons to find out that {1} is not in the sorted array", numOfComparison += x, niddle);
            }

            return niddleIndex;
        }






        //Use this method to print an integer array to the console.
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    Console.Write("{0}, ", arr[i]);
                }
                else
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            Console.WriteLine();
        }


    }
}

