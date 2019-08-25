using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace restaurantCalculator
{
    public class Program
    {
        //#6

        static void NegativeNumber(string deniedNum)
        {
            if (deniedNum != null)
            {
                throw new ArgumentException();
            }
        }

        public static void Main()
        {
            //read user input
            string userInput = Console.ReadLine();

            //missing input change to 0
            if (string.IsNullOrEmpty(userInput))
            {
                userInput = "0";
            }

            //set delimiter
            string input = userInput.Replace(@"\n", ",");
            //put string to array
            string[] data = Regex.Split(input, @"[^a-zA-Z0-9-]+");
            //remove empty string in array
            data = data.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            bool negative = false;
            string deniedNumber = "";
            for (int i = 0; i < data.Length; i++)
            {
                //check if data is a number
                string num = Regex.Match(data[i], @"-?\d+").Value;
                if (num == "")
                {
                    data[i] = "0";
                }
                else if (int.Parse(num) < 0)
                {
                    deniedNumber += " " + data[i];
                    negative = true;
                }
            }

            if (negative)
            //when negative number detected
            {
                try
                {
                    NegativeNumber(deniedNumber);
                }
                catch (ArgumentException)
                {
                    Console.Write("Denied negative:" + deniedNumber);
                }
            }
            else
            {
                //check array length
                if (data.Length < 2)
                {
                    Console.Write(data[0]);
                }
                else
                {
                    int total = 0;
                    //calculate total
                    foreach (string num in data)
                    {
                        //ignore any number greater than 1000
                        if (int.Parse(num) < 1001)
                        {
                            total += int.Parse(num);
                        }
                    }
                    //write the output
                    Console.Write(data[0]);
                    for (int i = 1; i < data.Length; i++)
                    {
                        Console.Write(" + " + data[i]);
                    }
                    Console.Write(" = " + total);
                }
            }
        }
    }
}
