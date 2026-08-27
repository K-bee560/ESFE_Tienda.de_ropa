namespace ESFE_Tienda.de_ropa.UI
{
    partial class FrmCliente
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();

            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();

            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();

            button1 = new Button();
            label11 = new Label();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            button3 = new Button();

            label12 = new Label();
            textBox10 = new TextBox();
            button4 = new Button();

            label13 = new Label();
            label14 = new Label();

            SuspendLayout();

            // =========================
            // FORMULARIO
            // =========================

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(900, 600);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "FrmCliente";
            Text = "Gestión de Clientes";

            // =========================
            // TITULO
            // =========================

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(110, 37);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            label1.Click += label1_Click_1;

            // =========================
            // BUSCAR
            // =========================

            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(70, 70, 70);
            label2.Location = new Point(30, 75);
            label2.Name = "label2";
            label2.Size = new Size(181, 19);
            label2.TabIndex = 3;
            label2.Text = "Buscar por ID, DUI o Teléfono";

            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(225, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 25);
            textBox1.TabIndex = 2;

            button1.BackColor = Color.FromArgb(52, 152, 219);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(510, 70);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 20;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            button2.BackColor = Color.FromArgb(149, 165, 166);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(615, 70);
            button2.Name = "button2";
            button2.Size = new Size(90, 28);
            button2.TabIndex = 23;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;

            // =========================
            // INFORMACIÓN DEL CLIENTE
            // =========================

            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(70, 70, 70);
            label3.Location = new Point(30, 135);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "ID Cliente";

            textBox9.Font = new Font("Segoe UI", 10F);
            textBox9.Location = new Point(125, 130);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(230, 25);
            textBox9.TabIndex = 19;

            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(70, 70, 70);
            label4.Location = new Point(30, 175);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Nombre";

            textBox8.Font = new Font("Segoe UI", 10F);
            textBox8.Location = new Point(125, 170);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(230, 25);
            textBox8.TabIndex = 18;

            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(70, 70, 70);
            label5.Location = new Point(30, 215);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 6;
            label5.Text = "DUI";

            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(125, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 25);
            textBox2.TabIndex = 12;

            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(70, 70, 70);
            label6.Location = new Point(30, 255);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 7;
            label6.Text = "Teléfono";

            textBox3.Font = new Font("Segoe UI", 10F);
            textBox3.Location = new Point(125, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 25);
            textBox3.TabIndex = 13;

            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(70, 70, 70);
            label7.Location = new Point(30, 295);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 8;
            label7.Text = "Correo";

            textBox4.Font = new Font("Segoe UI", 10F);
            textBox4.Location = new Point(125, 290);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(230, 25);
            textBox4.TabIndex = 14;

            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(70, 70, 70);
            label8.Location = new Point(30, 335);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 9;
            label8.Text = "ID Rol";

            textBox5.Font = new Font("Segoe UI", 10F);
            textBox5.Location = new Point(125, 330);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(230, 25);
            textBox5.TabIndex = 15;

            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(70, 70, 70);
            label9.Location = new Point(30, 375);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 10;
            label9.Text = "ID Permiso";

            textBox6.Font = new Font("Segoe UI", 10F);
            textBox6.Location = new Point(125, 370);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(230, 25);
            textBox6.TabIndex = 16;

            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(70, 70, 70);
            label10.Location = new Point(30, 415);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 11;
            label10.Text = "ID Estado";

            textBox7.Font = new Font("Segoe UI", 10F);
            textBox7.Location = new Point(125, 410);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(230, 25);
            textBox7.TabIndex = 17;

            // =========================
            // BOTÓN AGREGAR
            // =========================

            button3.BackColor = Color.FromArgb(46, 204, 113);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(125, 460);
            button3.Name = "button3";
            button3.Size = new Size(230, 35);
            button3.TabIndex = 24;
            button3.Text = "Agregar nuevo cliente";
            button3.UseVisualStyleBackColor = false;

            // =========================
            // FILTRO POR ROL
            // =========================

            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(50, 50, 50);
            label11.Location = new Point(470, 135);
            label11.Name = "label11";
            label11.Size = new Size(107, 20);
            label11.TabIndex = 21;
            label11.Text = "Filtrar por rol";

            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.ForeColor = Color.FromArgb(70, 70, 70);
            label14.Location = new Point(490, 175);
            label14.Name = "label14";
            label14.Size = new Size(100, 19);
            label14.TabIndex = 29;
            label14.Text = "Administrador";

            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.ForeColor = Color.FromArgb(70, 70, 70);
            label13.Location = new Point(490, 205);
            label13.Name = "label13";
            label13.Size = new Size(73, 19);
            label13.TabIndex = 28;
            label13.Text = "Empleado";

            // =========================
            // ELIMINAR CLIENTE
            // =========================

            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(50, 50, 50);
            label12.Location = new Point(470, 270);
            label12.Name = "label12";
            label12.Size = new Size(207, 20);
            label12.TabIndex = 25;
            label12.Text = "Eliminar cliente";

            textBox10.Font = new Font("Segoe UI", 10F);
            textBox10.Location = new Point(470, 310);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(235, 25);
            textBox10.TabIndex = 26;

            button4.BackColor = Color.FromArgb(231, 76, 60);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(470, 355);
            button4.Name = "button4";
            button4.Size = new Size(120, 32);
            button4.TabIndex = 27;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = false;

            // =========================
            // MENSAJE
            // =========================

            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 8.5F);
            linkLabel1.LinkColor = Color.FromArgb(100, 100, 100);
            linkLabel1.Location = new Point(30, 535);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(620, 15);
            linkLabel1.TabIndex = 22;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Para agregar un nuevo cliente, presione Limpiar, llene los campos y luego presione Agregar nuevo cliente.";

            // =========================
            // CONTROLES
            // =========================

            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button2);

            Controls.Add(label3);
            Controls.Add(textBox9);

            Controls.Add(label4);
            Controls.Add(textBox8);

            Controls.Add(label5);
            Controls.Add(textBox2);

            Controls.Add(label6);
            Controls.Add(textBox3);

            Controls.Add(label7);
            Controls.Add(textBox4);

            Controls.Add(label8);
            Controls.Add(textBox5);

            Controls.Add(label9);
            Controls.Add(textBox6);

            Controls.Add(label10);
            Controls.Add(textBox7);

            Controls.Add(button3);

            Controls.Add(label11);
            Controls.Add(label14);
            Controls.Add(label13);

            Controls.Add(label12);
            Controls.Add(textBox10);
            Controls.Add(button4);

            Controls.Add(linkLabel1);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Button button1;
        private Label label11;
        private LinkLabel linkLabel1;
        private Button button2;
        private Button button3;
        private Label label12;
        private TextBox textBox10;
        private Button button4;
        private Label label13;
        private Label label14;
    }
}