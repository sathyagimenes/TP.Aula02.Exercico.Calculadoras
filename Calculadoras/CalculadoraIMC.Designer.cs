namespace Calculadoras
{
    partial class CalculadoraIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraIMC));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblSistemaCalculo = new System.Windows.Forms.Label();
            this.pctCalculadora = new System.Windows.Forms.PictureBox();
            this.mtbAltura = new System.Windows.Forms.MaskedTextBox();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.mtbPeso = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctCalculadora)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.IndianRed;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpar.Location = new System.Drawing.Point(319, 326);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 32);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar\r\n";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalcular.Location = new System.Drawing.Point(162, 326);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 32);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPeso.Location = new System.Drawing.Point(187, 234);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(80, 18);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso (kg):";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAltura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAltura.Location = new System.Drawing.Point(187, 270);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(87, 18);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "Altura (cm):";
            // 
            // lblSistemaCalculo
            // 
            this.lblSistemaCalculo.AutoSize = true;
            this.lblSistemaCalculo.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSistemaCalculo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSistemaCalculo.Location = new System.Drawing.Point(122, 171);
            this.lblSistemaCalculo.Name = "lblSistemaCalculo";
            this.lblSistemaCalculo.Size = new System.Drawing.Size(385, 34);
            this.lblSistemaCalculo.TabIndex = 6;
            this.lblSistemaCalculo.Text = "Sistema de Cálculo de IMC";
            // 
            // pctCalculadora
            // 
            this.pctCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("pctCalculadora.Image")));
            this.pctCalculadora.Location = new System.Drawing.Point(177, 39);
            this.pctCalculadora.Name = "pctCalculadora";
            this.pctCalculadora.Size = new System.Drawing.Size(259, 112);
            this.pctCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCalculadora.TabIndex = 8;
            this.pctCalculadora.TabStop = false;
            this.pctCalculadora.Tag = "";
            // 
            // mtbAltura
            // 
            this.mtbAltura.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.mtbAltura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbAltura.Location = new System.Drawing.Point(282, 267);
            this.mtbAltura.Mask = "000";
            this.mtbAltura.Name = "mtbAltura";
            this.mtbAltura.Size = new System.Drawing.Size(100, 25);
            this.mtbAltura.TabIndex = 2;
            this.mtbAltura.ValidatingType = typeof(int);
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblResultado1.Location = new System.Drawing.Point(139, 383);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(0, 22);
            this.lblResultado1.TabIndex = 11;
            // 
            // mtbPeso
            // 
            this.mtbPeso.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.mtbPeso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbPeso.Location = new System.Drawing.Point(282, 227);
            this.mtbPeso.Mask = "000";
            this.mtbPeso.Name = "mtbPeso";
            this.mtbPeso.Size = new System.Drawing.Size(100, 25);
            this.mtbPeso.TabIndex = 1;
            this.mtbPeso.ValidatingType = typeof(int);
            // 
            // CalculadoraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(628, 461);
            this.Controls.Add(this.mtbPeso);
            this.Controls.Add(this.lblResultado1);
            this.Controls.Add(this.mtbAltura);
            this.Controls.Add(this.pctCalculadora);
            this.Controls.Add(this.lblSistemaCalculo);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Name = "CalculadoraIMC";
            this.Text = "CalculadoraIMC";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pctCalculadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLimpar;
        private Button btnCalcular;
        private Label lblPeso;
        private Label lblAltura;
        private Label lblSistemaCalculo;
        private PictureBox pctCalculadora;
        private MaskedTextBox mtbAltura;
        private Label lblResultado1;
        private MaskedTextBox mtbPeso;
    }
}