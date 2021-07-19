using System;

class EntryPoint
{
    static void Main()
    {
        Console.WriteLine("Before the Methods");
        PrintingNames();
        PrintingNames();
        Console.WriteLine("In between the Methods");
        PrintingNames();
        PrintingNames();
        Console.WriteLine("After the Methods");
    }

    // Code here is outside of the Main method
    // This is where your methods will go.
    // Naming convention for Methods: all Methods start with a capital letter.
    // Methods should do only one thing.
    // Methods look like variables with parenthesis at the end.
    // After the Method is executed, code execution will continue with the line after the call to the Method.


    static void PrintingNames()
    {
        Console.Write("My name is Paul Walker ");
        Console.Write("and I am ");
        Console.Write("learning C#\n");
    }

}
