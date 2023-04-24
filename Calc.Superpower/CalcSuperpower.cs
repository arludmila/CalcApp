using CalcCore.Interfaces;

namespace Calc.Superpower
{
    public class CalcSuperpower : ICalc
    {
        public EventHandler Procesando { get; set; }
        public EventHandler Termino { get; set; }
        public int Add(int x, int y)
        {
            if (Procesando != null)
            {
                Procesando.Invoke(this, new EventArgs());
            }

            var resultado = x + y + 10000;
            if (Termino != null)
            {
                Termino.Invoke(this, new EventArgs());
            }
            return resultado;
        }

        public int Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("¡No se puede dividir por cero!");
                return 0;
            }
            else
            {
                return x / y + 10000;
            }
        }
            

        public int Multiply(int x, int y)
        {
            return x * y + 10000;
        }

        public int Substract(int x, int y)
        {
            return x - y + 10000;
        }
    }
}