namespace Calculadoras
{
    partial class Menu
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
            this.lblSelecione = new System.Windows.Forms.Label();
            this.btnSimples = new System.Windows.Forms.Button();
            this.btnIMC = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelecione.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSelecione.Location = new System.Drawing.Point(51, 55);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(449, 44);
            this.lblSelecione.TabIndex = 0;
            this.lblSelecione.Text = "Selecione a Calculadora";
            this.lblSelecione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSimples
            // 
            this.btnSimples.BackColor = System.Drawing.Color.DimGray;
            this.btnSimples.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimples.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSimples.Location = new System.Drawing.Point(104, 127);
            this.btnSimples.Name = "btnSimples";
            this.btnSimples.Size = new System.Drawing.Size(160, 140);
            this.btnSimples.TabIndex = 1;
            this.btnSimples.Text = "Calculadora\r\nSimples";
            this.btnSimples.UseVisualStyleBackColor = false;
            this.btnSimples.Click += new System.EventHandler(this.btnSimples_Click);
            // 
            // btnIMC
            // 
            this.btnIMC.BackColor = System.Drawing.Color.DimGray;
            this.btnIMC.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIMC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIMC.Location = new System.Drawing.Point(266, 127);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(160, 140);
            this.btnIMC.TabIndex = 2;
            this.btnIMC.Text = "Calculadora\r\nIMC";
            this.btnIMC.UseVisualStyleBackColor = false;
            this.btnIMC.Click += new System.EventHandler(this.btnIMC_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(550, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(550, 326);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnIMC);
            this.Controls.Add(this.btnSimples);
            this.Controls.Add(this.lblSelecione);
            this.Name = "Menu";
            this.Text = "Menu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSelecione;
        private Button btnSimples;
        private Button btnIMC;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox toolStripComboBox1;
    }
}