public class Program
{
    static void Main()
    {
        Console.WriteLine("Write 5 numbers to get the average");
        int[] Numbers = [5];
        for(int i= 0; i < 5; i++ )
        {
        int.Parse(Console.ReadLine());
        Console.WriteLine(Numbers[i]);
        }
        
    }
}