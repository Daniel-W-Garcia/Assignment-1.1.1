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