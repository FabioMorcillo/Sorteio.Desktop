namespace Sorteio.Desktop
{
    partial class FrmSorteio
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
            this.panelNome1 = new System.Windows.Forms.Panel();
            this.pictureBoxNome1 = new System.Windows.Forms.PictureBox();
            this.labelNome1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxNomes = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panelNome2 = new System.Windows.Forms.Panel();
            this.pictureBoxNome2 = new System.Windows.Forms.PictureBox();
            this.labelNome2 = new System.Windows.Forms.Label();
            this.panelNome3 = new System.Windows.Forms.Panel();
            this.pictureBoxNome3 = new System.Windows.Forms.PictureBox();
            this.labelNome3 = new System.Windows.Forms.Label();
            this.btnSortear = new System.Windows.Forms.Button();
            this.pictureBoxNumber3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxNumber2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxNumber1 = new System.Windows.Forms.PictureBox();
            this.panelNome1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNome1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelNome2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNome2)).BeginInit();
            this.panelNome3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNome3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNumber3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNumber1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNome1
            // 
            this.panelNome1.Controls.Add(this.pictureBoxNome1);
            this.panelNome1.Controls.Add(this.labelNome1);
            this.panelNome1.Location = new System.Drawing.Point(449, 70);
            this.panelNome1.Name = "panelNome1";
            this.panelNome1.Size = new System.Drawing.Size(342, 121);
            this.panelNome1.TabIndex = 2;
            this.panelNome1.Tag = "1";
            // 
            // pictureBoxNome1
            // 
            this.pictureBoxNome1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxNome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxNome1.Enabled = false;
            this.pictureBoxNome1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNome1.Name = "pictureBoxNome1";
            this.pictureBoxNome1.Size = new System.Drawing.Size(342, 121);
            this.pictureBoxNome1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNome1.TabIndex = 1;
            this.pictureBoxNome1.TabStop = false;
            this.pictureBoxNome1.Tag = "1";
            this.pictureBoxNome1.Click += new System.EventHandler(this.Candidato_Click);
            // 
            // labelNome1
            // 
            this.labelNome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNome1.Location = new System.Drawing.Point(0, 0);
            this.labelNome1.Name = "labelNome1";
            this.labelNome1.Size = new System.Drawing.Size(342, 121);
            this.labelNome1.TabIndex = 2;
            this.labelNome1.Tag = "1";
            this.labelNome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNome1.Click += new System.EventHandler(this.Candidato_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxNomes);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 450);
            this.panel1.TabIndex = 3;
            // 
            // listBoxNomes
            // 
            this.listBoxNomes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNomes.FormattingEnabled = true;
            this.listBoxNomes.Location = new System.Drawing.Point(0, 53);
            this.listBoxNomes.Name = "listBoxNomes";
            this.listBoxNomes.Size = new System.Drawing.Size(368, 397);
            this.listBoxNomes.TabIndex = 1;
            this.listBoxNomes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoxNomes_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 53);
            this.panel2.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(339, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            // 
            // panelNome2
            // 
            this.panelNome2.Controls.Add(this.pictureBoxNome2);
            this.panelNome2.Controls.Add(this.labelNome2);
            this.panelNome2.Location = new System.Drawing.Point(449, 197);
            this.panelNome2.Name = "panelNome2";
            this.panelNome2.Size = new System.Drawing.Size(342, 121);
            this.panelNome2.TabIndex = 4;
            this.panelNome2.Tag = "2";
            // 
            // pictureBoxNome2
            // 
            this.pictureBoxNome2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxNome2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxNome2.Enabled = false;
            this.pictureBoxNome2.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNome2.Name = "pictureBoxNome2";
            this.pictureBoxNome2.Size = new System.Drawing.Size(342, 121);
            this.pictureBoxNome2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNome2.TabIndex = 1;
            this.pictureBoxNome2.TabStop = false;
            this.pictureBoxNome2.Tag = "2";
            this.pictureBoxNome2.Click += new System.EventHandler(this.Candidato_Click);
            // 
            // labelNome2
            // 
            this.labelNome2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNome2.Location = new System.Drawing.Point(0, 0);
            this.labelNome2.Name = "labelNome2";
            this.labelNome2.Size = new System.Drawing.Size(342, 121);
            this.labelNome2.TabIndex = 2;
            this.labelNome2.Tag = "2";
            this.labelNome2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNome2.Click += new System.EventHandler(this.Candidato_Click);
            // 
            // panelNome3
            // 
            this.panelNome3.Controls.Add(this.pictureBoxNome3);
            this.panelNome3.Controls.Add(this.labelNome3);
            this.panelNome3.Location = new System.Drawing.Point(449, 324);
            this.panelNome3.Name = "panelNome3";
            this.panelNome3.Size = new System.Drawing.Size(342, 121);
            this.panelNome3.TabIndex = 3;
            this.panelNome3.Tag = "3";
            // 
            // pictureBoxNome3
            // 
            this.pictureBoxNome3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxNome3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxNome3.Enabled = false;
            this.pictureBoxNome3.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNome3.Name = "pictureBoxNome3";
            this.pictureBoxNome3.Size = new System.Drawing.Size(342, 121);
            this.pictureBoxNome3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNome3.TabIndex = 1;
            this.pictureBoxNome3.TabStop = false;
            this.pictureBoxNome3.Tag = "3";
            this.pictureBoxNome3.Click += new System.EventHandler(this.Candidato_Click);
            // 
            // labelNome3
            // 
            this.labelNome3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNome3.Location = new System.Drawing.Point(0, 0);
            this.labelNome3.Name = "labelNome3";
            this.labelNome3.Size = new System.Drawing.Size(342, 121);
            this.labelNome3.TabIndex = 2;
            this.labelNome3.Tag = "3";
            this.labelNome3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNome3.Click += new System.EventHandler(this.Candidato_Click);
            // 
            // btnSortear
            // 
            this.btnSortear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSortear.Enabled = false;
            this.btnSortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortear.ForeColor = System.Drawing.Color.Black;
            this.btnSortear.Location = new System.Drawing.Point(375, 9);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(417, 52);
            this.btnSortear.TabIndex = 5;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.BtnSortear_Click);
            // 
            // pictureBoxNumber3
            // 
            this.pictureBoxNumber3.Location = new System.Drawing.Point(375, 357);
            this.pictureBoxNumber3.Name = "pictureBoxNumber3";
            this.pictureBoxNumber3.Size = new System.Drawing.Size(68, 62);
            this.pictureBoxNumber3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNumber3.TabIndex = 8;
            this.pictureBoxNumber3.TabStop = false;
            // 
            // pictureBoxNumber2
            // 
            this.pictureBoxNumber2.Location = new System.Drawing.Point(375, 226);
            this.pictureBoxNumber2.Name = "pictureBoxNumber2";
            this.pictureBoxNumber2.Size = new System.Drawing.Size(68, 62);
            this.pictureBoxNumber2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNumber2.TabIndex = 7;
            this.pictureBoxNumber2.TabStop = false;
            // 
            // pictureBoxNumber1
            // 
            this.pictureBoxNumber1.Location = new System.Drawing.Point(375, 98);
            this.pictureBoxNumber1.Name = "pictureBoxNumber1";
            this.pictureBoxNumber1.Size = new System.Drawing.Size(68, 62);
            this.pictureBoxNumber1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNumber1.TabIndex = 6;
            this.pictureBoxNumber1.TabStop = false;
            // 
            // FrmSorteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxNumber3);
            this.Controls.Add(this.pictureBoxNumber2);
            this.Controls.Add(this.pictureBoxNumber1);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.panelNome3);
            this.Controls.Add(this.panelNome2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelNome1);
            this.Name = "FrmSorteio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteio do livro Domain Driven Design";
            this.Shown += new System.EventHandler(this.FrmSorteio_Shown);
            this.panelNome1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNome1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelNome2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNome2)).EndInit();
            this.panelNome3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNome3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNumber3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNumber1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNome1;
        private System.Windows.Forms.Label labelNome1;
        private System.Windows.Forms.PictureBox pictureBoxNome1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxNomes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panelNome2;
        private System.Windows.Forms.PictureBox pictureBoxNome2;
        private System.Windows.Forms.Label labelNome2;
        private System.Windows.Forms.Panel panelNome3;
        private System.Windows.Forms.PictureBox pictureBoxNome3;
        private System.Windows.Forms.Label labelNome3;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.PictureBox pictureBoxNumber1;
        private System.Windows.Forms.PictureBox pictureBoxNumber2;
        private System.Windows.Forms.PictureBox pictureBoxNumber3;
    }
}

