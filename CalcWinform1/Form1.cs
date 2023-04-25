using CalcCore.Interfaces;
using System.Collections.Specialized;
using System.Data;

namespace CalcWinform1
{
    public partial class Form1 : Form
    {
        private ICalc _calc;
        private OrderedDictionary _orderedDictionary = new OrderedDictionary();
        public Form1(ICalc calc)
        {
            _calc = calc;
            _calc.Procesando += Calc_Procesando_Demo;
            _calc.Termino += Calc_Termino_Demo;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Form1_Load(this, new EventArgs());
        }
        private void Calc_Procesando_Demo(object sender, EventArgs e)
        {

            labelEstado.Text = "Procesando....";
        }

        private void Calc_Termino_Demo(object sender, EventArgs e)
        {

            labelEstado.Text = "Termino!";
        }
        private void labelEstado_Click(object sender, EventArgs e)
        {

        }

        private void panelCalculadora_Paint(object sender, PaintEventArgs e)
        {
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            // Genera botones solo si esta vacio el panel
            if (_orderedDictionary.Count == 0)
            {
                // Genera los botones de numeros 0-9
                int num = 0;
                for (int i = 0 ; i < 5 ; i++)
                {
                    for (int j = 0 ; j < 2 ; j++)
                    {
                        var b = new Button();
                        b.Text = num.ToString();
                        b.Location = new Point(90 * j, 22 * i);
                        b.Click += buttonNums_Click;
                        panelCalculadora.Controls.Add(b);
                        _orderedDictionary.Add(num.ToString(), b);
                        num++;
                    }
                }
                // Genera los operadores matematicos
                string[] array = { "+", "-", "*", "/" };
                for (int i = 0 ; i < array.Length ; i++)
                {
                    var b = new Button();
                    b.Text = array[i];
                    b.Location = new Point(300, 22 * i);
                    b.Click += buttonNums_Click;
                    panelCalculadora.Controls.Add(b);
                    _orderedDictionary.Add(array[i], b);
                }
            }
            else
            {
                MessageBox.Show("¡Ya estan generados los botones!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            // Eliminando ultimo elemento, su busca el index del ultimo elemento y
            // se usa el boton de ese index para borrarlo del panel
            // se usa el index para borrarlo del diccionario
            if (_orderedDictionary.Count == 0)
            {
                MessageBox.Show("¡No hay botones para remover!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int ultimoElemento = _orderedDictionary.Count - 1;
                Button remover = (Button)_orderedDictionary[ultimoElemento];
                panelCalculadora.Controls.Remove(remover);
                _orderedDictionary.RemoveAt(ultimoElemento);
            }
        }
        // Sender --> objeto que genera el evento, boton presionado
        private void buttonNums_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            labelEstado.Text = btn.Text;
            textBoxProcesar.Text += btn.Text;
        }

        private void textBoxProcesar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelEstado.Dock = DockStyle.Bottom;
            labelEstado.AutoSize = false;
            labelEstado.Width = this.ClientSize.Width;
            textBoxProcesar.ReadOnly = true;
            this.Text = "CalcApp";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxProcesar.Clear();
        }
    }
}
