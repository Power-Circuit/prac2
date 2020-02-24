using System;

namespace Problems
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string hey = "";
            Console.WriteLine(Prefix(hey));
            //Assert.AreEqual(Prefix("hello"), "5,1:hello");

        }

       public static string Prefix(string input)
        {
            string result = "";
            int temp = input.Length;//add length to string

            result += temp.ToString() + ",";
            temp = countWords(input);//add num of words to the string

            result += temp.ToString() + ":";
            result += input;//add the actual word to the string

            return result;
        }

       public static int countWords(String str)
        {
            int state = 0;
            int wc = 0; // word count 
            int i = 0;

            // Scan all characters one  
            // by one 
            while (i < str.Length)
            {
                // If next character is a separator,  
                // set the state as OUT 
                if (str[i] == ' ' || str[i] == '\n' || str[i] == '\t')
                {

                    state = 0;

                }
                // If next character is not a word  
                // separator and state is OUT, then  
                // set the state as IN and increment 
                // word count 
                else if (state == 0)
                {
                    state = 1;
                    ++wc;
                }

                // Move to next character 
                ++i;
            }

            return wc;
        } // this method was used from https://www.geeksforgeeks.org/count-words-in-a-given-string/

      
    }
}
