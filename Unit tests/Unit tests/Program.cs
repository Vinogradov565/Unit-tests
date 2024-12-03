using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число для преобразования в римскую цифру: ");
        int number;

        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0 || number > 3999)
        {
            Console.WriteLine("Введите целое число от 1 до 3999:");
        }

        string roman = ToRoman(number);
        Console.WriteLine($"Римское число: {roman}");
    }

    static string ToRoman(int number)
    {
        var romanNumerals = new (int Value, string Symbol)[]
        {
            (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
            (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
            (10, "X"), (9, "IX"), (5, "V"), (4, "IV"), (1, "I")
        };

        string result = string.Empty;

        foreach (var (value, symbol) in romanNumerals)
        {
            while (number >= value)
            {
                result += symbol;
                number -= value;
            }
        }

        return result;
    }
}
