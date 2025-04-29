// See https://aka.ms/new-console-template for more information

string input1;
string input2;
int nmb1;
int nmb2;
int rtn = 0;
char Operation = '\0';

// first input
Console.WriteLine("Hello! \nInput the first number: ");
input1 = Console.ReadLine();
try{
    nmb1 = Int32.Parse(input1);
}
catch (FormatException) {
    return; 
}

// second input
Console.WriteLine("Input the second number: ");
input2 = Console.ReadLine();
try
{
    nmb2 = Int32.Parse(input2);
}
catch (FormatException)
{
    return;
}

//type chose
Console.WriteLine("[a]dd numbers?");
Console.WriteLine("[s]ubstract numbers?");
Console.WriteLine("[m]ultiply numbers]");
string calcul = Console.ReadLine();
if (calcul != null)
{
    switch (calcul.ToUpper())
    {
        case "A":
            Operation = '+';
            rtn = (nmb1 + nmb2);
            break;
        case "S":
            Operation = '-';
            rtn = (nmb1 - nmb2);
            break;
        case "M":
            Operation = '*';
            rtn = (nmb1 * nmb2);
            break;
        default:
            Console.WriteLine("invalid option");
            Console.WriteLine("Press anykey to leave");
            Console.ReadLine();
            return;
    }
    Console.WriteLine($"{nmb1}{Operation}{nmb2}={rtn}");
}
else
{
    Console.WriteLine("Please provide a functionnal input");
    return ;
}

Console.WriteLine("Press anykey to leave");
Console.ReadKey();





