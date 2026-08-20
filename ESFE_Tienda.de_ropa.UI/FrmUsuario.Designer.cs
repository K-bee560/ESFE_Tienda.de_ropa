namespace ESFE_Tienda.de_ropa.UI
{
    partial class FrmUsuario
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Yellow;
            label2.Location = new Point(25, 86);
            label2.Name = "label2";
            label2.Size = new Size(247, 15);
            label2.TabIndex = 2;
            label2.Text = "Buscar por nombre de usuario o id de usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Yellow;
            label3.Location = new Point(25, 149);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "Limpiar";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Yellow;
            label4.Location = new Point(25, 213);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "ID usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Yellow;
            label5.Location = new Point(25, 272);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 5;
            label5.Text = "Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Yellow;
            label6.Location = new Point(25, 333);
            label6.Name = "label6";
            label6.Size = new Size(194, 15);
            label6.TabIndex = 6;
            label6.Text = "Eliminar por usuario o id de usuario";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(593, 78);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Buscar Usuario";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(304, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(253, 325);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 23);
            textBox2.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(584, 325);
            button2.Name = "button2";
            button2.Size = new Size(108, 23);
            button2.TabIndex = 10;
            button2.Text = "Eliminar Usuario";
            button2.UseVisualStyleBackColor = false;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
    }
}