using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabla
{
    public partial class frm_tabla : Form
    {
        public frm_tabla()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            int ci = Convert.ToInt32(txt_ci.Text);
            string tipo = combo_tipo.Text;

            Random rand = new Random();
            int codigo = rand.Next(1, 101);

            //Agregar en orden
            dgv_tabla.Rows.Add(nombre, ci, tipo, codigo);

            //txt_nombre.Text = "";
            //txt_ci.Text = "";

            //Una manera
            //combo_tipo.Text = "";

            //Otra manera
            //combo_tipo.SelectedIndex = -1;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //Una forma
            /*DataGridViewRow fila = dgv_tabla.CurrentRow;

            if(fila != null)
            {
                fila.Cells[0].Value = txt_nombre.Text;
                fila.Cells[1].Value = txt_ci.Text;
                fila.Cells[2].Value = combo_tipo.Text;

            }*/

            //Otra froma
            dgv_tabla.CurrentRow.Cells[0].Value = txt_nombre.Text;
            dgv_tabla.CurrentRow.Cells[1].Value = txt_ci.Text;
            dgv_tabla.CurrentRow.Cells[2].Value = combo_tipo.Text;





        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            dgv_tabla.Rows.RemoveAt(dgv_tabla.CurrentRow.Index);
        }

        private void frm_tabla_Load(object sender, EventArgs e)
        {

        }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nombre.Text = dgv_tabla.CurrentRow.Cells[0].Value.ToString();
            txt_ci.Text = dgv_tabla.CurrentRow.Cells[1].Value.ToString();
            combo_tipo.Text = dgv_tabla.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
