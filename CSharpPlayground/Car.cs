namespace CSharpPlayground;

// outer class
public class Car {

    public void displayCar() {
        Console.WriteLine("Car: Bugatti");
    }
 
    // inner class
    public class Engine {
        public void displayEngine() {
            Console.WriteLine("Engine: Petrol Engine");
        }
    }
}
class Program {
    static void Main(string[] args) {

        // create object of outer class
        Car sportsCar = new Car();

        // access method of outer class
        sportsCar.displayCar();
 
        // create object of inner class
        Car.Engine petrolEngine = new Car.Engine();
      
        // access member of inner class
        petrolEngine.displayEngine();
 
        Console.ReadLine();
 
    }
}