using System;

public class Program
{
    public static void Main()
    {
        //exercise 1
        Console.WriteLine("Hello, World!");

        //exercise 2
        Console.ReadLine();
        Console.WriteLine(Console.ReadLine());

        //exercise 3
        string productName = "TV";
        int productYear = 2012;
        float productPrice = 279.99f;
        decimal productPriceDecimal = 279.99M;
        double productPriceDouble = 279.99;

        Console.WriteLine("productName: " + productName);
        Console.WriteLine("productYear: " + productYear);
        Console.WriteLine("productPrice: " + productPrice);
        Console.WriteLine("productPriceDecimal: " + productPriceDecimal);
        Console.WriteLine("productPriceDouble: " + productPriceDouble);

        //exercise 4
        double myDBL = 99.0;
        Console.WriteLine(Convert.ToInt32(myDBL));

        //exercise 5
        int guess = 500;

        if (guess == 500)
        {
            Console.WriteLine("Success!");
        }

        //exercise 6
        string[] fruits = { "apple", "banana", "orange" };
        // test code
        Console.WriteLine(fruits[0]);
        Console.WriteLine(fruits[1]);
        Console.WriteLine(fruits[2]);

        //exercise 7
        List<int> primeNumbers = new List<int> { 2, 3, 5, 7, 11 };

        // test code
        Console.WriteLine(primeNumbers.Count);
        Console.WriteLine(primeNumbers[0]);
        Console.WriteLine(primeNumbers[1]);
        Console.WriteLine(primeNumbers[2]);
        Console.WriteLine(primeNumbers[3]);
        Console.WriteLine(primeNumbers[4]);

        //exercise 8
        Dictionary<string, long> inventory = new Dictionary<string, long>();
        inventory.Add("apple", 3);
        inventory.Add("orange", 5);
        inventory.Add("banana", 2);

        // test code
        Console.WriteLine(inventory["apple"]);
        Console.WriteLine(inventory["orange"]);
        Console.WriteLine(inventory["banana"]);

        //exercise 9
        string firstName = "John";
        string lastName = "Doe";
        int age = 27;

        // test code
        string sentence = $"{firstName} {lastName} is {age} years old.";

        Console.WriteLine(sentence);

        //exercise 10
        string x = "Hi";
        int n = 10;
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(x);
        }

        //exercise 11
        string[] parts = { "CPU", "RAM", "HDD", "SSD", "GPU" };

        foreach(string part in parts)
        {
            Console.WriteLine(part);
        }

        //exercise 12
        string a = "Hi";
        int b = 10;

        while (b > 0)
        {
            Console.WriteLine(a);
            b--;
        }

        //exercise 13

        int param1 = 2;
        int param2 = 2;
        int param3 = Foo(param1, param2);
        Console.WriteLine(param3);

        //exercise 14
        Car car1 = new();
        Car car2 = new();
        Car car3 = new();

        // test code
        Console.WriteLine(car1.NumTires);
        Console.WriteLine(car2.Year);
        Console.WriteLine(car3.Runs);

        //exercise 15 & 16
        Vehicle car = new("car", 4, 2000, true);
        Vehicle oldcar = new("car", 4, 1980, false);
        Vehicle bike = new("bike", 2, 2017, true);

        // test code
        Console.WriteLine(car.Type);
        Console.WriteLine(oldcar.Runs);
        Console.WriteLine(bike.NumTires);

        // test code
        Vehicle myRide = new();
        myRide.Type = "Motorcycle";
        myRide.NumTires = 2;
        Console.WriteLine(myRide.Type);
        Console.WriteLine(myRide.NumTires);
        myRide.Type = String.Empty;
        Console.WriteLine(myRide.Type);
        myRide.NumTires = 0;
        Console.WriteLine(myRide.NumTires);
    }
    
    //exercise 13
    private static int Foo(int param1, int param2)
    {
        return param1 / param2;
    }

    //exercise 14
    public class Car
    {
        public int NumTires { get; set; } = 4;
        public int Year { get; set; } = 2000;
        public bool Runs { get; set; } = true;
    }

    //exercises 15 & 16
    public class Vehicle
    {
        private string? _type;
        public string Type
        {
            get
            {
                return _type ?? "";
            }
            set
            {
                if (value == String.Empty)
                {
                    Console.WriteLine("The vehicle type cannot be empty");
                }
                _type = value;
            }
        }

        private int? _numTires;
        public int NumTires
        {
            get
            {
                return _numTires ?? 0;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("The vehicle must have at least one tire");
                }
                else _numTires = value;
            }
        }

        public int Year { get; set; } = 2000;
        public bool Runs { get; set; } = true;

        public Vehicle()
        {

        }

        public Vehicle(string type, int numTires)
        {
            Type = type;
            NumTires = numTires;
        }

        public Vehicle(string type, int numTires, int year, bool runs)
        {
            Type = type;
            NumTires = numTires;
            Year = year;
            Runs = runs;
        }
    }
}
