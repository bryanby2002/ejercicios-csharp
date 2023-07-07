namespace Compresion
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
            txtOrigen = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            txtNombre = new TextBox();
            button3 = new Button();
            openFileDialog1 = new OpenFileDialog();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PT Sans", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(137, 30);
            label1.Name = "label1";
            label1.Size = new Size(246, 24);
            label1.TabIndex = 0;
            label1.Text = "Compresion y descompresion";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PT Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 117);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 1;
            label2.Text = "Archivo o Carpeta:";
            label2.Click += label2_Click;
            // 
            // txtOrigen
            // 
            txtOrigen.Enabled = false;
            txtOrigen.Location = new Point(161, 113);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(321, 23);
            txtOrigen.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("PT Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(86, 215);
            button1.Name = "button1";
            button1.Size = new Size(124, 35);
            button1.TabIndex = 3;
            button1.Text = "Comprimir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Font = new Font("PT Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(220, 215);
            button2.Name = "button2";
            button2.Size = new Size(119, 35);
            button2.TabIndex = 4;
            button2.Text = "Descomprimir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("PT Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 151);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 5;
            label3.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(161, 151);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(118, 23);
            txtNombre.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.Font = new Font("PT Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(366, 215);
            button3.Name = "button3";
            button3.Size = new Size(91, 35);
            button3.TabIndex = 7;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            button4.Location = new Point(161, 84);
            button4.Name = "button4";
            button4.Size = new Size(64, 23);
            button4.TabIndex = 8;
            button4.Text = "Caperta";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(231, 84);
            button5.Name = "button5";
            button5.Size = new Size(57, 23);
            button5.TabIndex = 9;
            button5.Text = "Zip";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(531, 344);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtOrigen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtOrigen;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox txtNombre;
        private Button button3;
        private OpenFileDialog openFileDialog1;
        private Button button4;
        private Button button5;
    }
}