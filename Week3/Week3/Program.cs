using System;
using System.Text;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {

            //method2();
            //method3();
            //method1();
            method7();

        }
        // Write a method that to remove the nth index character from a nonempty string.
        /* static void method1()
         {
             string text = Console.ReadLine();
             for(int i=0;i<text.Length;i++)
             {
                 if(i==7)
                 {
                    string txt=text.Remove(i,1);
                    Console.WriteLine(txt);
                 }
             }

         }*/
        /* You will get a text from where you will need to clean the text because it contains a lot of strange characters that don’t belong there( ^ <, > &+ @%$)
         * Input:
           Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.
          Output:
          Hi there I’m telling you, you need to do your homeworks. Hate me now and thank me later.
         
         static void Clean(string tx)
        {
            string text = "Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.";
            string[] txt = text.Split('^', '<', '>', '&', '+', '@', '%', '$');
            foreach (string text1 in txt)
            {
                Console.Write(text1);
            }
        }
         */

        //Write a method that to remove the characters which have odd index values of a given string.
        /* static void method2()
         {
             string text = Console.ReadLine();
             string newText = "";
             for (int i = 0; i < text.Length; i++)
             {
                 if (i % 2 != 0)
                 {
                     newText = newText + text[i];
                 }

             }
             Console.WriteLine(newText);
         }*/

        //Write a method that takes input from the user and displays that input back in upper and lower cases.
        /*static void method3()
        {
            string text = Console.ReadLine(); 
            string lowerAlpha = text.ToLower();
            Console.WriteLine(lowerAlpha);

            string upperAlpha = text.ToUpper();
            Console.WriteLine(upperAlpha);

        }*/
        //Write a method to display formatted text (width=50) as output. For example: If I have a text that's 134 characters long, the formatted string should have maximum of 50 characters per line. In this case we will have 3 lines of text.
        static void method7()
        {
            Console.WriteLine("Please enter the string: ");
            string userString = Console.ReadLine();
            int noOfLines = userString.Length / 50;
            StringBuilder myStringBuilder = new StringBuilder("");
            myStringBuilder.Append(userString);
            int indexWhereToInsert = 50;
            for (int i = 1; i <= noOfLines - 1; i++)
            {
                myStringBuilder.Insert(indexWhereToInsert, '\n');
                indexWhereToInsert = indexWhereToInsert + 51;
            }
            Console.WriteLine(myStringBuilder);
        }
    }


    }


//Write a method that reverses a string if it's length is a multiple of 4
/* static void method4()
 {

     string myString = Console.ReadLine();
     char[] charArray = myString.ToCharArray();

     Array.Reverse(charArray);

     string newString = "";

     foreach (char tempChar in charArray)
     {
         newString += tempChar;
     }
     Console.WriteLine(newString);
 }
 */

   