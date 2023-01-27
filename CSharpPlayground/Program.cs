using System;
using System.Linq;
using CSharpPlayground;

Console.WriteLine("Creating an employee");

Employee danelle = new Employee("Danelle", "Cook", "dcook@gmail.com", new DateTime(1982, 1, 23), 25);

danelle.DisplayEmployeeDetails();
/*
danelle.PerformWork();
danelle.PerformWork();
danelle.PerformWork(5);
danelle.PerformWork();
*/

double receivedWageDanelle = danelle.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from program): {receivedWageDanelle}");

Employee matt = new Employee("Matt", "Cook", "mcook@gmail.com", new DateTime(1986, 1, 23), 50);

// matt.DisplayEmployeeDetails();
/*
matt.PerformWork();
matt.PerformWork();
matt.PerformWork(10);
matt.PerformWork();
*/

double receivedWageMatt = matt.ReceiveWage(true);

Console.WriteLine($"Wage paid (message from program): {receivedWageMatt}");

/*
// Object of derived class 
Dog vizsla = new Dog();
vizsla.name = "Flynn";

vizsla.display();

vizsla.getName();
*/

// provides us various methods to use in an array


int[] numbers = { 51, 1, 3, 4, 98 };

// get the minimum element
Console.WriteLine("Smallest  Element: " + numbers.Min());

// Max() returns the largest number in array
Console.WriteLine("Largest Element: " + numbers.Max());


// declare jagged array
int[ ][ ] jaggedArray = new int[2][ ];

// set size of the first array as 3
jaggedArray[0] = new int[3];

// set size of second array as 2
jaggedArray[1] = new int[2];

// initialize the first array
jaggedArray[0][0] = 1;
jaggedArray[0][1] = 3;
jaggedArray[0][2] = 5;

// initialize the second array
jaggedArray[1][0] = 2;
jaggedArray[1][1] = 4;

// Initialize while declaring Jagged Array
int[ ][ ] jaggedArray2 = {
    new int[ ] {10, 20, 30},
    new int[ ] {11, 22},
    new int[ ] {88, 99}
};

Console.WriteLine($"Jagged Array 2: {jaggedArray2}");