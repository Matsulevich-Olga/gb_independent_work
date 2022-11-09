Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int max_digit = 0;
int second_digit = 0;
if (number >= 10 & number <= 99)
{
    max_digit = number % 10;
    second_digit = number / 10;
    if (max_digit < second_digit)
    {
        max_digit = second_digit;
    }
    Console.WriteLine("Max Digit is " + max_digit);
}
else
{
    Console.WriteLine("Wrong number");
}
