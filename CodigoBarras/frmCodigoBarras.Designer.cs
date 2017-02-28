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
            this.btnGerarCodigoBarras = new System.Windows.Forms.Button();
            this.ofdImportarTxt = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerarCodigoBarras
            // 
            this.btnGerarCodigoBarras.Location = new System.Drawing.Point(12, 59);
            this.btnGerarCodigoBarras.Name = "btnGerarCodigoBarras";
            this.btnGerarCodigoBarras.Size = new System.Drawing.Size(254, 59);
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
            this.button1.Location = new System.Drawing.Point(115, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCodigoBarras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 178);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGerarCodigoBarras);
            this.Name = "frmCodigoBarras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarCodigoBarras;
        private System.Windows.Forms.OpenFileDialog ofdImportarTxt;
        private System.Windows.Forms.Button button1;
    }
}

