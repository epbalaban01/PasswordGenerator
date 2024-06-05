namespace PasswordGenerator
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
            this.components = new System.ComponentModel.Container();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.chkRequireOther = new System.Windows.Forms.CheckBox();
            this.chkAllowOther = new System.Windows.Forms.CheckBox();
            this.chkRequireSpace = new System.Windows.Forms.CheckBox();
            this.chkRequireUnderscore = new System.Windows.Forms.CheckBox();
            this.chkRequireSpecial = new System.Windows.Forms.CheckBox();
            this.chkRequireNumber = new System.Windows.Forms.CheckBox();
            this.chkRequireUppercase = new System.Windows.Forms.CheckBox();
            this.chkRequireLowercase = new System.Windows.Forms.CheckBox();
            this.chkAllowSpace = new System.Windows.Forms.CheckBox();
            this.chkAllowUnderscore = new System.Windows.Forms.CheckBox();
            this.chkAllowSpecial = new System.Windows.Forms.CheckBox();
            this.chkAllowNumber = new System.Windows.Forms.CheckBox();
            this.chkAllowUppercase = new System.Windows.Forms.CheckBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.chkAllowLowercase = new System.Windows.Forms.CheckBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtMaxLength = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtMinLength = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCopied = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tmrClearCopied = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtOther);
            this.GroupBox1.Controls.Add(this.chkRequireOther);
            this.GroupBox1.Controls.Add(this.chkAllowOther);
            this.GroupBox1.Controls.Add(this.chkRequireSpace);
            this.GroupBox1.Controls.Add(this.chkRequireUnderscore);
            this.GroupBox1.Controls.Add(this.chkRequireSpecial);
            this.GroupBox1.Controls.Add(this.chkRequireNumber);
            this.GroupBox1.Controls.Add(this.chkRequireUppercase);
            this.GroupBox1.Controls.Add(this.chkRequireLowercase);
            this.GroupBox1.Controls.Add(this.chkAllowSpace);
            this.GroupBox1.Controls.Add(this.chkAllowUnderscore);
            this.GroupBox1.Controls.Add(this.chkAllowSpecial);
            this.GroupBox1.Controls.Add(this.chkAllowNumber);
            this.GroupBox1.Controls.Add(this.chkAllowUppercase);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.chkAllowLowercase);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GroupBox1.Location = new System.Drawing.Point(21, 74);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(255, 216);
            this.GroupBox1.TabIndex = 23;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Karakterler";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(16, 184);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(88, 20);
            this.txtOther.TabIndex = 12;
            // 
            // chkRequireOther
            // 
            this.chkRequireOther.AutoSize = true;
            this.chkRequireOther.Location = new System.Drawing.Point(199, 187);
            this.chkRequireOther.Name = "chkRequireOther";
            this.chkRequireOther.Size = new System.Drawing.Size(15, 14);
            this.chkRequireOther.TabIndex = 14;
            this.chkRequireOther.UseVisualStyleBackColor = true;
            this.chkRequireOther.CheckedChanged += new System.EventHandler(this.chkRequireOther_CheckedChanged);
            // 
            // chkAllowOther
            // 
            this.chkAllowOther.AutoSize = true;
            this.chkAllowOther.Location = new System.Drawing.Point(143, 187);
            this.chkAllowOther.Name = "chkAllowOther";
            this.chkAllowOther.Size = new System.Drawing.Size(15, 14);
            this.chkAllowOther.TabIndex = 13;
            this.chkAllowOther.UseVisualStyleBackColor = true;
            this.chkAllowOther.CheckedChanged += new System.EventHandler(this.chkAllowOther_CheckedChanged);
            // 
            // chkRequireSpace
            // 
            this.chkRequireSpace.AutoSize = true;
            this.chkRequireSpace.Location = new System.Drawing.Point(199, 161);
            this.chkRequireSpace.Name = "chkRequireSpace";
            this.chkRequireSpace.Size = new System.Drawing.Size(15, 14);
            this.chkRequireSpace.TabIndex = 11;
            this.chkRequireSpace.UseVisualStyleBackColor = true;
            this.chkRequireSpace.CheckedChanged += new System.EventHandler(this.chkRequireSpace_CheckedChanged);
            // 
            // chkRequireUnderscore
            // 
            this.chkRequireUnderscore.AutoSize = true;
            this.chkRequireUnderscore.Location = new System.Drawing.Point(199, 137);
            this.chkRequireUnderscore.Name = "chkRequireUnderscore";
            this.chkRequireUnderscore.Size = new System.Drawing.Size(15, 14);
            this.chkRequireUnderscore.TabIndex = 9;
            this.chkRequireUnderscore.UseVisualStyleBackColor = true;
            this.chkRequireUnderscore.CheckedChanged += new System.EventHandler(this.chkRequireUnderscore_CheckedChanged);
            // 
            // chkRequireSpecial
            // 
            this.chkRequireSpecial.AutoSize = true;
            this.chkRequireSpecial.Location = new System.Drawing.Point(199, 113);
            this.chkRequireSpecial.Name = "chkRequireSpecial";
            this.chkRequireSpecial.Size = new System.Drawing.Size(15, 14);
            this.chkRequireSpecial.TabIndex = 7;
            this.chkRequireSpecial.UseVisualStyleBackColor = true;
            this.chkRequireSpecial.CheckedChanged += new System.EventHandler(this.chkRequireSpecial_CheckedChanged);
            // 
            // chkRequireNumber
            // 
            this.chkRequireNumber.AutoSize = true;
            this.chkRequireNumber.Checked = true;
            this.chkRequireNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRequireNumber.Location = new System.Drawing.Point(199, 89);
            this.chkRequireNumber.Name = "chkRequireNumber";
            this.chkRequireNumber.Size = new System.Drawing.Size(15, 14);
            this.chkRequireNumber.TabIndex = 5;
            this.chkRequireNumber.UseVisualStyleBackColor = true;
            this.chkRequireNumber.CheckedChanged += new System.EventHandler(this.chkRequireNumber_CheckedChanged);
            // 
            // chkRequireUppercase
            // 
            this.chkRequireUppercase.AutoSize = true;
            this.chkRequireUppercase.Checked = true;
            this.chkRequireUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRequireUppercase.Location = new System.Drawing.Point(199, 65);
            this.chkRequireUppercase.Name = "chkRequireUppercase";
            this.chkRequireUppercase.Size = new System.Drawing.Size(15, 14);
            this.chkRequireUppercase.TabIndex = 3;
            this.chkRequireUppercase.UseVisualStyleBackColor = true;
            this.chkRequireUppercase.CheckedChanged += new System.EventHandler(this.chkRequireUppercase_CheckedChanged);
            // 
            // chkRequireLowercase
            // 
            this.chkRequireLowercase.AutoSize = true;
            this.chkRequireLowercase.Checked = true;
            this.chkRequireLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRequireLowercase.Location = new System.Drawing.Point(199, 41);
            this.chkRequireLowercase.Name = "chkRequireLowercase";
            this.chkRequireLowercase.Size = new System.Drawing.Size(15, 14);
            this.chkRequireLowercase.TabIndex = 1;
            this.chkRequireLowercase.UseVisualStyleBackColor = true;
            this.chkRequireLowercase.CheckedChanged += new System.EventHandler(this.chkRequireLowercase_CheckedChanged);
            // 
            // chkAllowSpace
            // 
            this.chkAllowSpace.AutoSize = true;
            this.chkAllowSpace.Location = new System.Drawing.Point(143, 161);
            this.chkAllowSpace.Name = "chkAllowSpace";
            this.chkAllowSpace.Size = new System.Drawing.Size(15, 14);
            this.chkAllowSpace.TabIndex = 10;
            this.chkAllowSpace.UseVisualStyleBackColor = true;
            this.chkAllowSpace.CheckedChanged += new System.EventHandler(this.chkAllowSpace_CheckedChanged);
            // 
            // chkAllowUnderscore
            // 
            this.chkAllowUnderscore.AutoSize = true;
            this.chkAllowUnderscore.Location = new System.Drawing.Point(143, 137);
            this.chkAllowUnderscore.Name = "chkAllowUnderscore";
            this.chkAllowUnderscore.Size = new System.Drawing.Size(15, 14);
            this.chkAllowUnderscore.TabIndex = 8;
            this.chkAllowUnderscore.UseVisualStyleBackColor = true;
            this.chkAllowUnderscore.CheckedChanged += new System.EventHandler(this.chkAllowUnderscore_CheckedChanged);
            // 
            // chkAllowSpecial
            // 
            this.chkAllowSpecial.AutoSize = true;
            this.chkAllowSpecial.Location = new System.Drawing.Point(143, 113);
            this.chkAllowSpecial.Name = "chkAllowSpecial";
            this.chkAllowSpecial.Size = new System.Drawing.Size(15, 14);
            this.chkAllowSpecial.TabIndex = 6;
            this.chkAllowSpecial.UseVisualStyleBackColor = true;
            this.chkAllowSpecial.CheckedChanged += new System.EventHandler(this.chkAllowSpecial_CheckedChanged);
            // 
            // chkAllowNumber
            // 
            this.chkAllowNumber.AutoSize = true;
            this.chkAllowNumber.Checked = true;
            this.chkAllowNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowNumber.Location = new System.Drawing.Point(143, 89);
            this.chkAllowNumber.Name = "chkAllowNumber";
            this.chkAllowNumber.Size = new System.Drawing.Size(15, 14);
            this.chkAllowNumber.TabIndex = 4;
            this.chkAllowNumber.UseVisualStyleBackColor = true;
            this.chkAllowNumber.CheckedChanged += new System.EventHandler(this.chkAllowNumber_CheckedChanged);
            // 
            // chkAllowUppercase
            // 
            this.chkAllowUppercase.AutoSize = true;
            this.chkAllowUppercase.Checked = true;
            this.chkAllowUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowUppercase.Location = new System.Drawing.Point(143, 65);
            this.chkAllowUppercase.Name = "chkAllowUppercase";
            this.chkAllowUppercase.Size = new System.Drawing.Size(15, 14);
            this.chkAllowUppercase.TabIndex = 2;
            this.chkAllowUppercase.UseVisualStyleBackColor = true;
            this.chkAllowUppercase.CheckedChanged += new System.EventHandler(this.chkAllowUppercase_CheckedChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(183, 17);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(44, 14);
            this.Label10.TabIndex = 8;
            this.Label10.Text = "Require";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(135, 17);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(35, 14);
            this.Label9.TabIndex = 7;
            this.Label9.Text = "Allow";
            // 
            // chkAllowLowercase
            // 
            this.chkAllowLowercase.AutoSize = true;
            this.chkAllowLowercase.Checked = true;
            this.chkAllowLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowLowercase.Location = new System.Drawing.Point(143, 41);
            this.chkAllowLowercase.Name = "chkAllowLowercase";
            this.chkAllowLowercase.Size = new System.Drawing.Size(15, 14);
            this.chkAllowLowercase.TabIndex = 0;
            this.chkAllowLowercase.UseVisualStyleBackColor = true;
            this.chkAllowLowercase.CheckedChanged += new System.EventHandler(this.chkAllowLowercase_CheckedChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(16, 161);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(53, 14);
            this.Label8.TabIndex = 5;
            this.Label8.Text = "Boşluk ( )";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(16, 137);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(54, 14);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Vurgu (_)";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(16, 113);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(106, 14);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Özel Karakter ($%#)";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(16, 89);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(69, 14);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "Sayılar (123)";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(16, 65);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(93, 14);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Büyük harf (ABC)";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(16, 41);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 14);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Küçük harf (abc)";
            // 
            // txtMaxLength
            // 
            this.txtMaxLength.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaxLength.Location = new System.Drawing.Point(388, 121);
            this.txtMaxLength.Name = "txtMaxLength";
            this.txtMaxLength.Size = new System.Drawing.Size(32, 20);
            this.txtMaxLength.TabIndex = 32;
            this.txtMaxLength.Text = "12";
            this.txtMaxLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label2.Location = new System.Drawing.Point(283, 124);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(99, 14);
            this.Label2.TabIndex = 34;
            this.Label2.Text = "Maksimum uzunluk:";
            // 
            // txtMinLength
            // 
            this.txtMinLength.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMinLength.Location = new System.Drawing.Point(388, 97);
            this.txtMinLength.Name = "txtMinLength";
            this.txtMinLength.Size = new System.Drawing.Size(32, 20);
            this.txtMinLength.TabIndex = 31;
            this.txtMinLength.Text = "10";
            this.txtMinLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label1.Location = new System.Drawing.Point(291, 100);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(91, 14);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "Minimum Uzunluk:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PasswordGenerator.Properties.Resources.settings_24px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(360, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCopied
            // 
            this.lblCopied.AutoSize = true;
            this.lblCopied.Location = new System.Drawing.Point(32, 54);
            this.lblCopied.Name = "lblCopied";
            this.lblCopied.Size = new System.Drawing.Size(0, 13);
            this.lblCopied.TabIndex = 39;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(21, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(384, 26);
            this.txtPassword.TabIndex = 37;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label11
            // 
            this.Label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label11.Location = new System.Drawing.Point(33, 9);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(384, 41);
            this.Label11.TabIndex = 38;
            this.Label11.Text = "Password Generate";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.lblCopied);
            this.groupBox2.Controls.Add(this.GroupBox1);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.txtMinLength);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Controls.Add(this.txtMaxLength);
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 306);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(300, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 37);
            this.button2.TabIndex = 40;
            this.button2.Text = "Oluştur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tmrClearCopied
            // 
            this.tmrClearCopied.Interval = 1000;
            this.tmrClearCopied.Tick += new System.EventHandler(this.tmrClearCopied_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 5);
            this.panel1.TabIndex = 41;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::PasswordGenerator.Properties.Resources.txt_48px;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(314, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 35);
            this.btnSave.TabIndex = 36;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Label11);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtOther;
        internal System.Windows.Forms.CheckBox chkRequireOther;
        internal System.Windows.Forms.CheckBox chkAllowOther;
        internal System.Windows.Forms.CheckBox chkRequireSpace;
        internal System.Windows.Forms.CheckBox chkRequireUnderscore;
        internal System.Windows.Forms.CheckBox chkRequireSpecial;
        internal System.Windows.Forms.CheckBox chkRequireNumber;
        internal System.Windows.Forms.CheckBox chkRequireUppercase;
        internal System.Windows.Forms.CheckBox chkRequireLowercase;
        internal System.Windows.Forms.CheckBox chkAllowSpace;
        internal System.Windows.Forms.CheckBox chkAllowUnderscore;
        internal System.Windows.Forms.CheckBox chkAllowSpecial;
        internal System.Windows.Forms.CheckBox chkAllowNumber;
        internal System.Windows.Forms.CheckBox chkAllowUppercase;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.CheckBox chkAllowLowercase;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtMaxLength;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtMinLength;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label lblCopied;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label Label11;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer tmrClearCopied;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
    }
}

