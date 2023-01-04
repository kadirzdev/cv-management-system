namespace CVproject
{
    partial class Viewcv
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewcv));
            this.panel7 = new System.Windows.Forms.Panel();
            this.cvcombo = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.link = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Bisque;
            this.panel7.Controls.Add(this.link);
            this.panel7.Controls.Add(this.cvcombo);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Controls.Add(this.Searchbutton);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.IDtext);
            this.panel7.Controls.Add(this.Search);
            this.panel7.Location = new System.Drawing.Point(-7, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1060, 171);
            this.panel7.TabIndex = 38;
            // 
            // cvcombo
            // 
            this.cvcombo.FormattingEnabled = true;
            this.cvcombo.Location = new System.Drawing.Point(104, 119);
            this.cvcombo.Name = "cvcombo";
            this.cvcombo.Size = new System.Drawing.Size(281, 24);
            this.cvcombo.TabIndex = 19;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(44, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(147, 45);
            this.label23.TabIndex = 18;
            this.label23.Text = "View CV";
            // 
            // Searchbutton
            // 
            this.Searchbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Searchbutton.Image = ((System.Drawing.Image)(resources.GetObject("Searchbutton.Image")));
            this.Searchbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Searchbutton.Location = new System.Drawing.Point(496, 121);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Searchbutton.Size = new System.Drawing.Size(212, 47);
            this.Searchbutton.TabIndex = 15;
            this.Searchbutton.Text = "         Search";
            this.Searchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
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
            // IDtext
            // 
            this.IDtext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDtext.Location = new System.Drawing.Point(104, 146);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(281, 22);
            this.IDtext.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(47, 139);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(45, 28);
            this.Search.TabIndex = 1;
            this.Search.Text = "ID : ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.axAcroPDF1);
            this.panel1.Location = new System.Drawing.Point(30, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 530);
            this.panel1.TabIndex = 39;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(988, 530);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(337, 51);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(44, 16);
            this.link.TabIndex = 20;
            this.link.Text = "label1";
            this.link.Visible = false;
            // 
            // ViewCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 718);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCV";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.ComboBox cvcombo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label link;
    }
}