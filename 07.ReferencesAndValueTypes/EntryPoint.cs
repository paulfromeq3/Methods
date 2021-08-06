using System;


class EntryPoint
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        int[] secondArray = array;
        array[2] = 10;  // if the second array really had it's own values, this wouldn't affect it.
        Console.WriteLine(secondArray[2]);

        // The problem with this setup is that arrays are reference types.
        // The second array is simply pointing back to the first array.
        // It isn't really coping the values into the second array.

        int number = 10;
        int secondNumber = number;
        number = 12;  // this shows that the second number has it's own values.
        Console.WriteLine(secondNumber);

        // integers are value types
        // arrays are reference types
        // A new array based on an old one doesn't get it's own section of memory.
        // It just refers to the original array.
        // A new integer assigned an old integer's value DOES get it's own section of memory.

        // How this affects Methods...
        // When we use an array in a Method, we work with that array by reference.
        // We don't actually have to return the array.

        ModifyArray(array);
        Console.WriteLine(array[0]);

        // Strings are labeled as reference types, even though they don't behave like that.
        // Integers are value types.
        // Arrays are reference types.

        // When using a variable of reference type, be very careful.
        // Remember you are modifying the original copy of that variable.
    }

    static void ModifyArray(int[] array)
    {
        array[0]++;
        // This Method takes the array and increases the value of its first member by one.
        // It doesn't actually RETURN anything.
        // Notice that the Method has "void" in it, and there's no return keyword.

        
    }
}
