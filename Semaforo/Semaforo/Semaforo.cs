using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class Semaforo : Form
    {
        // tipo de dato global 
        int contador;
        public Semaforo()
        {
            InitializeComponent();
        }

        private void timer_semaforo_Tick(object sender, EventArgs e)
        {
            contador = contador + 1;
            if (contador == 1) {
                btn_verde.BackColor = Color.Green;
            }
            if (contador == 8)
            {
                btn_verde.BackColor = Color.Black;
                btn_amarillo.BackColor = Color.Yellow;
            }
            if (contador == 10)
            {
                btn_amarillo.BackColor = Color.Black;
                btn_rojo.BackColor = Color.Red;
            }
            if (contador == 20)
            {
                btn_rojo.BackColor = Color.Black;
                contador = 0;
            }
        }

        private void Semaforo_Load(object sender, EventArgs e)
        { 

            // Se ejecuta el temporizador 
            timer_semaforo.Start();
            contador = 0;
        }

        private void btn_semaforo_Click(object sender, EventArgs e)
        {
            if(btn_semaforo.Text == "PARAR")
            {
                //Se detiene el temporizador 
                timer_semaforo.Stop();
                contador = 0;
                btn_verde.BackColor = Color.Black;
                btn_amarillo.BackColor = Color.Black;
                btn_rojo.BackColor = Color.Black;
                btn_semaforo.Text = "INICIAR";
            }

            else
            {
                timer_semaforo.Start();
                btn_semaforo.Text = "PARAR";

            }



        }

        private void btn_semaforo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
