using Calc.Superpower;
using CalcCore.Interfaces;

namespace CalcApp1
{
    public class Program
    {
        private static ICalc _calc;
        static void Main(string[] args)
        {
            _calc = new CalcSuperpower();
            var m = new Manager(_calc);
            //Console.WriteLine($"[App1] Add {_calc.Add(1,1)}");
            m.Print();
            m.SetCalc(new CalcCore.CalcNormal());
            m.Print();
            Console.ReadKey();
        }
    }
}