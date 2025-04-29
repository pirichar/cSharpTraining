Console.WriteLine("Hello");
Console.WriteLine("What do you want to do ?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();
switch (userChoice.ToUpper())
{
    case "S":
        PrintSelectedOpiton("See all TODOs");
        break;
    case "A":
        PrintSelectedOpiton("Add a todo");
        break;
    case "R":
        PrintSelectedOpiton("Remove a todo");
        break;
    case "E":
        PrintSelectedOpiton("Exit");
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;

}

void PrintSelectedOpiton(string option)
{
    Console.WriteLine($"Selected option: {option}");
}
Console.ReadKey();

