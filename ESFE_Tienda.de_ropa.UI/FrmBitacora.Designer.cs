namespace ESFE_Tienda.de_ropa.UI
{
    partial class FrmBitacora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelTitulo = new Panel();
            panelDatos = new Panel();
            panelBotones = new Panel();
            panelTitulo.SuspendLayout();
            panelDatos.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(179, 45);
            label1.TabIndex = 0;
            label1.Text = "BITÁCORA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 0, 55);
            label2.Location = new Point(25, 25);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 1;
            label2.Text = "Buscar ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(110, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 25);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 193, 7);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(355, 19);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 3;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 0, 55);
            label3.Location = new Point(25, 75);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 4;
            label3.Text = "ID Actividad";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(130, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(325, 25);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 0, 55);
            label4.Location = new Point(25, 120);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 6;
            label4.Text = "Acción";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10F);
            textBox3.Location = new Point(130, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(325, 25);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 0, 55);
            label5.Location = new Point(25, 165);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 8;
            label5.Text = "ID Usuario";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10F);
            textBox4.Location = new Point(130, 162);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(325, 25);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(45, 0, 55);
            label6.Location = new Point(25, 210);
            label6.Name = "label6";
            label6.Size = new Size(97, 19);
            label6.TabIndex = 10;
            label6.Text = "Fecha y Hora";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10F);
            textBox5.Location = new Point(130, 207);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(325, 25);
            textBox5.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(40, 167, 69);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(25, 20);
            button2.Name = "button2";
            button2.Size = new Size(220, 50);
            button2.TabIndex = 12;
            button2.Text = "AGREGAR REGISTRO";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 123, 255);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(300, 20);
            button3.Name = "button3";
            button3.Size = new Size(220, 50);
            button3.TabIndex = 13;
            button3.Text = "VER LISTA (ADMIN)";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(220, 53, 69);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(575, 20);
            button4.Name = "button4";
            button4.Size = new Size(220, 50);
            button4.TabIndex = 14;
            button4.Text = "ELIMINAR REGISTRO";
            button4.UseVisualStyleBackColor = false;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(45, 0, 55);
            panelTitulo.Controls.Add(label1);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(900, 85);
            panelTitulo.TabIndex = 0;
            // 
            // panelDatos
            // 
            panelDatos.BackColor = Color.FromArgb(250, 250, 250);
            panelDatos.BorderStyle = BorderStyle.FixedSingle;
            panelDatos.Controls.Add(label2);
            panelDatos.Controls.Add(textBox1);
            panelDatos.Controls.Add(button1);
            panelDatos.Controls.Add(label3);
            panelDatos.Controls.Add(textBox2);
            panelDatos.Controls.Add(label4);
            panelDatos.Controls.Add(textBox3);
            panelDatos.Controls.Add(label5);
            panelDatos.Controls.Add(textBox4);
            panelDatos.Controls.Add(label6);
            panelDatos.Controls.Add(textBox5);
            panelDatos.Location = new Point(35, 110);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(830, 265);
            panelDatos.TabIndex = 1;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(45, 0, 55);
            panelBotones.Controls.Add(button2);
            panelBotones.Controls.Add(button3);
            panelBotones.Controls.Add(button4);
            panelBotones.Location = new Point(35, 395);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(830, 90);
            panelBotones.TabIndex = 2;
            // 
            // FrmBitacora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 240);
            ClientSize = new Size(900, 520);
            Controls.Add(panelBotones);
            Controls.Add(panelDatos);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmBitacora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bitácora";
            Load += FrmBitacora_Load;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;

        private Label label3;
        private TextBox textBox2;

        private Label label4;
        private TextBox textBox3;

        private Label label5;
        private TextBox textBox4;

        private Label label6;
        private TextBox textBox5;

        private Button button2;
        private Button button3;
        private Button button4;

        private Panel panelTitulo;
        private Panel panelDatos;
        private Panel panelBotones;
    }
}