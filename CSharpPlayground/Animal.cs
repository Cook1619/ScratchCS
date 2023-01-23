namespace CSharpPlayground
{ 
    // base class
    public class Animal
    {
        public string name;

        public void display()
        {
            Console.WriteLine("This is an animal");
        }
    }

    // derived class of Animal
    public class Dog : Animal
    {
        public void getName()
        {
            Console.WriteLine($"My name is {name}");
        }
    }
}



