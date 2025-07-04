using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresDeHanoi
{
    internal class Torre
    {
        private GroupBox _groupBox { get; set; }

        public Stack<Button> Discos { get; }

        public Torre(GroupBox groupBox)
        {
            _groupBox = groupBox;
            Discos = [];
        }

        public void AgregarDisco(Button disco)
        {
            Discos.Push(disco);
            _groupBox.Controls.Add(disco);
        }

        public Button EliminarUltimoDisco()
        {
            return Discos.Pop();
        }

        public void LimpiarDiscos()
        {
            Discos.Clear();
            _groupBox.Controls.Clear();
        }

        public bool EsElUltimoDisco(Button disco) => disco.Name == Discos.Peek().Name;

        public void Bloquear() => _groupBox.Enabled = false;

        public void Desbloquear() => _groupBox.Enabled = true;
    }
}
