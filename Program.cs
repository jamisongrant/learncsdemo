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
        Console.WriteLine(car1.numTires);
        Console.WriteLine(car2.year);
        Console.WriteLine(car3.runs);
    }
    
    //exercise 13
    private static int Foo(int param1, int param2)
    {
        return param1 / param2;
    }

    //exercise 14
    public class Car
    {
        public int numTires { get; set; } = 4;
        public int year { get; set; } = 2000;
        public bool runs { get; set; } = true;
    }

}
