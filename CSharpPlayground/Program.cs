using System;
using System.Linq;
using CSharpPlayground;

Console.WriteLine("Creating an employee");

Employee danelle = new Employee("Danelle", "Cook", "dcook@gmail.com", new DateTime(1982, 1, 23), 25);

danelle.DisplayEmployeeDetails();

danelle.PerformWork();
danelle.PerformWork();
danelle.PerformWork(5);
danelle.PerformWork();

double receivedWageDanelle = danelle.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from program): {receivedWageDanelle}");

Employee matt = new Employee("Matt", "Cook", "mcook@gmail.com", new DateTime(1986, 1, 23), 50);

matt.DisplayEmployeeDetails();

matt.PerformWork();
matt.PerformWork();
matt.PerformWork(10);
matt.PerformWork();

double receivedWageMatt = matt.ReceiveWage(true);

Console.WriteLine($"Wage paid (message from program): {receivedWageMatt}");


// Object of derived class 
Dog vizsla = new Dog();
vizsla.name = "Flynn";

vizsla.display();

vizsla.getName();


// provides us various methods to use in an array


int[] numbers = { 51, 1, 3, 4, 98 };

// get the minimum element
Console.WriteLine("Smallest  Element: " + numbers.Min());

// Max() returns the largest number in array
Console.WriteLine("Largest Element: " + numbers.Max());

Console.ReadLine();