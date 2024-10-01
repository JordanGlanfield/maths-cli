List<string> commands = ["greet", "echo", "sum"];

Console.WriteLine("[{0}]", string.Join(", ", args));

if (args.Length <= 0)
{
    Console.WriteLine("Please provide a command");
    return 0;
}

var command = args[0];

if (commands.IndexOf(command) < 0)
{
    Console.WriteLine("Unrecognised command");
    return 0;
}

Console.WriteLine($"At some point I will implement '{command}', hahah");

return 0;