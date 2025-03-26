namespace To_Do_List.Formlar
{
    partial class GirisFormu
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
            this.btn_girisYap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ll_hesapOlustur = new System.Windows.Forms.LinkLabel();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_girisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_girisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_girisYap.Location = new System.Drawing.Point(271, 116);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(213, 38);
            this.btn_girisYap.TabIndex = 2;
            this.btn_girisYap.Text = "GİRİŞ YAP";
            this.btn_girisYap.UseVisualStyleBackColor = false;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bir hesabın yok mu?";
            // 
            // ll_hesapOlustur
            // 
            this.ll_hesapOlustur.AutoSize = true;
            this.ll_hesapOlustur.Location = new System.Drawing.Point(267, 176);
            this.ll_hesapOlustur.Name = "ll_hesapOlustur";
            this.ll_hesapOlustur.Size = new System.Drawing.Size(106, 19);
            this.ll_hesapOlustur.TabIndex = 3;
            this.ll_hesapOlustur.TabStop = true;
            this.ll_hesapOlustur.Text = "Hesap Oluştur";
            this.ll_hesapOlustur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_hesapOlustur_LinkClicked);
            // 
            // tb_sifre
            // 
            this.tb_sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tb_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_sifre.Location = new System.Drawing.Point(271, 83);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(213, 27);
            this.tb_sifre.TabIndex = 1;
            this.tb_sifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "ŞİFRE :";
            // 
            // tb_mail
            // 
            this.tb_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tb_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_mail.Location = new System.Drawing.Point(271, 50);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(213, 27);
            this.tb_mail.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "MAIL ADRESİ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "TO-DO LIST GIRIS EKRANI";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GirisFormu
            // 
            this.AcceptButton = this.btn_girisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(657, 206);
            this.Controls.Add(this.btn_girisYap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ll_hesapOlustur);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ YAP";
            this.Load += new System.EventHandler(this.GirisFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_girisYap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel ll_hesapOlustur;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}