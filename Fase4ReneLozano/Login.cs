using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fase4ReneLozano
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(800, 500);
            password.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(password.Text == "UNAD"))
            {
                MessageBox.Show("¡Contraseña inválida!");
            }
            else
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
        }
    }
}
