bool isTrue(bool x, bool y)
{
    bool a = !(x || y);
    bool b = !x & !y;
    return a.Equals(b);
}

bool x = true;
bool y = true;
Console.WriteLine($"x= {x}, y = {y}, !(x || y) == !x & !y = {isTrue(x, y)} ");

x = false;
y = true;
Console.WriteLine($"x= {x}, y = {y}, !(x || y) == !x & !y = {isTrue(x, y)} ");

x = true;
y = false;
Console.WriteLine($"x= {x}, y = {y}, !(x || y) == !x & !y = {isTrue(x, y)} ");

x = false;
y = false;
Console.WriteLine($"x= {x}, y = {y}, !(x || y) == !x & !y = {isTrue(x, y)} ");

