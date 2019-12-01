using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // ex1();
            // ex6();
            //ex9();
            // ex11();
            // ex12();
            ex13();


        }
        /*static void ex1()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            //arrays list
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            //indexes
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i);
            }
        }*/

        /*static void ex6()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int sum = 0;
            for(int i=0;i<array.Length;i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine(sum);
        }*/

        /* static void ex9()
        {
            int[] myArray = new int[] { 4,6,1,90,2 };
            //maximum element in array
            Console.WriteLine(myArray.Max());


            //minimum element in array
            Console.WriteLine(myArray.Min());

          
        }
        */

        /*static void ex11()
        {
            int[] myArray = new int[] { 4, 6, 1, 90, 2 };
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i + 1; j <myArray.Length; j++)
                {
                    if (myArray[j] < myArray[i])
                    {
                        int aux = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = aux;
                    }
                }
            }
            Console.Write("Sort elements of array in ascending order");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0}  ", myArray[i]);
            }
            Console.Write("\n");
        }*/

        /* static void ex12()
         {
             int[] myArray = new int[] { 4, 6, 1, 90, 2 };
             for (int i = 0; i < myArray.Length; i++)
             {
                 for (int j = i + 1; j < myArray.Length; j++)
                 {
                     if (myArray[j] > myArray[i])
                     {
                         int aux = myArray[i];
                         myArray[i] = myArray[j];
                         myArray[j] = aux;
                     }
                 }
             };  
             Console.Write("Sort elements of the array in descending order : ");
             for (int i = 0; i < myArray.Length; i++)
             {
                 Console.Write("{0}  ", myArray[i]);
             }
             Console.Write("\n");
            }
         }*/

        static void ex13()
        {
            int n, i, j = 0, max, secondMax;
            int[] arr1 = new int[50];

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            /* Stored values into the array*/
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* find location of the largest element in the array */
            max = 0;

            for (i = 0; i < n; i++)
            {
                if (max < arr1[i])
                {
                    max = arr1[i];
                    j = i;
                }
            }
            /* ignore the largest element and find the 2nd largest element in the array */
            secondMax = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  /* ignoring the largest element */
                    i--;
                }
                else
                {
                    if (secondMax < arr1[i])
                    {
                        secondMax = arr1[i];
                    }
                }
            }

            Console.Write("The Second largest element in the array is :  {0} \n\n", secondMax);
        }
    }
}


