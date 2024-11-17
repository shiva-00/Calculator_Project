using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {

        // Function to perform calculations based on the chosen operation
        static void cal_sol(int operation)
        {

            // Asking user to enter the numbers and specify 'done' to finish
            Console.WriteLine("Enter the numbers and Enter Done at the end:");
            int result = 0;    // Variable to store the result of operations
            bool flag = true;   // Flag to check if it's the first number entered

            // Asking user to input numbers in a loop
            Console.WriteLine("Enter the Numbers: ");
            while (true)
            {
                string input = Console.ReadLine();

                // Exit condition if user enters "done"
                if (input.ToLower() == "done")
                {
                    break;
                }

                // Try to parse the input as an integer
                if (int.TryParse(input, out int number))
                {
                    if (flag)            // If it's the first number, initialize result
                    {
                        result = number;
                        flag = false;
                    }

                    // Perform the operation based on user selection
                    else
                    {
                        switch (operation)
                        {
                            case 1:
                                result += number;
                                break;
                            case 2:
                                result -= number;
                                break;
                            case 3:
                                result *= number;
                                break;
                            case 4:
                                if (number != 0)
                                {
                                    result /= number;
                                }
                                else
                                {
                                    Console.WriteLine("Division by zero is not allowed.");
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid operation.");
                                return;
                        }
                    }

                }

            }
            Console.WriteLine($"The final Result:  { result}");

        }
        static void Main(string[] args)
        {

            // Display options for available operations
            Console.WriteLine(" Enter 1 for Add\n Enter 2 for Sub\n Enter 3 for Mul\n Enter 4 for div");

            // Ensure that the operation input is valid (1-4)
            if (int.TryParse(Console.ReadLine(), out int operation) && operation >= 1 && operation <= 4)
            {
                cal_sol(operation);   // Call the calculation function with the selected operation
            }

            else
            {

                // If the user input an invalid operation, show an error message and terminate the program
                Console.WriteLine("Please Restart the Program and Choose between 1 and 4");
                return;
            }
        }

        }
    }
