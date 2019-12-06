using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            //ex3();
            
            //ex6();

            //ex8();
            //ex9();
            //ex10();
            //ex11();
            //ex12();
            //ex13();

            //ex15();
            //ex16();


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

        static void ex2()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void ex3()
        {
            int[] arr = { 1, 2, 2, 2, 2, 3, 4, 7, 8, 8 };
            int n = arr.Length;
            int nr = 7;
            int index = 0;

            for (int i = 0; i < n; i++)
                if (nr == arr[i])
                    index++;
            Console.WriteLine(index);
        }

       
        }

        

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


        /*static void ex8()
        {
            int[] myArray1 = new int[] { 4, 6, 1, 90, 2 };
            int[] myArray2 = new int[] { 3, 5, 7, 98, 43 };
            int[] myArray3 = new int[10];
            int i, n;
            for (i = 0; i < myArray1.Length; i++)
            {
                myArray3[i] = myArray1[i];
            }
            for (int j = 0; j < myArray2.Length; j++)
            {
                myArray3[i] = myArray2[j];
                i++;
            }
            n = myArray1.Length + myArray2.Length;

            for (int k = 0; k < n; k++)
            {
                Console.Write("{0} ", myArray3[k]);
            }
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

        /*static void ex10()
        {
            int[] arr1 = new int[] { 5, 6, 7, 43, 2 };
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int i, j = 0, k = 0;


            for (i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }

            Console.Write("the even elements are : \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }

            Console.Write("the odd elements are :\n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            
        }
    }*/
    

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

    /*static void ex13()
    {
        int n, i, j = 0, max, secondMax;
        int[] arr1 = new int[50];

        Console.Write("Input the size of array : ");
        n = Convert.ToInt32(Console.ReadLine());
        // Stored values into the array//
        Console.Write("Input {0} elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        // find location of the largest element in the array //
        max = 0;

        for (i = 0; i < n; i++)
        {
            if (max < arr1[i])
            {
                max = arr1[i];
                j = i;
            }
        }
        //ignore the largest element and find the 2nd largest element in the array //
        secondMax = 0;
        for (i = 0; i < n; i++)
        {
            if (i == j)
            {
                i++;  // ignoring the largest element //
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
    */


    /* static void ex15()
    {
        int i, j;
        int[,] matrix = new int[3, 3];
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {
                Console.Write("element - [{0},{1}] : ", i, j);
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("\nThe matrix is : \n");
        for (i = 0; i < 3; i++)
        {
            Console.Write("\n");
            for (j = 0; j < 3; j++)
                Console.Write("{0}\t", matrix[i, j]);
        }
        Console.Write("\n");
    }
    */


    /* static void ex16()
    {
        int i, j;
        int[,] matrix1 = new int[2, 2];
        int[,] matrix2 = new int[2, 2];
        int[,] sum = new int[2, 2];
        //Matrix 1
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write("element - [{0},{1}] : ", i, j);
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("\nThe matrix is : \n");
        for (i = 0; i < 2; i++)
        {
            Console.Write("\n");
            for (j = 0; j < 2; j++)
                Console.Write("{0}\t", matrix1[i, j]);
        }
        Console.Write("\n");


        //Matrix2
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write("element - [{0},{1}] : ", i, j);
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("\nThe matrix is : \n");
        for (i = 0; i < 2; i++)
        {
            Console.Write("\n");
            for (j = 0; j < 2; j++)
                Console.Write("{0}\t", matrix2[i, j]);
        }
        Console.Write("\n");

        //Sum
        //Matrix2
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {

                sum[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        Console.Write("The Addition of two matrix is : \n");
        for (i = 0; i < 2; i++)
        {
            Console.Write("\n");
            for (j = 0; j < 2; j++)
                Console.Write("{0}\t", sum[i, j]);
        }
    }*/

}
    



