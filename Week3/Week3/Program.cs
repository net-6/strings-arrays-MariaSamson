using System;
using System.Text;
                                              //STRINGS
namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            //method1();
            //method2();
            //method3();
            //method4();

            //method7();

            //method9();

            //method12();
            method13();
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

        static void method9()
        {
            string s = "hello";
            StringBuilder sb = new StringBuilder(); 
            for (int i = s.Length - 1; i >= 0; i--) 
                sb.Append(s[i]);
            Console.WriteLine(sb.ToString());
        }

        //Write a method that reverses a string if it's length is a multiple of 4
        static void method4()
        {
            string s = "Good";
            StringBuilder sb = new StringBuilder();
            if ((s.Length) % 4 == 0)
            { 
            for (int i = s.Length - 1; i >= 0; i--)
                sb.Append(s[i]);
            }
            Console.WriteLine(sb.ToString());
        }

        static void method12()
        {
            string text = "christmas";
            int n = text.Length;
            Console.WriteLine(char.ToUpper(text[0]) + text.Substring(1,n-2)+char.ToUpper(text[n-1]));
        }

        static void method13()
        {
            int n = 123;
            int sum = 0;
            while(n !=0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
      
      
    }
}





   