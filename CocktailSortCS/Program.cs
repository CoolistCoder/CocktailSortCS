//Created 3/10/2024 Alec R.
//.net 8.0
using System;
using System.Numerics;

namespace CocktailSortCS
{
    class Program
    {
        public static void Main(string[] args)
        {
            int temp = 0, passes = 0, start = 0; //used to perform the swap
            bool sorted = false;           //tells us if we're sorted
            const int howmany = 100;        //How many elements in the list
            List<int> arr = new List<int>(); //The list to add random elements into
            Random rand = new Random();     //random var

            //Cocktail sort is a bubble sort across and back
            //Great for big arrays, so it's a good idea to use a big array

            //Begin with some friendly user output
            System.Console.WriteLine("Adding " + howmany + " random elements to a list");
            System.Console.WriteLine("Press return to begin");
            System.Console.ReadLine();

            //Add those elements
            for (int i=0; i<howmany; i++)
            {
                arr.Add(rand.Next() % 100);
                System.Console.WriteLine("Adding element " + i + ": " + arr[i]);
            }

            //Elements added, more user output
            System.Console.WriteLine("Now performing the sort");
            System.Console.WriteLine("Press return to continue");
            System.Console.ReadLine();

            //Perform the sort
            while (!sorted)
            {
                sorted = true; //Assume we're sorted till we know we're not
                for (int i=start; i<arr.Count()-1; i++)
                {
                    if (arr[i] > arr[i + 1]) //swap if element[i] < element[i+1]
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        sorted = false;
                    }
                }

                
                //If we're not done sorting, sort backwards
                if (!sorted)
                {
                    for (int i = arr.Count()-1; i > start; i--)
                    {
                        if (arr[i] < arr[i - 1]) //swap if element[i] < element[i-1]
                        {
                            temp = arr[i];
                            arr[i] = arr[i - 1];
                            arr[i - 1] = temp;
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine("Final pass performed");
                    break;
                }


                System.Console.WriteLine("Passes performed: " + (passes++));
                start++; //iterate the i to the next element
            }

            //Elements have been sorted, final result to print
            System.Console.WriteLine("All elements have been sorted");
            System.Console.WriteLine("Press return to print final result");
            System.Console.ReadLine();

            //Final print of sorted list
            for (int i = 0; i < arr.Count(); i++)
            {
                System.Console.WriteLine("Sorted element " + i + ": " + arr[i]);
            }

            Console.WriteLine("End of program");
        }
    }
}




