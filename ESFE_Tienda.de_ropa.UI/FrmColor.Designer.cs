namespace ESFE_Tienda.de_ropa.UI
{
    partial class FrmColor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();

            SuspendLayout();

            // =====================================================
            // FORMULARIO
            // =====================================================

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(850, 500);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "FrmColor";
            Text = "Gestión de Colores";

            // =====================================================
            // TITULO
            // =====================================================

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 45, 45);
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(87, 41);
            label1.TabIndex = 1;
            label1.Text = "Color";

            // =====================================================
            // BUSCAR COLOR
            // =====================================================

            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(70, 70, 70);
            label2.Location = new Point(35, 90);
            label2.Name = "label2";
            label2.Size = new Size(195, 19);
            label2.TabIndex = 3;
            label2.Text = "Buscar color por nombre o ID";

            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(250, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 25);
            textBox1.TabIndex = 2;

            button2.BackColor = Color.FromArgb(52, 152, 219);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(490, 84);
            button2.Name = "button2";
            button2.Size = new Size(120, 30);
            button2.TabIndex = 9;
            button2.Text = "Buscar color";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;

            // =====================================================
            // DATOS DEL COLOR
            // =====================================================

            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(70, 70, 70);
            label3.Location = new Point(35, 165);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "ID Color";

            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(125, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 25);
            textBox2.TabIndex = 7;

            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(70, 70, 70);
            label4.Location = new Point(35, 210);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Color";

            textBox3.Font = new Font("Segoe UI", 10F);
            textBox3.Location = new Point(125, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 25);
            textBox3.TabIndex = 8;

            // =====================================================
            // LIMPIAR
            // =====================================================

            button1.BackColor = Color.FromArgb(149, 165, 166);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(125, 250);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 0;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = false;

            // =====================================================
            // ELIMINAR COLOR
            // =====================================================

            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(70, 70, 70);
            label5.Location = new Point(410, 165);
            label5.Name = "label5";
            label5.Size = new Size(274, 19);
            label5.TabIndex = 6;
            label5.Text = "Eliminar color por nombre o ID";

            textBox4.Font = new Font("Segoe UI", 10F);
            textBox4.Location = new Point(410, 200);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 25);
            textBox4.TabIndex = 11;

            button3.BackColor = Color.FromArgb(231, 76, 60);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(410, 245);
            button3.Name = "button3";
            button3.Size = new Size(130, 32);
            button3.TabIndex = 10;
            button3.Text = "Eliminar color";
            button3.UseVisualStyleBackColor = false;

            // =====================================================
            // CONTROLES
            // =====================================================

            Controls.Add(label1);

            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);

            Controls.Add(label3);
            Controls.Add(textBox2);

            Controls.Add(label4);
            Controls.Add(textBox3);

            Controls.Add(button1);

            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(button3);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
    }
}