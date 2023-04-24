using CalcCore.Interfaces;
namespace CalcApp1
{
    public class Manager
    {
        private ICalc _calc { get; set; }
        public Manager(ICalc calc)
        {
            _calc = calc;
        }
        public void SetCalc(ICalc calc)
        {
            _calc = calc;
        }
        public void Print()
        {
            Console.WriteLine($"[App1] Add {_calc.Add(1, 1)}");
        }
    }
}
