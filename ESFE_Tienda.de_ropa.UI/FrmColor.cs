using System;
using System.Data;
using System.Windows.Forms;
using ESFE_Tienda.de_ropa.LN;

namespace ESFE_Tienda.de_ropa.UI
{
    public partial class FrmColor : Form
    {
        private ColorLN colorLN = new ColorLN();

        public FrmColor()
        {
            InitializeComponent();
        }


        // =====================================================
        // BOTÓN LIMPIAR
        // =====================================================

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            textBox1.Focus();
        }


        // =====================================================
        // BOTÓN BUSCAR COLOR
        // =====================================================

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda =
                    textBox1.Text.Trim();

                DataTable datos =
                    colorLN.BuscarColor(busqueda);

                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];

                    // ID Color
                    textBox2.Text =
                        fila["IDColor"].ToString();

                    // Nombre del color
                    textBox3.Text =
                        fila["Nombre"].ToString();
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró ningún color.",
                        "Buscar color",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        // =====================================================
        // BOTÓN ELIMINAR COLOR
        // =====================================================

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda =
                    textBox4.Text.Trim();

                DialogResult respuesta =
                    MessageBox.Show(
                        "¿Está seguro de eliminar este color?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                {
                    return;
                }

                bool resultado =
                    colorLN.EliminarColor(busqueda);

                if (resultado)
                {
                    MessageBox.Show(
                        "Color eliminado correctamente.",
                        "Color",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró el color.",
                        "Eliminar color",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
