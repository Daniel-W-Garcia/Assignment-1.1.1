string name;
int age;
string address;

Console.WriteLine("""
                  Enter your name:
                  """);

name = Console.ReadLine();
Console.WriteLine("""
                  Enter your age:
                  """);
age = int.Parse(Console.ReadLine());

Console.WriteLine("""
                  Enter your address:
                  """);
address = Console.ReadLine();



Console.WriteLine($"""
                  Hello, {name}
                  Your age is {age}
                  Your address is {address}
                  """);

Console.WriteLine("Now we add 2 numbers");
Console.WriteLine("Enter your first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your second number: ");
int num2 = int.Parse(Console.ReadLine());

int sum = num1 + num2;
Console.WriteLine($"The sum of {num1} and {num2} is {sum}");

Console.WriteLine("Here we will do some division");

Console.WriteLine("Enter your first number: ");
int num3 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your second number: ");
int num4 = int.Parse(Console.ReadLine());

int division = num3 / num4;
int remainder = num3 % num4;
Console.WriteLine($"The division of {num3} and {num4} is {division} and the remainder is {remainder}");