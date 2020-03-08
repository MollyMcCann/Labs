using System;

namespace DebuggerLab
{
    class Program
    {

        static void Main()
        {
            int valueInt = 23;
            string valueString = "Hello";
            bool valueBool = true;

            // Display value in int variable.
            Console.WriteLine("Value in int variable is: " + valueInt);
            
            Console.WriteLine("Value in string variable is: " + valueString);

            Console.WriteLine("Value in bool variable is: " + valueBool);

            // Keep Console window open to see the output.
            Console.Write("PRESS <ENTER> to end.");
            Console.ReadLine();
        }
    }
}
