using System.CodeDom;

namespace TorresDeHanoi
{
    public partial class Form1 : Form
    {
        private Torre _torre1;
        private Torre _torre2;
        private Torre _torre3;
        private Button? _discoSeleccionado;
        private int _cantidadMovimientos;

        public Form1()
        {
            InitializeComponent();

            _torre1 = new Torre(groupBoxTorre1);
            _torre2 = new Torre(groupBoxTorre2);
            _torre3 = new Torre(groupBoxTorre3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrearDiscos(2);

            groupBoxTorre1.Click += new EventHandler(groupBoxTorre_Click);
            groupBoxTorre2.Click += new EventHandler(groupBoxTorre_Click);
            groupBoxTorre3.Click += new EventHandler(groupBoxTorre_Click);
        }

        private void SubirDisco(Button disco)
        {
            disco.BackColor = Color.Green;
            disco.Location = new Point(disco.Location.X, disco.Location.Y - 30);
        }

        private void BajarDisco(Button disco)
        {
            disco.BackColor = Color.Blue;
            disco.Location = new Point(disco.Location.X, disco.Location.Y + 30);
        }

        private void buttonDisco_Click(object? sender, EventArgs e)
        {
            if (sender is Button disco)
            {
                if (_discoSeleccionado == null && (_torre1.EsElUltimoDisco(disco) || _torre2.EsElUltimoDisco(disco) || _torre3.EsElUltimoDisco(disco)))
                {
                    _discoSeleccionado = disco;
                    SubirDisco(_discoSeleccionado);
                }
                else
                {
                    if (_discoSeleccionado?.Name == disco.Name)
                    {
                        BajarDisco(_discoSeleccionado);
                        _discoSeleccionado = null;
                    }
                }
            }
        }

        private void CrearDiscos(int cantidadDiscos)
        {
            var inicial = new Button
            {
                Name = "Inicial",
                Enabled = false,
                Width = groupBoxTorre1.Width + 1
            };

            _torre1.AgregarDisco(inicial);
            _torre2.AgregarDisco(inicial);
            _torre3.AgregarDisco(inicial);

            for (int i = 0; i < cantidadDiscos; i++)
            {
                var disco = new Button
                {
                    Name = $"disco{cantidadDiscos - i}",
                    BackColor = Color.Blue,
                    Cursor = Cursors.Hand
                };

                int alto = ((cantidadDiscos - 400) * -1) / cantidadDiscos;
                int ancho = 375 - (i * (375 - alto)) / (cantidadDiscos - 1);
                disco.Size = new Size(ancho, alto);

                int centroEnX = groupBoxTorre1.Width / 2 - disco.Width / 2;
                int baseEnY = groupBoxTorre1.Height - alto - 40 - i * alto;
                disco.Location = new Point(centroEnX, baseEnY);

                disco.Click += new EventHandler(buttonDisco_Click);

                _torre1.AgregarDisco(disco);
            }
        }

        private void trackBarDiscos_Scroll(object sender, EventArgs e)
        {
            _torre1.LimpiarDiscos();
            _torre2.LimpiarDiscos();
            _torre3.LimpiarDiscos();

            labelCantidadDiscos.Text = trackBarDiscos.Value.ToString();
            labelMejor.Text = $"Mejor movimiento: {Math.Pow(2, trackBarDiscos.Value) - 1}";
            labelMovimientos.Text = "Movimientos: 0";

            CrearDiscos(trackBarDiscos.Value);
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            _cantidadMovimientos = 0;

            _torre1.LimpiarDiscos();
            _torre2.LimpiarDiscos();
            _torre3.LimpiarDiscos();

            _torre1.Desbloquear();
            _torre2.Desbloquear();
            _torre3.Desbloquear();

            trackBarDiscos.Value = Convert.ToInt32(labelCantidadDiscos.Text);

            labelMejor.Text = $"Mejor: {Math.Pow(2, trackBarDiscos.Value) - 1}";
            labelMovimientos.Text = "Movimientos: 0";
            labelGanador.Visible = false;

            CrearDiscos(trackBarDiscos.Value);
            _discoSeleccionado = null;
        }

        private string ObtenerTorreOrigen()
        {
            if (_discoSeleccionado != null)
            {
                bool existeTorre1 = _torre1.Discos.Any(d => d.Name == _discoSeleccionado.Name);
                if (existeTorre1)
                {
                    return "torre1";
                }

                bool existeTorre2 = _torre2.Discos.Any(d => d.Name == _discoSeleccionado.Name);
                if (existeTorre2)
                {
                    return "torre2";
                }

                bool existeTorre3 = _torre3.Discos.Any(d => d.Name == _discoSeleccionado.Name);
                if (existeTorre3)
                {
                    return "torre3";
                }
            }

            return string.Empty;
        }

        private bool ComprobarDiscoMenor(Button disco, GroupBox torreDestino)
        {
            if (torreDestino.Name == "groupBoxTorre1")
            {
                if (disco.Width > _torre1.Discos.Peek().Width)
                    return false;
            }
            else if (torreDestino.Name == "groupBoxTorre2")
            {
                if (disco.Width > _torre2.Discos.Peek().Width)
                    return false;
            }
            else if (torreDestino.Name == "groupBoxTorre3")
            {
                if (disco.Width > _torre3.Discos.Peek().Width)
                    return false;
            }
            return true;
        }

        private void AgregarDisco(GroupBox torreDestino, Button disco)
        {
            int centroEnX = groupBoxTorre1.Width / 2 - disco.Width / 2;
            int alto = ((trackBarDiscos.Value - 400) * -1) / trackBarDiscos.Value;

            if (torreDestino.Name == "groupBoxTorre1")
            {
                _torre1.AgregarDisco(disco);

                int baseEnY = groupBoxTorre1.Height - 70 - (groupBoxTorre1.Controls.Count * alto);
                disco.Location = new Point(centroEnX, baseEnY);
                BajarDisco(disco);
            }
            else if (torreDestino.Name == "groupBoxTorre2")
            {
                _torre2.AgregarDisco(disco);

                int baseEnY = groupBoxTorre2.Height - 70 - (groupBoxTorre2.Controls.Count * alto);
                disco.Location = new Point(centroEnX, baseEnY);
                BajarDisco(disco);
            }
            else if (torreDestino.Name == "groupBoxTorre3")
            {
                _torre3.AgregarDisco(disco);

                int baseEnY = groupBoxTorre3.Height - 70 - (groupBoxTorre3.Controls.Count * alto);
                disco.Location = new Point(centroEnX, baseEnY);
                BajarDisco(disco);
            }
        }

        private void groupBoxTorre_Click(object? sender, EventArgs e)
        {
            if (sender is GroupBox torreDestino)
            {
                if (_discoSeleccionado != null)
                {
                    string nombreTorreOrigen = ObtenerTorreOrigen();

                    if (_discoSeleccionado != null)
                    {
                        bool esDiscoMenor = ComprobarDiscoMenor(_discoSeleccionado, torreDestino);

                        if (esDiscoMenor) // No se puede colocar un disco grande sobre uno pequeño
                        {
                            switch (nombreTorreOrigen)
                            {
                                case "torre1":
                                    _torre1.EliminarUltimoDisco();
                                    break;
                                case "torre2":
                                    _torre2.EliminarUltimoDisco();
                                    break;
                                case "torre3":
                                    _torre3.EliminarUltimoDisco();
                                    break;
                            }

                            AgregarDisco(torreDestino, _discoSeleccionado);

                            _discoSeleccionado = null;
                            _cantidadMovimientos += torreDestino.Name == nombreTorreOrigen ? 0 : 1; // Si es la misma torre, no se cuenta el movimiento
                        }
                        else
                        {
                            MessageBox.Show("No se puede colocar un disco más grande que el de abajo", "Posicionamiento incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    ComprobarVictoria();
                    labelMovimientos.Text = $"Movimientos: {_cantidadMovimientos}";
                }
            }
        }

        private void ComprobarVictoria()
        {
            if (_torre3.Discos.Count - 1 == trackBarDiscos.Value)
            {
                labelGanador.Visible = true;
                _torre1.Bloquear();
                _torre2.Bloquear();
                _torre3.Bloquear();
                buttonReiniciar.Focus();
            }
        }
    }
}
