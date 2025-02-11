Console.WriteLine("num : ");
if (int.TryParse(Console.ReadLine(), out int Num))
{
    int reversenum = 0;
    while (Num > 0)
    {
        reversenum = (reversenum * 10) + (Num % 10);
        Num = Num / 10;

    }
    Console.WriteLine(reversenum);
}
else
{
    Console.WriteLine("the input num is not Valide !");
}







