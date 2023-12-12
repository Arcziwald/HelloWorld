
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nazywam się Artur Mochnia");
        GreetUser("Artur");
    }

    private static void GreetUser(string firstAndLastName)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine($"Hello {firstAndLastName}");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
public interface IProgram
{

}