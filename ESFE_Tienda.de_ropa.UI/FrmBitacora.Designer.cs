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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Bitacora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Buscar ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(270, 54);
            button1.Name = "button1";
            button1.Size = new Size(75, 42);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "ID Actividad";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 214);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Acciones";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(68, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(293, 23);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 266);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 8;
            label5.Text = "ID Usuario";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(73, 263);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(222, 23);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 316);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 10;
            label6.Text = "Fecha y Hora";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(88, 316);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(207, 23);
            textBox5.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Location = new Point(448, 330);
            button2.Name = "button2";
            button2.Size = new Size(124, 45);
            button2.TabIndex = 12;
            button2.Text = "Agregar Registro";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.ForeColor = Color.FromArgb(0, 0, 192);
            button3.Location = new Point(578, 327);
            button3.Name = "button3";
            button3.Size = new Size(178, 51);
            button3.TabIndex = 13;
            button3.Text = "Ver Lista ( Admin )";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Desktop;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(493, 384);
            button4.Name = "button4";
            button4.Size = new Size(160, 54);
            button4.TabIndex = 14;
            button4.Text = "Eliminar Registro";
            button4.UseVisualStyleBackColor = false;
            // 
            // FrmBitacora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmBitacora";
            Text = "Bitacora";
            Load += FrmBitacora_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}