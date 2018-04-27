using System;

namespace workspace2
{
    public class Vehicle
    {
        public int numPassengers;
        public double distance = 0.0;
        // Constructor
        // This tells us how to call an object of class Vehicle
        public Vehicle(int val = 0)
        {
            numPassengers = val;
        }
        public Vehicle(double odo, int val = 0)
        {
            numPassengers = val;
            distance = odo;
        }
        // Methods
        // A method of class Vehicle are functions that can be run on the object
        public void Move(double miles)
        {
            distance += miles;
        }
        public void GetInfo()
        {
            Console.WriteLine("This is just a basic Vehicle!");
            Console.WriteLine($"Currently has traveled {distance} miles");
        }
    }


    public class Car : Vehicle
    {
        public int NumberofWheels = 4;
        public string Condition;
        // Base is used to pass parameters to the parent class. In this case, it will send the parameter 5 to Vehicle class.
        // Since the parameter 5 is used to determine number of passengers in the parent class, this will inherit that constructor and set numPassenger = 5;
        public Car() : base(5)
        {
            Condition = "New";
        }
        public Car(double odo) : base(odo, 5)
        {
            Condition = "Used";
        }

        public new void GetInfo() // C# will use the methods of the childs instead of parent. Since GetInfo() exists in both Car (child) class and Vehicle (parent) class, it will use Car if the object is a car.
        // Be sure to include "new" in the defintion of the method.
        // If we wanted this sub method to inherit the code from its parent method, we just need to add base.method()
        {
            base.GetInfo(); // Now, anytime sub-class method is called, it will run the parent (or base) method first, then run the lines below.
            Console.WriteLine($"Car Condition: {Condition}");
        }
    }


    public class Parent 
    { 
        public void Speak() 
        {
            Console.WriteLine("I am a parent"); 
        }
    }
    public class Child : Parent
    { 
        public new void Speak() 
        { 
            Console.WriteLine("I am a child"); 
        }
    }
    public class GrandChild : Child
    { 
        public new void Speak() 
        {
            Console.WriteLine("I am a grandchild");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle(5);
            Vehicle bike = new Vehicle(1);            
            
            Console.WriteLine("My car can hold "+car.numPassengers+ " people.");
            Console.WriteLine("My bike can hold "+bike.numPassengers+ " people.");
            car.Move(21.23);
            Console.WriteLine(car.distance);

            Vehicle used_car = new Vehicle(50000,5);
            Console.WriteLine($"My car has {used_car.distance} mileage and can hold {used_car.numPassengers} people.");

            Car Mazda3 = new Car(123456);
            Console.WriteLine($"My Mazda3 has {Mazda3.distance} mileage and can seat {Mazda3.numPassengers}.");
            Mazda3.GetInfo();

            bike.GetInfo();

            // Polymorphism - You can create an object as its parent, but instantiate it as the child.
            // This only works going up towards the parent.
            GrandChild gc1 = new GrandChild();
            gc1.Speak();
            Parent gc2 = new GrandChild();
            gc2.Speak();

        }
    }
}
