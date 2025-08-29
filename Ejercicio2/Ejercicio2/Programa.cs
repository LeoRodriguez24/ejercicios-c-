using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class frm_programa : Form
    {
        public frm_programa()
        {
            InitializeComponent();
        }

        //Funcion que se Ejecutar cuando se compila el programa 
        private void frm_programa_Load(object sender, EventArgs e)
        {
            //lbl_principal.Text = "HOLA MUNDO";


            
            comboBox_operaciones.Items.Add("Secuencia de Numeros");
            comboBox_operaciones.Items.Add("Numeros Aleatorios");
            

        }

        private void btn_genenar_Click(object sender, EventArgs e)
        {
            listBox_numeros.Items.Clear();
            int numero = Convert.ToInt32(txt_numero.Text);
            string seleccionador = comboBox_operaciones.Text;
            if (seleccionador == "Secuencia de Numeros")
            {
                for (int i = 0; i <= numero; i++)
                {
                    listBox_numeros.Items.Add(i);
                }
            }
            
            if (seleccionador == "Numeros Aleatorios")
            {
                Random numeroAleatorio = new Random();
                for (int i = 0; i <= numero; i++)
                {
                    
                    listBox_numeros.Items.Add(numeroAleatorio.Next(0, 100));
                }

            }

        }
    }
}
