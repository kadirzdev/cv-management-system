namespace CVproject
{
    partial class AddCV

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCV));
            this.panel7 = new System.Windows.Forms.Panel();
            this.Pdftext = new System.Windows.Forms.TextBox();
            this.Lecorstd = new System.Windows.Forms.ComboBox();
            this.Uploadpdf = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Desktoppanel = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Bisque;
            this.panel7.Controls.Add(this.Pdftext);
            this.panel7.Controls.Add(this.Lecorstd);
            this.panel7.Controls.Add(this.Uploadpdf);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Location = new System.Drawing.Point(-7, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1060, 92);
            this.panel7.TabIndex = 38;
            // 
            // Pdftext
            // 
            this.Pdftext.Location = new System.Drawing.Point(374, 67);
            this.Pdftext.Name = "Pdftext";
            this.Pdftext.Size = new System.Drawing.Size(178, 22);
            this.Pdftext.TabIndex = 21;
            this.Pdftext.TextChanged += new System.EventHandler(this.Pdftext_TextChanged);
            // 
            // Lecorstd
            // 
            this.Lecorstd.FormattingEnabled = true;
            this.Lecorstd.Location = new System.Drawing.Point(374, 38);
            this.Lecorstd.Name = "Lecorstd";
            this.Lecorstd.Size = new System.Drawing.Size(178, 24);
            this.Lecorstd.TabIndex = 20;
            this.Lecorstd.SelectedIndexChanged += new System.EventHandler(this.Lecorstd_SelectedIndexChanged);
            // 
            // Uploadpdf
            // 
            this.Uploadpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uploadpdf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Uploadpdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Uploadpdf.Location = new System.Drawing.Point(203, 38);
            this.Uploadpdf.Name = "Uploadpdf";
            this.Uploadpdf.Size = new System.Drawing.Size(159, 51);
            this.Uploadpdf.TabIndex = 19;
            this.Uploadpdf.Text = "     Upload CV";
            this.Uploadpdf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Uploadpdf.UseVisualStyleBackColor = true;
            this.Uploadpdf.Click += new System.EventHandler(this.Uploadpdf_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(44, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(126, 45);
            this.label23.TabIndex = 18;
            this.label23.Text = "AddCV";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(591, -47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.axAcroPDF1);
            this.panel1.Location = new System.Drawing.Point(24, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 610);
            this.panel1.TabIndex = 39;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(494, 610);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // Desktoppanel
            // 
            this.Desktoppanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Desktoppanel.Location = new System.Drawing.Point(534, 100);
            this.Desktoppanel.Name = "Desktoppanel";
            this.Desktoppanel.Size = new System.Drawing.Size(504, 590);
            this.Desktoppanel.TabIndex = 40;
            // 
            // AddCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 718);
            this.Controls.Add(this.Desktoppanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCV";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox Lecorstd;
        private System.Windows.Forms.Button Uploadpdf;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.TextBox Pdftext;
        private System.Windows.Forms.Panel Desktoppanel;
    }
}