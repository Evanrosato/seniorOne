using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace seniorOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chose Your Task");
            Console.WriteLine("1: Case Conversion\n2: Reverse String\n3: Increment Digits");
            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    caseConvert();
                    break;

                case "2":
                    backString();
                    break;

                case "3":
                    plusDigit();
                    break;

                default:
                    Console.WriteLine("Invalid Number. Try Again.");
                    break;
            }
        }

        static void caseConvert()
        {
            Console.WriteLine("Input a string. Must be between 5-10 chars, only letters, at least one uppercase and one lowercase.");
            string theirString = Console.ReadLine();

            if (Regex.IsMatch(theirString, @"^[a-zA-Z]+$") == false || theirString.Length < 5 || theirString.Length > 10 || theirString.Any(char.IsUpper) == false || theirString.Any(char.IsLower) == false)
            {
                Console.WriteLine("Invalid String. Try Again.");
                theirString = "";
                caseConvert();
            }

            foreach (char let in theirString)
            {
                if (Char.IsUpper(let))
                {
                    Console.Write(Char.ToLower(let));

                } else {
                    Console.Write(Char.ToUpper(let));

                }
            }
        }

        static void backString()
        {
            Console.WriteLine("Input a string between 8-20 chars.");
            string forString = Console.ReadLine();

            if (forString.Length < 8 || forString.Length > 20)
            {
                Console.WriteLine("Invalid string length. Try Again.");
                forString = "";
                backString();
            }

            char[] theArray = forString.ToCharArray();
            Array.Reverse(theArray);
            Console.WriteLine(new string(theArray));
        }

        static void plusDigit()
        {
            Console.WriteLine("Input a 3-digit number.");
            string yourNum = Console.ReadLine();

            if (Int32.Parse(yourNum) < 100 || Int32.Parse(yourNum) > 999)
            {
                Console.WriteLine("Invalid number. Try Again.");
                yourNum = "";
                plusDigit();
            }

            foreach (char num in yourNum)
            {
                int newNum = (int)Char.GetNumericValue(num);
                newNum++;

                if (newNum == 10)
                {
                    newNum = 0;
                }

                Console.Write(newNum);
            }
        }
    }
}
