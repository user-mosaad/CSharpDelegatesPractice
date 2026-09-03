public delegate void LogMessage(string message);
public delegate void WriteNumber(int number);



class Program
{
    static void LogToConsole(string text) => Console.WriteLine($"Console: {text}");
    static void LogToFile(string text) => Console.WriteLine($"File Simulation: {text}");
    static void WriteANumber(int number) => Console.WriteLine($"Number: {number}");
    static void WriteANumberToFile(int number) => Console.WriteLine($"File Simulation: {number}");

    static void Main()
    {
        LogMessage logger = LogToConsole;
        logger += LogToFile;
        logger("Application started.");

        WriteNumber numberer = WriteANumber;
        numberer += WriteANumberToFile;
        numberer(42);

        // Generic delegates
        Action<string, int> print = (x, y) => Console.WriteLine($"{x} {y}");
        print("Hello World!", 13);

        Func<string, int, string> message = (x, y) => $"The number is {y} and the message is {x}";
        string result = message("Hello", 42);
        Console.WriteLine(result);

        Predicate<int> isOdd = x => x % 2 != 0;
        Console.WriteLine(isOdd(6));
    }
}
