namespace CalcCore.Interfaces
{
    public interface ICalc
    {
        public EventHandler Procesando { get; set; }
        public EventHandler Termino { get; set; }
        int Add(int x, int y);
        int Substract(int x, int y);
        int Divide(int x, int y);
        int Multiply(int x, int y);
    }
}