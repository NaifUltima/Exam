public class Program
{
    static void Main()
    {
        string UserInput;
        Console.WriteLine("What is youre grade?");
        UserInput = Console.ReadLine();
        
        if(UserInput == "A" ) 
        {
            Console.WriteLine("Excellent");
        }
        else if(UserInput == "B")
        {
            Console.WriteLine("Very good");
        }
        else if(UserInput == "C")
        {
            Console.WriteLine("Good");
        }
        else if(UserInput == "D")
        {
            Console.WriteLine("Needs Improvment");
        }
        else if(UserInput == "F")
        {
            Console.WriteLine("Fail");
        }
    }
}