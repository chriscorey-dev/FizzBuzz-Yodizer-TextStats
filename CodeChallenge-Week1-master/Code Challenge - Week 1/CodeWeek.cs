using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge___Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call FizzBuzz Function
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }
            for (int j = 92; j >= 79; j--)
            {
                FizzBuzz(j);
            }

            //Call Yodaizer Function
            Yodaizer("I like code");
            Console.WriteLine("");

            //Call TextStats Function          
            TextStats(@"Coding is super fun and useful. It offers a lot of job oppertunity.
                      I'm in seed paths to be able to code well!");
            Console.WriteLine("");

            //Call IsPrime Function
            for (int i = 1; i <= 25; i++)
            {
                IsPrime(i);
            }
            //Call DashInsert Function with the number 8675309
            DashInsert(8675309);
            //Console.ReadKey() to keep the console window open until we close it.
            Console.ReadKey();
        }

        //creating a FizzBuzz function
        static void FizzBuzz(int number)
        {
            //if it's a multple of 5 and 3
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            //if multiple of 5
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            //multiple of 3
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            //else
            else
            {
                Console.WriteLine(number);
            }
        }

        //creating Yodaizer function
        static void Yodaizer(string text)
        {
            //defining variable for the function
            var textSplit = text.Split(' ');
            var lastLength = textSplit[textSplit.Length - 1];
            var textLength = textSplit.Length;
            if (textLength == 3)
            {

                Console.Write(textSplit[textLength - 1] + ", ");
                for (int i = 0; i < text.Length - lastLength.Length - 1; i++)
                {
                    Console.Write(text[i]);
                }
            }
            else
            {
                    Console.Write(text);
            }
        }

        //Text Stats
        static void TextStats(string input)
        {
            var numChar = input.Length;
            var numCharSplit = input.Split(' ');
            var numWords = numCharSplit.Length;
            var numVowels = 0;
            var numConsonant = 0;
            var numSpecChar = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "a" || input[i].ToString() == "e" || input[i].ToString() == "i" || input[i].ToString() == "o" || input[i].ToString() == "u")
                {
                    numVowels = numVowels + 1;
                }
                else if(input[i].ToString() == "." || input[i].ToString() == "," || input[i].ToString() == "?" || input[i].ToString() == "!") {
                    numSpecChar = numSpecChar + 1;
                }

                else
                {
                    numConsonant = numConsonant + 1;
                }
            }

            Console.WriteLine("The number of characters is " + numChar);
            Console.WriteLine("The number of words is " + numWords);
            Console.WriteLine("The number of vowels is " + numVowels);
            Console.WriteLine("The number of consonants is " + numConsonant);
            Console.WriteLine("The number of special characters is " + numSpecChar);
            }
        
        //IsPrime
        static void IsPrime(int number)
        {
            if (number == 1 || number == 2 || number == 3 || number == 5 || number == 7)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else if (number % 1 == 0 && number % number == 0 && number % 2 != 0 && number % 3 != 0 && number % 4 != 0 && number % 5 != 0 && number % 6 != 0 && number % 7 != 0 && number % 8 != 0 && number % 9 != 0)
            {
                Console.WriteLine(number + " is a prime number");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
        }

        //DashInsert
        static void DashInsert(int number)
        {
            var numString = number.ToString();
            var numLength = numString.Length;
            var numSplit = numString.Split();
            for (int i = 0; i < numLength; i++)
            {
                var checkIt = numStrimg[i + 1] % 2 != 0;
                var currNum = numString[i];
                if (currNum % 2 != 0 && numString[i+1] % 2 != 0 && numString[i].TryParse())
                {
                    Console.Write(currNum + "-");
                }
                else
                {
                    Console.Write(currNum);
                }
            }
        }
    }
}
