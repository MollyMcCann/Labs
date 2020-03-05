using System;

namespace ConsoleMethodsLab
{
    class Program
    {
        static void Main()
        {
            //TODO: Request that a message is to be entered into the Console window
            //      and leave the cursor on the same line as the request.
           
            Console.WriteLine("please enter a message: ");
            Console.SetCursorPosition(23, 0);
            //TODO: Read the message from the Console window.
            Console.ReadLine();

            //TODO: Display the message on the Console window and leave
            //          the cursor on a new line.
            Console.WriteLine("Display message \n");


            // Keep Console window open to see the output.
            Console.Write("PRESS <ENTER> to end.");
            Console.SetCursorPosition(0,4);
            Console.ReadLine();
        }
        // do a method to set the cursor
        

        protected static int origRow;
        protected static int origCol;

        protected static void WriteAt(string s, int x, int y)
        {
        try
            {
            Console.SetCursorPosition(origCol+x, origRow+y);
            Console.Write(s);
            }
        catch (ArgumentOutOfRangeException e)
            {
            Console.Clear();
            Console.WriteLine(e.Message);
            }
        }
    }
}
