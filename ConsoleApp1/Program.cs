﻿// See https://aka.ms/new-console-template for more information

class Program
{
    // method does not take any parameter 
    public void greet()
    {
        Console.WriteLine("Hello");
    }

    // method takes one string parameter
    public void greet(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    static void Main(string[] args)
    {
        Program p1 = new Program();

        // calls method without any argument
        p1.greet();

        //calls method with an argument
        p1.greet("Tim");

    }
}