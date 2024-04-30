using System;

class Program
{
    static void Main(string[] args)
    {
        
        int result = AddNumbers(5, 7);
        Console.WriteLine("Результат сложения: " + result);

        string reversed = ReverseString("Hello");
        Console.WriteLine("Перевернутая строка: " + reversed);

        int factorial = CalculateFactorial(5);
        Console.WriteLine("Факториал числа 5: " + factorial);
    }

    
    public static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    
    public static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    
    public static int CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
}