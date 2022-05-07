using Alice;

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

AliceEngine ae = new();

string s = string.Empty;
while (s != "exit")
{
    Console.Write("> ");
    s = Console.ReadLine() ?? string.Empty;
    var tc = ae.Talk(s);
    Console.WriteLine(tc.Response);
    while (!tc.Expired)
    {
        Console.Write("TC> ");
        s = Console.ReadLine() ?? string.Empty;
        if (s == "exit")
            break;
        tc = ae.Talk(s);
        Console.WriteLine(tc.Response);
    }
}
