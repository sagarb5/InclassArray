using System;

namespace InclassArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please use an integer b/w 1 and 20");
            try
            {

                string input = Console.ReadLine();
                int number = int.Parse(input);

                if (number > 0 && number <= 10)
                {
                    Console.WriteLine("");
                    Console.WriteLine(" First, Let's populate the array manually");
                    Console.WriteLine(" Then let's iterate them with a formulae");
                    int[] numbers = { 8, 1, 3, 6, 0, 7, 1, 7, 3, 8 }; // creating an array
                    Console.WriteLine(" The value the user entered is" + number);
                    foreach (int i in numbers)
                    {
                        Console.WriteLine(i + " ");
                    }
                } // end of if
                else if (number > 10 && number <= 20)
                {
                    Console.WriteLine("now do it automatically");
                    Console.WriteLine("And it iterate them again");
                    int[] countdown = new int[number];
                    Console.WriteLine("");
                    Console.WriteLine("the value is" + number);
                    int pop_array = 0;
                    for (int i = 0; i < number; i++)
                    {
                        countdown[i] = pop_array;
                        Console.WriteLine(i + " ");
                        // Console.WriteLine("Press any key to exit");
                        // Console.ReadKey(true);



                    } // end of else if
                }
                else
                {
                    Console.WriteLine("Please enter the value b/w 1 and 20 ");
                }
                
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);   
            } // end of try block
            catch
            {
                Console.WriteLine("Press any key to exit......");
                Console.ReadKey(true);

            } // end of catch block
        }
    }
}
