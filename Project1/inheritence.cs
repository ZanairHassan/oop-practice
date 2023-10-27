using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class inheritence
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public inheritence(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;

        }
        public void Start()
        {
            Console.WriteLine("Engine started.");
        }
        public void Stop()
        {
            Console.WriteLine("Engine stopped.");
        }
    }
    //subclass 
    public class Car:inheritence
    {
        public Car(string make, string model, int year):base(make,model, year)
        { 
        }
        public void Accelerate()
        {
            Console.WriteLine("Car is accelerating.");
        }
    }
    //subclass 2
    public class Motercycle:inheritence
    {
        public Motercycle(string make, string model, int year):base (make, model,year)
        {

        }
        public void Wheelie()
        {
            Console.WriteLine("Motercycle is doing a wheelie.");
        }
    }

    public class Program1
    {
        static void Main()
        {
            Car myCar = new Car("Toyota", "Camry", 2020);
            Motercycle mymotercycle = new Motercycle("haley-davidson", "sport", 2023);
            myCar.Start();
            myCar.Accelerate();
            myCar.Stop();

            mymotercycle.Start();
            mymotercycle.Wheelie();
            mymotercycle.Stop();

            abstraction circle = new Circle(5.0);
            abstraction ractangle = new Rectangle(4.00, 6.00);
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            circle.Draw();
            Console.WriteLine($"Ractengle area: {ractangle.CalculateArea()}");

            ractangle.Draw();


            encapsulation account = new encapsulation("Jhon Doe", 1000.00);
            Console.WriteLine($"Account holder :{account.GetAccountHolder()}");
            Console.WriteLine($"initial balance: ${account.GetBalance()}");

            account.Deposit(500.00);
            account.Withdraw(200.00);
            Console.WriteLine("$Final balance: ${amount.Getbalance()}");

        }
    }

}
