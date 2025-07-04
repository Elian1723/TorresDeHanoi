namespace TorresDeHanoi
{
    public partial class Form1 : Form
    {
        Stack<Button> torre1 = new Stack<Button>();
        Stack<Button> torre2 = new Stack<Button>();
        Stack<Button> torre3 = new Stack<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrearDiscos(2);
        }

        private void CrearDiscos(int cantidadDiscos)
        {
            var inicial = new Button();
            inicial.Name = "Inicial";
            inicial.Enabled = false;
            inicial.Width = groupBoxTorre1.Width + 1;

            torre1.Push(inicial);
            torre2.Push(inicial);
            torre3.Push(inicial);

            for (int i = 0; i < cantidadDiscos; i++)
            {
                var disco = new Button();
                disco.Name = $"disco{cantidadDiscos - i}";
                disco.BackColor = Color.Blue;
                disco.Cursor = Cursors.Hand;

                int alto = ((cantidadDiscos - 400) * -1) / cantidadDiscos;
                int ancho = 375 - (i * (375 - alto)) / (cantidadDiscos - 1);
                disco.Size = new Size(ancho, alto);

                int centroEnX = groupBoxTorre1.Width / 2 - disco.Width / 2;
                int baseEnY = groupBoxTorre1.Height - alto - 40 - i * alto;
                disco.Location = new Point(centroEnX, baseEnY);

                groupBoxTorre1.Controls.Add(disco);
                torre1.Push(disco);
            }
        }

        private void trackBarDiscos_Scroll(object sender, EventArgs e)
        {
            groupBoxTorre1.Controls.Clear();
            torre1.Clear();

            groupBoxTorre2.Controls.Clear();
            torre2.Clear();

            groupBoxTorre3.Controls.Clear();
            torre3.Clear();

            labelCantidadDiscos.Text = trackBarDiscos.Value.ToString();
            labelMejor.Text = $"Mejor movimiento: {Math.Pow(2, trackBarDiscos.Value) - 1}";
            labelMovimientos.Text = "Movimientos: 0";

            CrearDiscos(trackBarDiscos.Value);
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {

        }
    }
}
