
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Program
{
    public static void Main(string[] args)
    {
        Main(args, Console.WriteLine("Nazywam się Artur Mochnia"));
    }

    public static void Main(string[] args, void v)
    {
        string firstAndLastName = "Artur";
        Console.WriteLine("Hello, World!");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
public interface IProgram
{

}