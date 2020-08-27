using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercise
{
    class Program
    {

        

        static void Main(string[] args)
        {
            // Set up dictionary with string array for LCD Style
            Dictionary<int, string[]> LCDStyle = new Dictionary<int, string[]>();

            // Add LCDStyles to dictionary.
            // Note: Was not sure if 0 was needed as it was not shown as an example on document.
            // In staff scenario, would normally ask if they want 0 as LCD style as well.
            LCDStyle.Add(0, new string[3]
            {" _ ",
             "| |",
             "|_|"
            });

            LCDStyle.Add(1, new string[3]
            {"   ",
             " | ",
             " | "
            });

            LCDStyle.Add(2, new string[3]
            {" _ ",
             " _|",
             "|_ "
            });

            LCDStyle.Add(3, new string[3]
            {" _ ",
             " _|",
             " _|"
             });

            LCDStyle.Add(4, new string[3]
            {"   ",
             "|_|",
             "  |"
            });

            LCDStyle.Add(5, new string[3]
            {" _ ",
             "|_ ",
             " _|"
            });

            LCDStyle.Add(6, new string[3]
            {" _ ",
             "|_ ",
             "|_|"
            });

            LCDStyle.Add(7, new string[3]
            {" _ ",
             "  |",
             "  |"
            });

            LCDStyle.Add(8, new string[3]
            {" _ ",
             "|_|",
             "|_|"
            });

            LCDStyle.Add(9, new string[3]
            {" _ ",
             "|_|",
             "  |"
            });

            // Initialise variables
            bool success = false;
            int[] inputNumbers =  new int[1];

            // Loop until input is valid
            while (success == false)
            {
                // Get user input
                Console.WriteLine("Enter input to convert to LCD Style: ");
                string input = Console.ReadLine();

                // Convert input into string
                inputNumbers = new int[input.Length];
                for (int i = 0; i <= input.Length - 1; i++)
                {
                    // Attemp int conversion
                    success = Int32.TryParse(input[i].ToString(), out inputNumbers[i]);
                    if (!success)
                    {
                        // If failed, output error and exit for loop
                        Console.WriteLine("Error: Invalid input. Make sure your input is between numbers 0 - 9");
                        break;
                    }
                }
            }


            // Get output for each individual row
            string[] output = new string[3];
            // First loop through output length (3)
            for (int i = 0; i < 3; i++)
            {
                // Loop through all input numbers
                for (int j = 0; j <= inputNumbers.Length - 1; j++)
                {
                    // Get LCD style for number at specific line number.
                    string[] line = LCDStyle[inputNumbers[j]];
                    // Then add to output
                    output[i] += line[i];
                }
                // Create gap between each number
                output[i] += " ";
            }

            // Output LCD style numbers. Could be moved to loop above after "output[i] += " " 
            // for better efficiency.
            for (int i = 0; i < 3; i++)
            {
                Console.Write(output[i]);
                Console.WriteLine();
            }

            // Stops program from closing instantly
            Console.WriteLine("Click enter to close");
            Console.ReadLine();
        }
    }
}
