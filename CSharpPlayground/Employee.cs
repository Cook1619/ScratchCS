using System;

namespace CSharpPlayground
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        private const int minimalHoursWorkedUnit = 1;

        // the this keyword is pointing to the constructor below
        public Employee(string first, string last, string em, DateTime bd): this(first,last,em,bd, 0)
        {
        }

        public Employee(string first, string last, string em, DateTime bd, double rate)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDay = bd;
            hourlyRate = rate;
        }

        // Having 2 methods or 2 constructors is normal in C# as long as there performing something different, in this case one accepts arguments, one doesn't
        public string PerformWork()
        {
            return PerformWork(minimalHoursWorkedUnit);
        }
        public string PerformWork(int numberOfHours)
        {
            numberOfHoursWorked++;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s)!");
            return $"{firstName} {lastName} has worked for {numberOfHours} hour(s)!";
        }

        public double ReceiveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;
            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");

            if (resetHours) numberOfHoursWorked = 0;
            return wage;
        }

        public string DisplayEmployeeDetails()
        {
            Console.WriteLine($"First name: {firstName}\nLast name: {lastName}\nEmail: {email}\nBirthday: {birthDay.ToShortDateString()}");
            return
                $"First name: {firstName}\nLast name: {lastName}\nEmail: {email}\nBirthday: {birthDay.ToShortDateString()}";
        }
    }
}
