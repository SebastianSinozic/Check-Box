namespace kostroEugenVjezba
{
    partial class Form1
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
            this.btnPosalji = new System.Windows.Forms.Button();
            this.txtPrikaz = new System.Windows.Forms.RichTextBox();
            this.chkDorucak = new System.Windows.Forms.CheckBox();
            this.chkRucak = new System.Windows.Forms.CheckBox();
            this.chkVecera = new System.Windows.Forms.CheckBox();
            this.ChkSakrij = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(80, 384);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(75, 23);
            this.btnPosalji.TabIndex = 0;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.BtnPosalji_Click);
            // 
            // txtPrikaz
            // 
            this.txtPrikaz.Location = new System.Drawing.Point(239, 41);
            this.txtPrikaz.Name = "txtPrikaz";
            this.txtPrikaz.Size = new System.Drawing.Size(549, 343);
            this.txtPrikaz.TabIndex = 1;
            this.txtPrikaz.Text = "";
            // 
            // chkDorucak
            // 
            this.chkDorucak.AutoSize = true;
            this.chkDorucak.Location = new System.Drawing.Point(80, 225);
            this.chkDorucak.Name = "chkDorucak";
            this.chkDorucak.Size = new System.Drawing.Size(67, 17);
            this.chkDorucak.TabIndex = 2;
            this.chkDorucak.Text = "Dorucak";
            this.chkDorucak.UseVisualStyleBackColor = true;
            // 
            // chkRucak
            // 
            this.chkRucak.AutoSize = true;
            this.chkRucak.Location = new System.Drawing.Point(80, 258);
            this.chkRucak.Name = "chkRucak";
            this.chkRucak.Size = new System.Drawing.Size(58, 17);
            this.chkRucak.TabIndex = 3;
            this.chkRucak.Text = "Rucak";
            this.chkRucak.UseVisualStyleBackColor = true;
            // 
            // chkVecera
            // 
            this.chkVecera.AutoSize = true;
            this.chkVecera.Location = new System.Drawing.Point(80, 290);
            this.chkVecera.Name = "chkVecera";
            this.chkVecera.Size = new System.Drawing.Size(60, 17);
            this.chkVecera.TabIndex = 4;
            this.chkVecera.Text = "Vecera";
            this.chkVecera.UseVisualStyleBackColor = true;
            // 
            // ChkSakrij
            // 
            this.ChkSakrij.AutoSize = true;
            this.ChkSakrij.Location = new System.Drawing.Point(239, 390);
            this.ChkSakrij.Name = "ChkSakrij";
            this.ChkSakrij.Size = new System.Drawing.Size(99, 17);
            this.ChkSakrij.TabIndex = 5;
            this.ChkSakrij.Text = "Sakrij narudzbu";
            this.ChkSakrij.UseVisualStyleBackColor = true;
            this.ChkSakrij.CheckedChanged += new System.EventHandler(this.ChkSakrij_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChkSakrij);
            this.Controls.Add(this.chkVecera);
            this.Controls.Add(this.chkRucak);
            this.Controls.Add(this.chkDorucak);
            this.Controls.Add(this.txtPrikaz);
            this.Controls.Add(this.btnPosalji);
            this.Name = "Form1";
            this.Text = "Rucak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.RichTextBox txtPrikaz;
        private System.Windows.Forms.CheckBox chkDorucak;
        private System.Windows.Forms.CheckBox chkRucak;
        private System.Windows.Forms.CheckBox chkVecera;
        private System.Windows.Forms.CheckBox ChkSakrij;
    }
}

