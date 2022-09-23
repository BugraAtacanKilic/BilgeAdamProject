
namespace notdefteri
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
            this.listBoxNotlar = new System.Windows.Forms.ListBox();
            this.buttonNotuSil = new System.Windows.Forms.Button();
            this.buttonYeniNot = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.textBoxBaslik = new System.Windows.Forms.TextBox();
            this.textBoxMetin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxNotlar
            // 
            this.listBoxNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxNotlar.FormattingEnabled = true;
            this.listBoxNotlar.ItemHeight = 20;
            this.listBoxNotlar.Location = new System.Drawing.Point(12, 41);
            this.listBoxNotlar.Name = "listBoxNotlar";
            this.listBoxNotlar.Size = new System.Drawing.Size(201, 364);
            this.listBoxNotlar.TabIndex = 0;
           
            // 
            // buttonNotuSil
            // 
            this.buttonNotuSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNotuSil.Location = new System.Drawing.Point(252, 41);
            this.buttonNotuSil.Name = "buttonNotuSil";
            this.buttonNotuSil.Size = new System.Drawing.Size(136, 37);
            this.buttonNotuSil.TabIndex = 1;
            this.buttonNotuSil.Text = "NOTU SİL";
            this.buttonNotuSil.UseVisualStyleBackColor = true;
            this.buttonNotuSil.Click += new System.EventHandler(this.buttonNotuSil_Click);
            // 
            // buttonYeniNot
            // 
            this.buttonYeniNot.Location = new System.Drawing.Point(410, 42);
            this.buttonYeniNot.Name = "buttonYeniNot";
            this.buttonYeniNot.Size = new System.Drawing.Size(136, 37);
            this.buttonYeniNot.TabIndex = 2;
            this.buttonYeniNot.Text = "YENİ NOT";
            this.buttonYeniNot.UseVisualStyleBackColor = true;
            this.buttonYeniNot.Click += new System.EventHandler(this.buttonYeniNot_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(419, 376);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(127, 37);
            this.buttonKaydet.TabIndex = 3;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // textBoxBaslik
            // 
            this.textBoxBaslik.Location = new System.Drawing.Point(252, 104);
            this.textBoxBaslik.Name = "textBoxBaslik";
            this.textBoxBaslik.Size = new System.Drawing.Size(294, 22);
            this.textBoxBaslik.TabIndex = 4;
            this.textBoxBaslik.Visible = false;
            // 
            // textBoxMetin
            // 
            this.textBoxMetin.Location = new System.Drawing.Point(252, 146);
            this.textBoxMetin.Multiline = true;
            this.textBoxMetin.Name = "textBoxMetin";
            this.textBoxMetin.Size = new System.Drawing.Size(294, 213);
            this.textBoxMetin.TabIndex = 5;
            this.textBoxMetin.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 441);
            this.Controls.Add(this.textBoxMetin);
            this.Controls.Add(this.textBoxBaslik);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.buttonYeniNot);
            this.Controls.Add(this.buttonNotuSil);
            this.Controls.Add(this.listBoxNotlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNotlar;
        private System.Windows.Forms.Button buttonNotuSil;
        private System.Windows.Forms.Button buttonYeniNot;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.TextBox textBoxBaslik;
        private System.Windows.Forms.TextBox textBoxMetin;
    }
}

