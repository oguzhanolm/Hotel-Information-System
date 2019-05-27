namespace WindowsFormsApp1
{
    partial class Personel_Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel_Ekle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPersonel = new System.Windows.Forms.Button();
            this.perAddName = new System.Windows.Forms.TextBox();
            this.txPerAdres = new System.Windows.Forms.TextBox();
            this.btnAddPersonelCancel = new System.Windows.Forms.Button();
            this.txPerTel = new System.Windows.Forms.TextBox();
            this.txPerMail = new System.Windows.Forms.TextBox();
            this.txPerTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txPerPuan = new System.Windows.Forms.TextBox();
            this.txPerPozisyon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Adı-Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(64, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Departmanı:";
            // 
            // btnAddPersonel
            // 
            this.btnAddPersonel.Location = new System.Drawing.Point(228, 421);
            this.btnAddPersonel.Name = "btnAddPersonel";
            this.btnAddPersonel.Size = new System.Drawing.Size(113, 33);
            this.btnAddPersonel.TabIndex = 3;
            this.btnAddPersonel.Text = "Personeli ekle";
            this.btnAddPersonel.UseVisualStyleBackColor = true;
            this.btnAddPersonel.Click += new System.EventHandler(this.btnAddPersonel_Click);
            // 
            // perAddName
            // 
            this.perAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.perAddName.Location = new System.Drawing.Point(228, 43);
            this.perAddName.Name = "perAddName";
            this.perAddName.Size = new System.Drawing.Size(255, 29);
            this.perAddName.TabIndex = 4;
            // 
            // txPerAdres
            // 
            this.txPerAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txPerAdres.Location = new System.Drawing.Point(228, 88);
            this.txPerAdres.Name = "txPerAdres";
            this.txPerAdres.Size = new System.Drawing.Size(255, 29);
            this.txPerAdres.TabIndex = 5;
            // 
            // btnAddPersonelCancel
            // 
            this.btnAddPersonelCancel.Location = new System.Drawing.Point(370, 421);
            this.btnAddPersonelCancel.Name = "btnAddPersonelCancel";
            this.btnAddPersonelCancel.Size = new System.Drawing.Size(113, 33);
            this.btnAddPersonelCancel.TabIndex = 7;
            this.btnAddPersonelCancel.Text = "İptal";
            this.btnAddPersonelCancel.UseVisualStyleBackColor = true;
            this.btnAddPersonelCancel.Click += new System.EventHandler(this.btnAddPersonelCancel_Click);
            // 
            // txPerTel
            // 
            this.txPerTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txPerTel.Location = new System.Drawing.Point(228, 271);
            this.txPerTel.Name = "txPerTel";
            this.txPerTel.Size = new System.Drawing.Size(255, 29);
            this.txPerTel.TabIndex = 13;
            // 
            // txPerMail
            // 
            this.txPerMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txPerMail.Location = new System.Drawing.Point(228, 225);
            this.txPerMail.Name = "txPerMail";
            this.txPerMail.Size = new System.Drawing.Size(255, 29);
            this.txPerMail.TabIndex = 12;
            // 
            // txPerTC
            // 
            this.txPerTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txPerTC.Location = new System.Drawing.Point(228, 180);
            this.txPerTC.Name = "txPerTC";
            this.txPerTC.Size = new System.Drawing.Size(255, 29);
            this.txPerTC.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(51, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Personel Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(76, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Personel Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(57, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Personel TC No:";
            // 
            // txPerPuan
            // 
            this.txPerPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txPerPuan.Location = new System.Drawing.Point(228, 363);
            this.txPerPuan.Name = "txPerPuan";
            this.txPerPuan.Size = new System.Drawing.Size(255, 29);
            this.txPerPuan.TabIndex = 17;
            // 
            // txPerPozisyon
            // 
            this.txPerPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txPerPozisyon.Location = new System.Drawing.Point(228, 317);
            this.txPerPozisyon.Name = "txPerPozisyon";
            this.txPerPozisyon.Size = new System.Drawing.Size(255, 29);
            this.txPerPozisyon.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(65, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Personel Puanı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(36, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Personel Pozisyon:";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Items.AddRange(new object[] {
            "Temizlik",
            "Eğlence",
            "Hizmet"});
            this.cmbDepartman.Location = new System.Drawing.Point(228, 128);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(255, 32);
            this.cmbDepartman.TabIndex = 20;
            // 
            // Personel_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 487);
            this.ControlBox = false;
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.txPerPuan);
            this.Controls.Add(this.txPerPozisyon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txPerTel);
            this.Controls.Add(this.txPerMail);
            this.Controls.Add(this.txPerTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddPersonelCancel);
            this.Controls.Add(this.txPerAdres);
            this.Controls.Add(this.perAddName);
            this.Controls.Add(this.btnAddPersonel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Personel_Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPersonel;
        private System.Windows.Forms.TextBox perAddName;
        private System.Windows.Forms.TextBox txPerAdres;
        private System.Windows.Forms.Button btnAddPersonelCancel;
        private System.Windows.Forms.TextBox txPerTel;
        private System.Windows.Forms.TextBox txPerMail;
        private System.Windows.Forms.TextBox txPerTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txPerPuan;
        private System.Windows.Forms.TextBox txPerPozisyon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDepartman;
    }
}