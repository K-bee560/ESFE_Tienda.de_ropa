using System;
using System.Data;
using System.Windows.Forms;
using ESFE_Tienda.de_ropa.EN;
using ESFE_Tienda.de_ropa.DAL;

namespace ESFE_Tienda.de_ropa.UI
{
    public partial class FrmBitacora : Form
    {
        private BitacoraDAL bitacoraDAL = new BitacoraDAL();

        public FrmBitacora()
        {
            InitializeComponent();
        }

        // ==========================================
        // CARGAR FORMULARIO
        // ==========================================
        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            textBox5.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        // ==========================================
        // BOTÓN BUSCAR
        // ==========================================
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show(
                        "Escribe el ID de actividad.",
                        "Buscar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                int idActividad = Convert.ToInt32(textBox1.Text);

                BitacoraEN bitacora = bitacoraDAL.Buscar(idActividad);

                if (bitacora != null)
                {
                    textBox2.Text = bitacora.IDActividad.ToString();
                    textBox3.Text = bitacora.Accion;
                    textBox4.Text = bitacora.IDUsuario.ToString();
                    textBox5.Text = bitacora.FechaHora.ToString("yyyy-MM-dd HH:mm:ss");

                    MessageBox.Show(
                        "Registro encontrado.",
                        "Buscar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró ningún registro con ese ID.",
                        "Buscar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "El ID debe ser un número.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // BOTÓN AGREGAR REGISTRO
        // ==========================================
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show(
                        "Completa todos los campos.",
                        "Datos incompletos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                BitacoraEN bitacora = new BitacoraEN();

                bitacora.IDActividad = Convert.ToInt32(textBox2.Text);
                bitacora.Accion = textBox3.Text;
                bitacora.IDUsuario = Convert.ToInt32(textBox4.Text);

                DateTime fecha;

                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    fecha = DateTime.Now;
                }
                else
                {
                    fecha = Convert.ToDateTime(textBox5.Text);
                }

                bitacora.FechaHora = fecha;

                bool resultado = bitacoraDAL.Agregar(bitacora);

                if (resultado)
                {
                    MessageBox.Show(
                        "Registro agregado correctamente.",
                        "Bitácora",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo agregar el registro.",
                        "Bitácora",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "ID Actividad e ID Usuario deben ser números.",
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al agregar el registro:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // BOTÓN VER LISTA
        // ==========================================
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = bitacoraDAL.ObtenerTodos();

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No existen registros en la bitácora.",
                        "Bitácora",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }

                Form ventana = new Form();

                ventana.Text = "Lista de Bitácora - Administrador";
                ventana.StartPosition = FormStartPosition.CenterScreen;
                ventana.Size = new System.Drawing.Size(800, 450);
                ventana.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);

                DataGridView dgv = new DataGridView();

                dgv.Dock = DockStyle.Fill;
                dgv.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgv.ReadOnly = true;
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;

                dgv.DataSource = tabla;

                ventana.Controls.Add(dgv);

                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al mostrar la lista:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        // ==========================================
        // BOTÓN ELIMINAR
        // ==========================================
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show(
                        "Escribe o busca el ID de actividad que deseas eliminar.",
                        "Eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                int idActividad = Convert.ToInt32(textBox2.Text);

                DialogResult resultado = MessageBox.Show(
                    "¿Estás seguro de eliminar este registro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    bool eliminado = bitacoraDAL.Eliminar(idActividad);

                    if (eliminado)
                    {
                        MessageBox.Show(
                            "Registro eliminado correctamente.",
                            "Bitácora",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se encontró el registro.",
                            "Eliminar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "El ID Actividad debe ser un número.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // LIMPIAR CAMPOS
        // ==========================================
        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            textBox5.Text =
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        // ==========================================
        // LABEL 4
        // ==========================================
        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}