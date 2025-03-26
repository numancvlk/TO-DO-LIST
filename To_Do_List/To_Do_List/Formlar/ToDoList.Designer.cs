namespace To_Do_List.Formlar
{
    partial class ToDoList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_gorevDuzenle = new System.Windows.Forms.Button();
            this.btn_gorevBitmedi = new System.Windows.Forms.Button();
            this.btn_görevTamam = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_priorty = new System.Windows.Forms.ComboBox();
            this.btn_gorevSil = new System.Windows.Forms.Button();
            this.btn_gorevEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tb_acıklama = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_gorevAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_cıkısYap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(15, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 523);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(811, 497);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(553, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "TO-DO LİST ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_gorevDuzenle);
            this.groupBox2.Controls.Add(this.btn_gorevBitmedi);
            this.groupBox2.Controls.Add(this.btn_görevTamam);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cb_priorty);
            this.groupBox2.Controls.Add(this.btn_gorevSil);
            this.groupBox2.Controls.Add(this.btn_gorevEkle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.tb_acıklama);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_gorevAd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(838, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 523);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_gorevDuzenle
            // 
            this.btn_gorevDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_gorevDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gorevDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gorevDuzenle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gorevDuzenle.ForeColor = System.Drawing.Color.White;
            this.btn_gorevDuzenle.Location = new System.Drawing.Point(161, 369);
            this.btn_gorevDuzenle.Name = "btn_gorevDuzenle";
            this.btn_gorevDuzenle.Size = new System.Drawing.Size(252, 38);
            this.btn_gorevDuzenle.TabIndex = 24;
            this.btn_gorevDuzenle.Text = "GÖREV DÜZENLE";
            this.btn_gorevDuzenle.UseVisualStyleBackColor = false;
            this.btn_gorevDuzenle.Click += new System.EventHandler(this.btn_gorevDuzenle_Click);
            // 
            // btn_gorevBitmedi
            // 
            this.btn_gorevBitmedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_gorevBitmedi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gorevBitmedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gorevBitmedi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gorevBitmedi.ForeColor = System.Drawing.Color.White;
            this.btn_gorevBitmedi.Location = new System.Drawing.Point(161, 457);
            this.btn_gorevBitmedi.Name = "btn_gorevBitmedi";
            this.btn_gorevBitmedi.Size = new System.Drawing.Size(252, 38);
            this.btn_gorevBitmedi.TabIndex = 23;
            this.btn_gorevBitmedi.Text = "GÖREV TAMAMLANMADI";
            this.btn_gorevBitmedi.UseVisualStyleBackColor = false;
            this.btn_gorevBitmedi.Click += new System.EventHandler(this.btn_gorevBitmedi_Click);
            // 
            // btn_görevTamam
            // 
            this.btn_görevTamam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_görevTamam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_görevTamam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_görevTamam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_görevTamam.ForeColor = System.Drawing.Color.White;
            this.btn_görevTamam.Location = new System.Drawing.Point(161, 413);
            this.btn_görevTamam.Name = "btn_görevTamam";
            this.btn_görevTamam.Size = new System.Drawing.Size(252, 38);
            this.btn_görevTamam.TabIndex = 22;
            this.btn_görevTamam.Text = "GÖREV TAMAMLANDI";
            this.btn_görevTamam.UseVisualStyleBackColor = false;
            this.btn_görevTamam.Click += new System.EventHandler(this.btn_görevTamam_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "ÖNCELİK :";
            // 
            // cb_priorty
            // 
            this.cb_priorty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cb_priorty.FormattingEnabled = true;
            this.cb_priorty.Location = new System.Drawing.Point(161, 130);
            this.cb_priorty.Name = "cb_priorty";
            this.cb_priorty.Size = new System.Drawing.Size(252, 27);
            this.cb_priorty.TabIndex = 20;
            // 
            // btn_gorevSil
            // 
            this.btn_gorevSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_gorevSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gorevSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gorevSil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gorevSil.ForeColor = System.Drawing.Color.White;
            this.btn_gorevSil.Location = new System.Drawing.Point(161, 325);
            this.btn_gorevSil.Name = "btn_gorevSil";
            this.btn_gorevSil.Size = new System.Drawing.Size(252, 38);
            this.btn_gorevSil.TabIndex = 19;
            this.btn_gorevSil.Text = "GÖREV SİL";
            this.btn_gorevSil.UseVisualStyleBackColor = false;
            this.btn_gorevSil.Click += new System.EventHandler(this.btn_gorevSil_Click);
            // 
            // btn_gorevEkle
            // 
            this.btn_gorevEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_gorevEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gorevEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gorevEkle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gorevEkle.ForeColor = System.Drawing.Color.White;
            this.btn_gorevEkle.Location = new System.Drawing.Point(161, 281);
            this.btn_gorevEkle.Name = "btn_gorevEkle";
            this.btn_gorevEkle.Size = new System.Drawing.Size(252, 38);
            this.btn_gorevEkle.TabIndex = 18;
            this.btn_gorevEkle.Text = "GÖREV EKLE";
            this.btn_gorevEkle.UseVisualStyleBackColor = false;
            this.btn_gorevEkle.Click += new System.EventHandler(this.btn_gorevEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "GÖREV TARİHİ :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dateTimePicker2.Location = new System.Drawing.Point(161, 92);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(252, 27);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // tb_acıklama
            // 
            this.tb_acıklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tb_acıklama.Location = new System.Drawing.Point(161, 168);
            this.tb_acıklama.Name = "tb_acıklama";
            this.tb_acıklama.Size = new System.Drawing.Size(252, 96);
            this.tb_acıklama.TabIndex = 15;
            this.tb_acıklama.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "AÇIKLAMA :";
            // 
            // tb_gorevAd
            // 
            this.tb_gorevAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tb_gorevAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_gorevAd.Location = new System.Drawing.Point(161, 50);
            this.tb_gorevAd.Name = "tb_gorevAd";
            this.tb_gorevAd.Size = new System.Drawing.Size(252, 27);
            this.tb_gorevAd.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "GÖREV ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(144, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "GÖREV AYARLARI";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 27);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1151, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "0";
            this.label7.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_cıkısYap
            // 
            this.btn_cıkısYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_cıkısYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cıkısYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cıkısYap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cıkısYap.ForeColor = System.Drawing.Color.White;
            this.btn_cıkısYap.Location = new System.Drawing.Point(1203, 2);
            this.btn_cıkısYap.Name = "btn_cıkısYap";
            this.btn_cıkısYap.Size = new System.Drawing.Size(100, 38);
            this.btn_cıkısYap.TabIndex = 25;
            this.btn_cıkısYap.Text = "ÇIKIŞ YAP";
            this.btn_cıkısYap.UseVisualStyleBackColor = false;
            this.btn_cıkısYap.Click += new System.EventHandler(this.btn_cıkısYap_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1305, 582);
            this.Controls.Add(this.btn_cıkısYap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TO DO LİST";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RichTextBox tb_acıklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_gorevAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_gorevEkle;
        private System.Windows.Forms.Button btn_gorevSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_priorty;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_gorevBitmedi;
        private System.Windows.Forms.Button btn_görevTamam;
        private System.Windows.Forms.Button btn_gorevDuzenle;
        private System.Windows.Forms.Button btn_cıkısYap;
    }
}