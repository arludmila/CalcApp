using CalcCore;

namespace CalcApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var c = new CalcNormal();
            Console.WriteLine($"[App2] Add {c.Add(1, 1)}");
            Console.ReadKey();
        }
    }
}