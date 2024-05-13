using Fase4ReneLozano.Opciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4ReneLozano
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EscenarioUno escenarioUno = new EscenarioUno();
            this.Hide();
            escenarioUno.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EscenarioDos escenarioDos = new EscenarioDos();
            this.Hide();
            escenarioDos.Show();
        }
    }
}
