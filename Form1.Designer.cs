namespace Calculadora
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
            cmbOperaciones = new ComboBox();
            label1 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cmbOperaciones
            // 
            cmbOperaciones.FormattingEnabled = true;
            cmbOperaciones.Location = new Point(33, 64);
            cmbOperaciones.Name = "cmbOperaciones";
            cmbOperaciones.Size = new Size(182, 33);
            cmbOperaciones.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 24);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 1;
            label1.Text = "Operaciones";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(33, 140);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(150, 31);
            txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(243, 140);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(150, 31);
            txtNum2.TabIndex = 2;
            txtNum2.TextChanged += textBox2_TextChanged;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(51, 238);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(150, 31);
            txtResultado.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(260, 201);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 100);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Numero1";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 100);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Numero2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 210);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 4;
            label4.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 355);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultado);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            Controls.Add(cmbOperaciones);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOperaciones;
        private Label label1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResultado;
        private Button btnCalcular;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
