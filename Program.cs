using MethodParameters;     //Using the MethodParameters namespace to find the Params.copy method.
using System;

public class Program
{
    //The main method of this class is used to test the functionality of MethodParameters 'params' class.
    
    //create a main entry point for the application
    public static void Main()
    {
        Console.WriteLine("The Params.copy method should return the same value was passed to it.");

        //create a new instance/object of Params and name it "parrot"
        Params parrot = new Params();

        //create variables to test the Params copy method
        Console.WriteLine("Here's what Params.copy when provided the value 'Repeat after me'");
        string val1 = "Repeat after me";
        string output1 = parrot.copy(val1);
        Console.WriteLine(output1);

        Console.WriteLine("Here's what Params.copy when provided the value 'Hello'");
        string val2 = "Hello";
        string output2 = parrot.copy(val2);
        Console.WriteLine(output2);

    }
}