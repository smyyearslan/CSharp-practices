StreamReader sr = File.OpenText("deneme.txt");

var s = "";

while ((s = sr.ReadLine()) != null)
{
    Console.WriteLine(s);
}
sr.Close();


File.AppendAllText("deneme.txt", "cat");

using(StreamReader sr2 = File.OpenText("deneme.txt"))
{
    var a = "";

    while (( a= sr2.ReadLine())!= null)
    {
        Console.WriteLine(a);
    }
}