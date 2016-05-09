namespace CodigoBarras
{
    partial class frmCodigoBarras
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
            this.rdtPdf = new System.Windows.Forms.RadioButton();
            this.rdtDoc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerarCodigoBarras = new System.Windows.Forms.Button();
            this.ofdImportarTxt = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdtPdf
            // 
            this.rdtPdf.AutoSize = true;
            this.rdtPdf.Location = new System.Drawing.Point(18, 25);
            this.rdtPdf.Name = "rdtPdf";
            this.rdtPdf.Size = new System.Drawing.Size(66, 24);
            this.rdtPdf.TabIndex = 0;
            this.rdtPdf.TabStop = true;
            this.rdtPdf.Text = "PDF";
            this.rdtPdf.UseVisualStyleBackColor = true;
            // 
            // rdtDoc
            // 
            this.rdtDoc.AutoSize = true;
            this.rdtDoc.Location = new System.Drawing.Point(18, 73);
            this.rdtDoc.Name = "rdtDoc";
            this.rdtDoc.Size = new System.Drawing.Size(69, 24);
            this.rdtDoc.TabIndex = 1;
            this.rdtDoc.TabStop = true;
            this.rdtDoc.Text = "DOC";
            this.rdtDoc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdtDoc);
            this.groupBox1.Controls.Add(this.rdtPdf);
            this.groupBox1.Location = new System.Drawing.Point(495, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter para:";
            // 
            // btnGerarCodigoBarras
            // 
            this.btnGerarCodigoBarras.Location = new System.Drawing.Point(12, 152);
            this.btnGerarCodigoBarras.Name = "btnGerarCodigoBarras";
            this.btnGerarCodigoBarras.Size = new System.Drawing.Size(586, 59);
            this.btnGerarCodigoBarras.TabIndex = 3;
            this.btnGerarCodigoBarras.Text = "Gerar Código de Barras";
            this.btnGerarCodigoBarras.UseVisualStyleBackColor = true;
            this.btnGerarCodigoBarras.Click += new System.EventHandler(this.btnGerarCodigoBarras_Click);
            // 
            // ofdImportarTxt
            // 
            this.ofdImportarTxt.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Verificar selecionado (teste)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(652, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 7;
            // 
            // frmCodigoBarras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 250);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGerarCodigoBarras);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCodigoBarras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdtPdf;
        private System.Windows.Forms.RadioButton rdtDoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerarCodigoBarras;
        private System.Windows.Forms.OpenFileDialog ofdImportarTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

