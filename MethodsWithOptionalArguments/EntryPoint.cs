using System;

class EntryPoint
{
    static void Main()
    {
        // Creating a method that has optional values.
        // It's not actually optional, it just looks that way when you use it.
        // It's really using default values.
        // This is an approach to using methods that ensures it works properly
        // even if the user decides not to use a value for some of the arguments.

        // Create a method that multiplies three numbers.
        // But set it up to work even if you only need to multiply 2 numbers.
        // If you used it and needed only to multiply 2 numbers, you could ust 1 for the third, since it doesn't affect the value.
        // You could also use 1 for a default value for one of the arguments.
        // To set a default value, just assign the variable a value when declaring the method.


        Console.WriteLine(Multi(9, 7));
        ConnectToDB("Paul", "julieisawesome", "192.168.0.1");

        Console.WriteLine(AddMe(5, 6));



    }

    static int Multi(int firstNumber, int secondNumber, int thirdNumber = 1)
    {
        return firstNumber * secondNumber * thirdNumber;
    }

    // This is another example, a method that connects to a database.
    // If you're connecting to a local database on your own computer, the ip address will always be 127.0.0.1
    // That's called Local Host, and it always points to your computer.
    static void ConnectToDB(string userName, string userPassword, string ipAddress = "127.0.0.1")
    {
        Console.WriteLine($"Hello {userName}. Connecting to the database at {ipAddress}. Please wait.");
    }

    // Challenge: Create a method to add 3 numbers and make the third number optional
    static int AddMe(int firstNumber, int secondNumber, int thirdNumber = 0)
    {
        return firstNumber + secondNumber + thirdNumber;
    }
}
