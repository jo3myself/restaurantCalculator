using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace restaurantCalculator
{
    public class Program
    {
        public static void Main()
        {
            //#1

            //read user input
            string userInput = Console.ReadLine();

            //missing input change to 0
            if (string.IsNullOrEmpty(userInput))
            {
                userInput = "0";
            }

            //set delimiter
            char[] delimiter = { ',' };
            //put string to array
            string[] data = userInput.Split(delimiter);
            //remove empty string in array
            data = data.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            for (int i = 0; i < data.Length; i++)
            {
                //check if data is a number
                string num = Regex.Match(data[i], @"-?\d+").Value;
                if (num == "")
                {
                    data[i] = "0";
                }
            }

            //check array length
            if (data.Length < 2)
            {
                Console.Write(data[0]);
            }
            else
            {
                int total = int.Parse(data[0]) + int.Parse(data[1]);
                //write the output
                Console.Write($"{data[0]} + {data[1]} = {total}");
            }
        }
    }
}
