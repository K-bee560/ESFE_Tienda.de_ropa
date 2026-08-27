using ESFE_Tienda.de_ropa.EN;
using ESFE_Tienda.de_ropa.LN;

namespace ESFE_Tienda.de_ropa.UI
{
    public partial class FrmTela : Form
    {
        private readonly TelaLN telaLN;

        public FrmTela()
        {
            InitializeComponent();

            telaLN = new TelaLN();

            // Eventos de los botones
            btnBuscar.Click += btnBuscar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
        }

        // =====================================================
        // BOTÓN BUSCAR
        // =====================================================

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoTela.Text.Trim();

                Tela tela = telaLN.BuscarPorCodigo(codigo);

                if (tela == null)
                {
                    MessageBox.Show(
                        "No se encontró una tela con ese código.",
                        "Tela no encontrada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();

                    txtCodigoTela.Focus();

                    return;
                }

                // Mostrar información
                txtCodigoTela.Text = tela.CodigoTela;
                txtTipoTela.Text = tela.TipoTela;
                txtColor.Text = tela.Color;
                txtPrecioMetro.Text =
                    tela.PrecioMetro.ToString("0.00");
                txtStockMetros.Text =
                    tela.StockMetros.ToString("0.00");
                txtEstado.Text = tela.Estado;
                txtDescripcion.Text = tela.Descripcion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al buscar la tela:\n\n"
                    + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // BOTÓN LIMPIAR
        // =====================================================

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            txtCodigoTela.Focus();
        }

        // =====================================================
        // LIMPIAR CAMPOS
        // =====================================================

        private void LimpiarCampos()
        {
            txtCodigoTela.Clear();
            txtTipoTela.Clear();
            txtColor.Clear();
            txtPrecioMetro.Clear();
            txtStockMetros.Clear();
            txtEstado.Clear();
            txtDescripcion.Clear();
        }
    }
}