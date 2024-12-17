public class Program
{
    static void Main()
    {
        int UserInput1 = int.Parse(Console.ReadLine());
        int UserInput2 = int.Parse(Console.ReadLine());

        if( UserInput1> UserInput2)
        {
            Console.WriteLine($"{UserInput1} is larger");
        }
        else if (UserInput1 < UserInput2)
        {
            Console.WriteLine($"{UserInput2} is larger");
        }

    }
}