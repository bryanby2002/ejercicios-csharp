namespace Encriptacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtPalabra = new TextBox();
            txtEncriptar = new Button();
            button1 = new Button();
            txtResultado = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PT Sans", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(166, 39);
            label1.Name = "label1";
            label1.Size = new Size(109, 24);
            label1.TabIndex = 0;
            label1.Text = "Encriptacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 109);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Palabra";
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(57, 127);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(146, 23);
            txtPalabra.TabIndex = 2;
            // 
            // txtEncriptar
            // 
            txtEncriptar.Location = new Point(221, 127);
            txtEncriptar.Name = "txtEncriptar";
            txtEncriptar.Size = new Size(89, 23);
            txtEncriptar.TabIndex = 3;
            txtEncriptar.Text = "Encriptar";
            txtEncriptar.UseVisualStyleBackColor = true;
            txtEncriptar.Click += txtEncriptar_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(316, 127);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 4;
            button1.Text = "Desencriptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(57, 192);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(190, 23);
            txtResultado.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 174);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Resultado";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 308);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(button1);
            Controls.Add(txtEncriptar);
            Controls.Add(txtPalabra);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Encriptacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPalabra;
        private Button txtEncriptar;
        private Button button1;
        private TextBox txtResultado;
        private Label label3;
    }
}