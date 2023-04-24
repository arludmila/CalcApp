using CalcCore.Interfaces;
namespace CalcCore
{
    public class CalcNormal : ICalc
    {
        public EventHandler Procesando { get; set; }
        public EventHandler Termino { get; set; }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Divide(int x, int y)
        {
            if (y==0)
            {
                Console.WriteLine("¡No se puede dividir por cero!");
                return 0;
            }
            else
            {
                return x / y;
            }
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Substract(int x, int y)
        {
            return x - y;
        }
    }
}