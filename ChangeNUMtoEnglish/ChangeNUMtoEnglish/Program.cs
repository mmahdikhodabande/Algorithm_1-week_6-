class Program
{
    static string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    static string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    static string NumberToWords(int num)
    {
        if (num < 0 || num > 9999)
            throw new ArgumentOutOfRangeException("Number must be between 1 and 9999.");

        if (num == 0) return "Zero";
        if (num < 20) return ones[num];

        string words = "";

        if (num >= 1000)
        {
            words += ones[num / 1000] + " Thousand";
            num %= 1000;
            if (num > 0) words += " ";
        }

        if (num >= 100)
        {
            words += ones[num / 100] + " Hundred";
            num %= 100;
            if (num > 0) words += " ";
        }

        if (num >= 20)
        {
            words += tens[num / 10];
            num %= 10;
            if (num > 0) words += "-";
        }

        if (num > 0)
        {
            words += ones[num];
        }

        return words;
    }

    static void Main()
    {
        Console.Write("Enter a number (1-9999): ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"English: {NumberToWords(num)}");
    }
}


