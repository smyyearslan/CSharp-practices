string name = "Ahmet";
string age = "30";

string message = name + " is " + age + " years old.";

Console.WriteLine(message);

int num = message.Length;

Console.WriteLine(num);

var start = message.StartsWith("B");

Console.WriteLine(start);

var location = message.IndexOf("is");

Console.WriteLine(location);

var now = DateTime.Now;

Console.WriteLine(now);

Console.WriteLine(now.Year);

Console.WriteLine(now.Month);