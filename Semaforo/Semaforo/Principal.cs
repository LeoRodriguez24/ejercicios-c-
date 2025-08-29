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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Semaforo semaforo = new Semaforo();
            // Sirve para abrir la pantalla de Windows Form Semaforo
            semaforo.Show();


            // Sirve para ocultar la pantalla de Windows Form Principal
            //this.Hide();
        }
    }
}
