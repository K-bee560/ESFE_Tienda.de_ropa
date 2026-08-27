namespace ESFE_Tienda.de_ropa.UI
{
    partial class FrmTela
    {
        /// <summary>
        /// Variable del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberar recursos.
        /// </summary>
        /// <param name="disposing">true si se deben liberar los recursos administrados.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblCodigoTela = new Label();
            txtCodigoTela = new TextBox();
            btnBuscar = new Button();
            lblTipoTela = new Label();
            txtTipoTela = new TextBox();
            lblColor = new Label();
            txtColor = new TextBox();
            lblPrecioMetro = new Label();
            txtPrecioMetro = new TextBox();
            lblStockMetros = new Label();
            txtStockMetros = new TextBox();
            lblEstado = new Label();
            txtEstado = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(250, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CONSULTA DE TELAS";
            // 
            // lblCodigoTela
            // 
            lblCodigoTela.AutoSize = true;
            lblCodigoTela.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodigoTela.ForeColor = Color.White;
            lblCodigoTela.Location = new Point(70, 95);
            lblCodigoTela.Name = "lblCodigoTela";
            lblCodigoTela.Size = new Size(112, 19);
            lblCodigoTela.TabIndex = 1;
            lblCodigoTela.Text = "Código de tela:";
            // 
            // txtCodigoTela
            // 
            txtCodigoTela.Font = new Font("Segoe UI", 10F);
            txtCodigoTela.Location = new Point(190, 92);
            txtCodigoTela.Name = "txtCodigoTela";
            txtCodigoTela.Size = new Size(180, 25);
            txtCodigoTela.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Yellow;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.Location = new Point(390, 88);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 34);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblTipoTela
            // 
            lblTipoTela.AutoSize = true;
            lblTipoTela.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTipoTela.ForeColor = Color.White;
            lblTipoTela.Location = new Point(70, 155);
            lblTipoTela.Name = "lblTipoTela";
            lblTipoTela.Size = new Size(93, 19);
            lblTipoTela.TabIndex = 4;
            lblTipoTela.Text = "Tipo de tela:";
            // 
            // txtTipoTela
            // 
            txtTipoTela.Font = new Font("Segoe UI", 10F);
            txtTipoTela.Location = new Point(190, 152);
            txtTipoTela.Name = "txtTipoTela";
            txtTipoTela.ReadOnly = true;
            txtTipoTela.Size = new Size(320, 25);
            txtTipoTela.TabIndex = 5;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblColor.ForeColor = Color.White;
            lblColor.Location = new Point(70, 205);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(51, 19);
            lblColor.TabIndex = 6;
            lblColor.Text = "Color:";
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Segoe UI", 10F);
            txtColor.Location = new Point(190, 202);
            txtColor.Name = "txtColor";
            txtColor.ReadOnly = true;
            txtColor.Size = new Size(320, 25);
            txtColor.TabIndex = 7;
            // 
            // lblPrecioMetro
            // 
            lblPrecioMetro.AutoSize = true;
            lblPrecioMetro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrecioMetro.ForeColor = Color.White;
            lblPrecioMetro.Location = new Point(70, 255);
            lblPrecioMetro.Name = "lblPrecioMetro";
            lblPrecioMetro.Size = new Size(129, 19);
            lblPrecioMetro.TabIndex = 8;
            lblPrecioMetro.Text = "Precio por metro:";
            // 
            // txtPrecioMetro
            // 
            txtPrecioMetro.Font = new Font("Segoe UI", 10F);
            txtPrecioMetro.Location = new Point(190, 252);
            txtPrecioMetro.Name = "txtPrecioMetro";
            txtPrecioMetro.ReadOnly = true;
            txtPrecioMetro.Size = new Size(150, 25);
            txtPrecioMetro.TabIndex = 9;
            // 
            // lblStockMetros
            // 
            lblStockMetros.AutoSize = true;
            lblStockMetros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStockMetros.ForeColor = Color.White;
            lblStockMetros.Location = new Point(390, 255);
            lblStockMetros.Name = "lblStockMetros";
            lblStockMetros.Size = new Size(111, 19);
            lblStockMetros.TabIndex = 10;
            lblStockMetros.Text = "Stock (metros):";
            // 
            // txtStockMetros
            // 
            txtStockMetros.Font = new Font("Segoe UI", 10F);
            txtStockMetros.Location = new Point(500, 252);
            txtStockMetros.Name = "txtStockMetros";
            txtStockMetros.ReadOnly = true;
            txtStockMetros.Size = new Size(120, 25);
            txtStockMetros.TabIndex = 11;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstado.ForeColor = Color.White;
            lblEstado.Location = new Point(70, 305);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 19);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Segoe UI", 10F);
            txtEstado.Location = new Point(190, 302);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(180, 25);
            txtEstado.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(70, 355);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(91, 19);
            lblDescripcion.TabIndex = 14;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.Location = new Point(190, 352);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(430, 60);
            txtDescripcion.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar.Location = new Point(280, 425);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 35);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // FrmTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(700, 500);
            Controls.Add(btnLimpiar);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtStockMetros);
            Controls.Add(lblStockMetros);
            Controls.Add(txtPrecioMetro);
            Controls.Add(lblPrecioMetro);
            Controls.Add(txtColor);
            Controls.Add(lblColor);
            Controls.Add(txtTipoTela);
            Controls.Add(lblTipoTela);
            Controls.Add(btnBuscar);
            Controls.Add(txtCodigoTela);
            Controls.Add(lblCodigoTela);
            Controls.Add(lblTitulo);
            Name = "FrmTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Telas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;

        private Label lblCodigoTela;
        private TextBox txtCodigoTela;
        private Button btnBuscar;

        private Label lblTipoTela;
        private TextBox txtTipoTela;

        private Label lblColor;
        private TextBox txtColor;

        private Label lblPrecioMetro;
        private TextBox txtPrecioMetro;

        private Label lblStockMetros;
        private TextBox txtStockMetros;

        private Label lblEstado;
        private TextBox txtEstado;

        private Label lblDescripcion;
        private TextBox txtDescripcion;

        private Button btnLimpiar;
    }
}