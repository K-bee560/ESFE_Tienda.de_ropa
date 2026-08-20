namespace ESFE_Tienda.de_ropa.UI
{
    partial class FrmEstado
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(567, 73);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Buscar ";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Yellow;
            label2.Location = new Point(24, 81);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 3;
            label2.Text = "Buscar estado por nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Yellow;
            label3.Location = new Point(24, 136);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "ID estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Yellow;
            label4.Location = new Point(24, 194);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 5;
            label4.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Yellow;
            label5.Location = new Point(24, 261);
            label5.Name = "label5";
            label5.Size = new Size(232, 15);
            label5.TabIndex = 6;
            label5.Text = "Eliminar o Agregar estado por nombre o id";
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(219, 329);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(24, 329);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Location = new Point(701, 73);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "Limpiar";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(304, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(135, 191);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(304, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(323, 258);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(304, 23);
            textBox4.TabIndex = 12;
            // 
            // FrmEstado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "FrmEstado";
            Text = "FrmEstado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}