Console.Write("Введите трехзначное число: ");
String number = Console.ReadLine();
if (Convert.ToInt32(number) >= 100 & Convert.ToInt32(number) <= 999)
{
    Console.WriteLine(number[0]+""+number[2]);
}
else
{
    Console.WriteLine("Число не трехзначное");
}