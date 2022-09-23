
namespace _01_SinemaOtomasyonu
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlKoltuklar = new System.Windows.Forms.Panel();
            this.btnKadinErkekSayisi = new System.Windows.Forms.Button();
            this.btnIzleyiciSayisi = new System.Windows.Forms.Button();
            this.pbDolu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbBos = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDolu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(803, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinema Otomasyonu ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlKoltuklar);
            this.groupBox1.Location = new System.Drawing.Point(8, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 436);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Koltuklar";
            // 
            // pnlKoltuklar
            // 
            this.pnlKoltuklar.Location = new System.Drawing.Point(85, 45);
            this.pnlKoltuklar.Name = "pnlKoltuklar";
            this.pnlKoltuklar.Size = new System.Drawing.Size(613, 367);
            this.pnlKoltuklar.TabIndex = 0;
            // 
            // btnKadinErkekSayisi
            // 
            this.btnKadinErkekSayisi.Location = new System.Drawing.Point(12, 546);
            this.btnKadinErkekSayisi.Name = "btnKadinErkekSayisi";
            this.btnKadinErkekSayisi.Size = new System.Drawing.Size(198, 51);
            this.btnKadinErkekSayisi.TabIndex = 2;
            this.btnKadinErkekSayisi.Text = "Kadın - Erkek Sayısı";
            this.btnKadinErkekSayisi.UseVisualStyleBackColor = true;
            this.btnKadinErkekSayisi.Click += new System.EventHandler(this.btnKadinErkekSayisi_Click);
            // 
            // btnIzleyiciSayisi
            // 
            this.btnIzleyiciSayisi.Location = new System.Drawing.Point(216, 546);
            this.btnIzleyiciSayisi.Name = "btnIzleyiciSayisi";
            this.btnIzleyiciSayisi.Size = new System.Drawing.Size(198, 51);
            this.btnIzleyiciSayisi.TabIndex = 3;
            this.btnIzleyiciSayisi.Text = "İzleyici Sayısı";
            this.btnIzleyiciSayisi.UseVisualStyleBackColor = true;
            this.btnIzleyiciSayisi.Click += new System.EventHandler(this.btnIzleyiciSayisi_Click);
            // 
            // pbDolu
            // 
            this.pbDolu.Location = new System.Drawing.Point(477, 547);
            this.pbDolu.Name = "pbDolu";
            this.pbDolu.Size = new System.Drawing.Size(50, 50);
            this.pbDolu.TabIndex = 0;
            this.pbDolu.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = " : Dolu ";
            // 
            // pbBos
            // 
            this.pbBos.Location = new System.Drawing.Point(644, 547);
            this.pbBos.Name = "pbBos";
            this.pbBos.Size = new System.Drawing.Size(50, 50);
            this.pbBos.TabIndex = 4;
            this.pbBos.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = ": Boş";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 646);
            this.Controls.Add(this.pbBos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbDolu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIzleyiciSayisi);
            this.Controls.Add(this.btnKadinErkekSayisi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDolu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlKoltuklar;
        private System.Windows.Forms.Button btnKadinErkekSayisi;
        private System.Windows.Forms.Button btnIzleyiciSayisi;
        private System.Windows.Forms.PictureBox pbDolu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbBos;
        private System.Windows.Forms.Label label3;
    }
}

