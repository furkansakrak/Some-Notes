using System;

public class Example
{
    // Method 1: Bir int parametresi alır ve string döndürür
    public string example_1(int value)
    {
        return $"The value is {value}."; // Parametreyi string formatında döndürür.
    }

    // Method 2: Bir bool parametresi alır ve string döndürür
    public string example_2(bool flag)
    {
        return flag ? "Flag is true" : "Flag is false"; // Eğer flag true ise "Flag is true" döner, değilse "Flag is false" döner.
    }

    // Generic Method 3: Herhangi bir türde parametre alır ve aynı türde geri döner
    public T example_3<T>(T input)
    {
        return input; // Parametreyi olduğu gibi geri döndürür.
    }

    // Generic Method 4: Herhangi bir türde parametre alır ve string olarak geri döner
    public string example_4<T>(T input)
    {
        return $"You provided: {input.ToString()}"; // Parametrenin string halini döndürür.
    }
}

class Program
{
    static void Main(string[] args)
    {
        Example exp_1 = new Example();

        // example_1 metodu 22 parametresini alır ve geri dönüş olarak bir string döndürür.
        Console.WriteLine(exp_1.example_1(22)); // "The value is 22."

        // example_2 metodu false parametresini alır ve geri dönüş olarak bir string döndürür.
        Console.WriteLine(exp_1.example_2(false)); // "Flag is false"

        // example_3 metodu generic bir metottur. Burada bir string parametre geçilir ve geri dönüş de string olur.
        Console.WriteLine(exp_1.example_3<string>("FURKAN SAKRAK")); // "FURKAN SAKRAK"

        // example_3 metodu yine generic'tir. Burada double bir parametre geçilir ve geri dönüş de double olur.
        Console.WriteLine(exp_1.example_3<double>(1.50)); // 1.5

        // example_4 metodu generic'tir ve int türünde bir parametre alır. Parametrenin string formatında geri dönmesini sağlar.
        Console.WriteLine(exp_1.example_4<int>(30)); // "You provided: 30"

        // example_4 metodu string türünde bir parametre alır. Parametrenin string formatında geri dönmesini sağlar.
        Console.WriteLine(exp_1.example_4<string>("FURKAN SAKRAK")); // "You provided: FURKAN SAKRAK"
    }
}
