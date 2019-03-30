using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            int[] intArray = new int[] { 1, 2, 5, 7, 8 };
            var odds = p.sumOddsInArray(intArray);
            Console.WriteLine(odds);

            UInt64[] intArray2 = new UInt64[] { 100558304029, 2454875027, 5 , 9, 290824 };
            var sum = p.sumElementsInArray(intArray2);
            Console.WriteLine(sum);

            var reverse = p.reverseString("LetsSeeIfItReverses");
            Console.WriteLine(reverse);

            var remove = p.removeLetterRepeats("Mississippi");
            Console.WriteLine(remove);

            p.fizzBuzz();

            Console.ReadLine();
        }

        //Given an array of integers, write a method to total the odd numbers.
        public int sumOddsInArray(int[] array)
        {
            var sum = 0;
            for (var i=0; i<array.Length; i++)
            {
                if (array[i]%2 == 1)
                {   
                    sum += array[i];
                } 
            }
            return sum;
        }

        //Given an array of integers, write a method to sum the elements in the array, 
        //knowing that some of the elements may be very large integers.
        public UInt64 sumElementsInArray(UInt64[] array)
        {
            UInt64 sum = 0;
            for (var i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        //Given a string, reverse it.
        public string reverseString(String strIn)
        {
            int strLength = strIn.Length;
            var strOut = "";
            for (int i=strLength; i-- > 0;)
            {
                strOut += strIn[i];
            }
            return strOut;
        }

        //Given a string, remove any repeated letters.
        public string removeLetterRepeats(String strIn)
        {
            var letters = new List<char> ();
            var strOut = "";
            for (int i=0; i< strIn.Length; i++)
            {
                if (!letters.Contains(strIn[i]))
                {
                    strOut += strIn[i];
                    letters.Add(strIn[i]);
                }
            }
            return strOut;
        }

        //Write a program that prints the numbers from 1 to 100. 
        //But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
        //For numbers which are multiples of both three and five print “FizzBuzz”.
        public void fizzBuzz()
        {

            for (var i=1; i<=100; i++)
            {
                var val = (i % 3 == 0) ? "Fizz" : "";
                val += (i % 5 == 0) ? "Buzz" : "";
                val = (val.Length == 0) ? i.ToString() : val;
                Console.WriteLine(val);
            }
        }
    }
}
