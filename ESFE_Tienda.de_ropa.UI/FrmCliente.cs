using System;
using System.Data;
using System.Windows.Forms;
using ESFE_Tienda.de_ropa.LN;

namespace ESFE_Tienda.de_ropa.UI
{
    public partial class FrmCliente : Form
    {
        private ClienteLN clienteLN = new ClienteLN();

        public FrmCliente()
        {
            InitializeComponent();
        }

        // =====================================================
        // BUSCAR CLIENTE
        // =====================================================

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = textBox1.Text.Trim();

                DataTable datos = clienteLN.BuscarCliente(busqueda);

                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];

                    // ID Cliente
                    textBox9.Text = fila["IDCliente"].ToString();

                    // Nombre
                    textBox8.Text = fila["Nombre"].ToString();

                    // DUI
                    textBox2.Text = fila["DUI"].ToString();

                    // Teléfono
                    textBox3.Text = fila["Telefono"].ToString();

                    // Correo
                    textBox4.Text = fila["Correo"].ToString();

                    // ID Rol
                    textBox5.Text = fila["IDRol"].ToString();

                    // ID Permiso
                    textBox6.Text = fila["IDPermiso"].ToString();

                    // ID Estado
                    textBox7.Text = fila["IDEstado"].ToString();
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró ningún cliente.",
                        "Buscar cliente",
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
        // LIMPIAR CAMPOS
        // =====================================================

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

            textBox8.Focus();
        }


        // =====================================================
        // AGREGAR CLIENTE
        // =====================================================

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBox8.Text.Trim();
                string dui = textBox2.Text.Trim();
                string telefono = textBox3.Text.Trim();
                string correo = textBox4.Text.Trim();

                int idRol;
                int idPermiso;
                int idEstado;

                // Validar ID Rol
                if (!int.TryParse(textBox5.Text.Trim(), out idRol))
                {
                    MessageBox.Show(
                        "El ID Rol debe ser un número.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    textBox5.Focus();
                    return;
                }

                // Validar ID Permiso
                if (!int.TryParse(textBox6.Text.Trim(), out idPermiso))
                {
                    MessageBox.Show(
                        "El ID Permiso debe ser un número.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    textBox6.Focus();
                    return;
                }

                // Validar ID Estado
                if (!int.TryParse(textBox7.Text.Trim(), out idEstado))
                {
                    MessageBox.Show(
                        "El ID Estado debe ser un número.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    textBox7.Focus();
                    return;
                }

                bool resultado = clienteLN.AgregarCliente(
                    nombre,
                    dui,
                    telefono,
                    correo,
                    idRol,
                    idPermiso,
                    idEstado
                );

                if (resultado)
                {
                    MessageBox.Show(
                        "Cliente agregado correctamente.",
                        "Clientes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo agregar el cliente.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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
        // ELIMINAR CLIENTE
        // =====================================================

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = textBox10.Text.Trim();

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este cliente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                {
                    return;
                }

                bool resultado =
                    clienteLN.EliminarCliente(busqueda);

                if (resultado)
                {
                    MessageBox.Show(
                        "Cliente eliminado correctamente.",
                        "Clientes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró el cliente.",
                        "Eliminar",
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


        // =====================================================
        // EVENTO LABEL CLIENTES
        // =====================================================

        private void label1_Click_1(object sender, EventArgs e)
        {
        }
    }
}