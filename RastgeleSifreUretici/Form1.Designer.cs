namespace RastgeleSifreUretici
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKucukHarf = new System.Windows.Forms.TextBox();
            this.txtBuyukHarf = new System.Windows.Forms.TextBox();
            this.txtSayilar = new System.Windows.Forms.TextBox();
            this.numericKucuk = new System.Windows.Forms.NumericUpDown();
            this.numericBuyuk = new System.Windows.Forms.NumericUpDown();
            this.numericSayi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericKucuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBuyuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSayi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Şifre Üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(102, 229);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(171, 20);
            this.txtSifre.TabIndex = 1;
            // 
            // txtKucukHarf
            // 
            this.txtKucukHarf.Location = new System.Drawing.Point(102, 56);
            this.txtKucukHarf.Name = "txtKucukHarf";
            this.txtKucukHarf.Size = new System.Drawing.Size(171, 20);
            this.txtKucukHarf.TabIndex = 1;
            this.txtKucukHarf.Text = "eyupcanbalaban";
            // 
            // txtBuyukHarf
            // 
            this.txtBuyukHarf.Location = new System.Drawing.Point(102, 96);
            this.txtBuyukHarf.Name = "txtBuyukHarf";
            this.txtBuyukHarf.Size = new System.Drawing.Size(171, 20);
            this.txtBuyukHarf.TabIndex = 1;
            this.txtBuyukHarf.Text = "EYUPCANBALABAN";
            // 
            // txtSayilar
            // 
            this.txtSayilar.Location = new System.Drawing.Point(102, 146);
            this.txtSayilar.Name = "txtSayilar";
            this.txtSayilar.Size = new System.Drawing.Size(171, 20);
            this.txtSayilar.TabIndex = 1;
            this.txtSayilar.Text = "121001";
            // 
            // numericKucuk
            // 
            this.numericKucuk.Location = new System.Drawing.Point(15, 57);
            this.numericKucuk.Name = "numericKucuk";
            this.numericKucuk.Size = new System.Drawing.Size(64, 20);
            this.numericKucuk.TabIndex = 2;
            // 
            // numericBuyuk
            // 
            this.numericBuyuk.Location = new System.Drawing.Point(15, 97);
            this.numericBuyuk.Name = "numericBuyuk";
            this.numericBuyuk.Size = new System.Drawing.Size(64, 20);
            this.numericBuyuk.TabIndex = 2;
            // 
            // numericSayi
            // 
            this.numericSayi.Location = new System.Drawing.Point(15, 146);
            this.numericSayi.Name = "numericSayi";
            this.numericSayi.Size = new System.Drawing.Size(64, 20);
            this.numericSayi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Üretilmiş Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Karakter Aralığı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKucukHarf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBuyukHarf);
            this.groupBox1.Controls.Add(this.numericSayi);
            this.groupBox1.Controls.Add(this.txtSayilar);
            this.groupBox1.Controls.Add(this.numericBuyuk);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.numericKucuk);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 273);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 298);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Rastgele Şifre Üretici";
            ((System.ComponentModel.ISupportInitialize)(this.numericKucuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBuyuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSayi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKucukHarf;
        private System.Windows.Forms.TextBox txtBuyukHarf;
        private System.Windows.Forms.TextBox txtSayilar;
        private System.Windows.Forms.NumericUpDown numericKucuk;
        private System.Windows.Forms.NumericUpDown numericBuyuk;
        private System.Windows.Forms.NumericUpDown numericSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

