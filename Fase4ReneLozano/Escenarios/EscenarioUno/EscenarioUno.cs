using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4ReneLozano.Opciones
{
    public partial class EscenarioUno : Form
    {
        private Graphics arbol, ordenamiento;
        private Boolean dibujado, arbolHecho= false;


        public EscenarioUno()
        {
            InitializeComponent();
            InitializeNavbar();
            this.Size = new System.Drawing.Size(900, 600);
            ordenamiento = CreateGraphics();
            arbol= CreateGraphics();
        }

        private void InitializeNavbar()
        {

            ToolStripButton btnGrafica = new ToolStripButton("Grafica");
            ToolStripButton btnRegresar = new ToolStripButton("Salir");

            ToolStripDropDownButton btnRecorridos = new ToolStripDropDownButton("Recorridos");
            ToolStripMenuItem menuItem1PreOrden = new ToolStripMenuItem("PreOrden");
            ToolStripMenuItem menuItem2InOrden = new ToolStripMenuItem("InOrden");
            ToolStripMenuItem menuItem3PostOrden = new ToolStripMenuItem("PostOrden");
            menuItem1PreOrden.Click += (sender, e) => { dibujarPreOrden(); };
            menuItem2InOrden.Click += (sender, e) => { dibujarInOrden(); };
            menuItem3PostOrden.Click += (sender, e) => { dibujarPostOrden(); };
            btnRecorridos.DropDownItems.AddRange(new ToolStripItem[] { menuItem1PreOrden, menuItem2InOrden, menuItem3PostOrden });

            toolStrip1.Items.AddRange(new ToolStripItem[] { btnGrafica, btnRecorridos, btnRegresar });

            btnRegresar.Click += (sender, e) => { regresar(); };
            btnGrafica.Click += (sender, e) => { renderizarGrafica(); };

        }


        private void regresar()
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void renderizarGrafica()
        {            
            arbol.FillEllipse(Brushes.Blue, 385, 30, 35, 35);
            arbol.DrawString("50", Font, Brushes.White, 395, 40);

            dibujarSubArbolIzquierdo();
            dibujarSubArbolDerecho();
            arbolHecho = true;
        }

        private void dibujarSubArbolIzquierdo()
        {
           
            //Subarbol izquerido
            arbol.FillEllipse(Brushes.Blue, 200, 90, 35, 35);
            arbol.DrawString("40", Font, Brushes.White, 210, 100);

            arbol.FillEllipse(Brushes.Blue, 100, 140, 35, 35);
            arbol.DrawString("30", Font, Brushes.White, 110, 150);

            arbol.FillEllipse(Brushes.Blue, 300, 140, 35, 35);
            arbol.DrawString("45", Font, Brushes.White, 310, 150);


            arbol.FillEllipse(Brushes.Blue, 10, 190, 35, 35);
            arbol.DrawString("25", Font, Brushes.White, 20, 200);

            arbol.FillEllipse(Brushes.Blue, 170, 190, 35, 35);
            arbol.DrawString("35", Font, Brushes.White, 180, 200);


            arbol.FillEllipse(Brushes.Blue, 230, 190, 35, 35);
            arbol.DrawString("42", Font, Brushes.White, 240, 200);


            //Conexiones de lineas
            Pen linea1 = new Pen(Color.Black, 2);
            arbol.DrawLine(linea1, 385, 45, 210, 92);
            arbol.DrawLine(linea1, 210, 120, 130, 150);
            arbol.DrawLine(linea1, 100, 160, 30, 190);
            arbol.DrawLine(linea1, 230, 120, 300, 150);
            arbol.DrawLine(linea1, 300, 160, 245, 190);
            arbol.DrawLine(linea1, 130, 160, 180, 190);

        }

        private void dibujarSubArbolDerecho()
        {            

            //Nodo Raiz
            arbol.FillEllipse(Brushes.Blue, 570, 90, 35, 35);
            arbol.DrawString("60", Font, Brushes.White, 580, 100);

            arbol.FillEllipse(Brushes.Blue, 470, 140, 35, 35);
            arbol.DrawString("55", Font, Brushes.White, 480, 150);

            arbol.FillEllipse(Brushes.Blue, 670, 140, 35, 35);
            arbol.DrawString("70", Font, Brushes.White, 680, 150);

            arbol.FillEllipse(Brushes.Blue, 570, 190, 35, 35);
            arbol.DrawString("65", Font, Brushes.White, 580, 200);

            arbol.FillEllipse(Brushes.Blue, 770, 190, 35, 35);
            arbol.DrawString("75", Font, Brushes.White, 780, 200);

            Pen linea1 = new Pen(Color.Black, 2);
            arbol.DrawLine(linea1, 420, 45, 570, 100);
            arbol.DrawLine(linea1, 570, 110, 485, 140);
            arbol.DrawLine(linea1, 605, 110, 685, 140);
            arbol.DrawLine(linea1, 670, 155, 585, 190);
            arbol.DrawLine(linea1, 705, 155, 770, 200);
        }

        private void dibujarPreOrden()
        {            
            if (dibujado)
            {
                ordenamiento.Clear(Color.White);
            }
            ordenamiento.DrawString("PreOrden", Font, Brushes.Black, 50, 350);

            ordenamiento.FillEllipse(Brushes.Red, 120, 340, 35, 35);
            ordenamiento.DrawString("50", Font, Brushes.White, 130, 350);

            ordenamiento.FillEllipse(Brushes.Red, 160, 340, 35, 35);
            ordenamiento.DrawString("40", Font, Brushes.White, 170, 350);

            ordenamiento.FillEllipse(Brushes.Red, 200, 340, 35, 35);
            ordenamiento.DrawString("30", Font, Brushes.White, 210, 350);

            ordenamiento.FillEllipse(Brushes.Red, 240, 340, 35, 35);
            ordenamiento.DrawString("25", Font, Brushes.White, 250, 350);

            ordenamiento.FillEllipse(Brushes.Red, 280, 340, 35, 35);
            ordenamiento.DrawString("35 ", Font, Brushes.White, 290, 350);

            ordenamiento.FillEllipse(Brushes.Red, 320, 340, 35, 35);
            ordenamiento.DrawString("45", Font, Brushes.White, 330, 350);

            ordenamiento.FillEllipse(Brushes.Red, 360, 340, 35, 35);
            ordenamiento.DrawString("42", Font, Brushes.White, 370, 350);

            ordenamiento.FillEllipse(Brushes.Red, 400, 340, 35, 35);
            ordenamiento.DrawString("60", Font, Brushes.White, 410, 350);

            ordenamiento.FillEllipse(Brushes.Red, 440, 340, 35, 35);
            ordenamiento.DrawString("55", Font, Brushes.White, 450, 350);

            ordenamiento.FillEllipse(Brushes.Red, 480, 340, 35, 35);
            ordenamiento.DrawString("70", Font, Brushes.White, 490, 350);

            ordenamiento.FillEllipse(Brushes.Red, 520, 340, 35, 35);
            ordenamiento.DrawString("65", Font, Brushes.White, 530, 350);

            ordenamiento.FillEllipse(Brushes.Red, 560, 340, 35, 35);
            ordenamiento.DrawString("75", Font, Brushes.White, 570, 350);

            dibujado = true;
            if (arbolHecho) {
                this.renderizarGrafica();
            }
        }

        private void dibujarInOrden()
        {            
            if (dibujado)
            {
                ordenamiento.Clear(Color.White);
            }
            ordenamiento.DrawString("InOrden", Font, Brushes.Black, 50, 350);

            ordenamiento.FillEllipse(Brushes.Red, 120, 340, 35, 35);
            ordenamiento.DrawString("25", Font, Brushes.White, 130, 350);

            ordenamiento.FillEllipse(Brushes.Red, 160, 340, 35, 35);
            ordenamiento.DrawString("30", Font, Brushes.White, 170, 350);

            ordenamiento.FillEllipse(Brushes.Red, 200, 340, 35, 35);
            ordenamiento.DrawString("35", Font, Brushes.White, 210, 350);

            ordenamiento.FillEllipse(Brushes.Red, 240, 340, 35, 35);
            ordenamiento.DrawString("40", Font, Brushes.White, 250, 350);

            ordenamiento.FillEllipse(Brushes.Red, 280, 340, 35, 35);
            ordenamiento.DrawString("42", Font, Brushes.White, 290, 350);

            ordenamiento.FillEllipse(Brushes.Red, 320, 340, 35, 35);
            ordenamiento.DrawString("45", Font, Brushes.White, 330, 350);

            ordenamiento.FillEllipse(Brushes.Red, 360, 340, 35, 35);
            ordenamiento.DrawString("50", Font, Brushes.White, 370, 350);

            ordenamiento.FillEllipse(Brushes.Red, 400, 340, 35, 35);
            ordenamiento.DrawString("55", Font, Brushes.White, 410, 350);

            ordenamiento.FillEllipse(Brushes.Red, 440, 340, 35, 35);
            ordenamiento.DrawString("60", Font, Brushes.White, 450, 350);

            ordenamiento.FillEllipse(Brushes.Red, 480, 340, 35, 35);
            ordenamiento.DrawString("65", Font, Brushes.White, 490, 350);

            ordenamiento.FillEllipse(Brushes.Red, 520, 340, 35, 35);
            ordenamiento.DrawString("70", Font, Brushes.White, 530, 350);

            ordenamiento.FillEllipse(Brushes.Red, 560, 340, 35, 35);
            ordenamiento.DrawString("75", Font, Brushes.White, 570, 350);

            dibujado = true;
            if (arbolHecho)
            {
                this.renderizarGrafica();
            }
        }

        private void dibujarPostOrden()
        {            
            if (dibujado)
            {
                ordenamiento.Clear(Color.White);
            }
            ordenamiento.DrawString("PostOrden", Font, Brushes.Black, 50, 350);

            ordenamiento.FillEllipse(Brushes.Red, 120, 340, 35, 35);
            ordenamiento.DrawString("25", Font, Brushes.White, 130, 350);

            ordenamiento.FillEllipse(Brushes.Red, 160, 340, 35, 35);
            ordenamiento.DrawString("35", Font, Brushes.White, 170, 350);

            ordenamiento.FillEllipse(Brushes.Red, 200, 340, 35, 35);
            ordenamiento.DrawString("30", Font, Brushes.White, 210, 350);

            ordenamiento.FillEllipse(Brushes.Red, 240, 340, 35, 35);
            ordenamiento.DrawString("42", Font, Brushes.White, 250, 350);

            ordenamiento.FillEllipse(Brushes.Red, 280, 340, 35, 35);
            ordenamiento.DrawString("45", Font, Brushes.White, 290, 350);

            ordenamiento.FillEllipse(Brushes.Red, 320, 340, 35, 35);
            ordenamiento.DrawString("40", Font, Brushes.White, 330, 350);

            ordenamiento.FillEllipse(Brushes.Red, 360, 340, 35, 35);
            ordenamiento.DrawString("55", Font, Brushes.White, 370, 350);

            ordenamiento.FillEllipse(Brushes.Red, 400, 340, 35, 35);
            ordenamiento.DrawString("65", Font, Brushes.White, 410, 350);

            ordenamiento.FillEllipse(Brushes.Red, 440, 340, 35, 35);
            ordenamiento.DrawString("75", Font, Brushes.White, 450, 350);

            ordenamiento.FillEllipse(Brushes.Red, 480, 340, 35, 35);
            ordenamiento.DrawString("70", Font, Brushes.White, 490, 350);

            ordenamiento.FillEllipse(Brushes.Red, 520, 340, 35, 35);
            ordenamiento.DrawString("60", Font, Brushes.White, 530, 350);

            ordenamiento.FillEllipse(Brushes.Red, 560, 340, 35, 35);
            ordenamiento.DrawString("50", Font, Brushes.White, 570, 350);

            dibujado = true;
            if (arbolHecho)
            {
                this.renderizarGrafica();
            }
        }



    }
}
