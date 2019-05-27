namespace WindowsFormsApp1
{
    partial class Otel_Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Otel_Ekle));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOtelAddName = new System.Windows.Forms.TextBox();
            this.cmbboxAddAdres = new System.Windows.Forms.ComboBox();
            this.btnAddOtel = new System.Windows.Forms.Button();
            this.btnAddOtelCancel = new System.Windows.Forms.Button();
            this.txtHotelPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHotelMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOdaTipi = new System.Windows.Forms.ComboBox();
            this.cmbYıldız = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(47, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Otel İsmi:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Otel Mevki:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(47, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Otel Yıldızı:";
            // 
            // txtOtelAddName
            // 
            this.txtOtelAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOtelAddName.Location = new System.Drawing.Point(164, 26);
            this.txtOtelAddName.Name = "txtOtelAddName";
            this.txtOtelAddName.Size = new System.Drawing.Size(255, 29);
            this.txtOtelAddName.TabIndex = 5;
            // 
            // cmbboxAddAdres
            // 
            this.cmbboxAddAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmbboxAddAdres.FormattingEnabled = true;
            this.cmbboxAddAdres.Items.AddRange(new object[] {
            "Özdere",
            "Sığacık",
            "Şakran",
            "Dikili",
            "Ürkmez",
            "Urla",
            "Foça",
            "Alaçatı",
            "Eski Foça",
            "Gümüldür",
            "Mordoğan",
            "Karaburun",
            "Çandarlı"});
            this.cmbboxAddAdres.Location = new System.Drawing.Point(164, 64);
            this.cmbboxAddAdres.Name = "cmbboxAddAdres";
            this.cmbboxAddAdres.Size = new System.Drawing.Size(255, 32);
            this.cmbboxAddAdres.TabIndex = 7;
            // 
            // btnAddOtel
            // 
            this.btnAddOtel.Location = new System.Drawing.Point(164, 327);
            this.btnAddOtel.Name = "btnAddOtel";
            this.btnAddOtel.Size = new System.Drawing.Size(113, 33);
            this.btnAddOtel.TabIndex = 9;
            this.btnAddOtel.Text = "Oteli ekle";
            this.btnAddOtel.UseVisualStyleBackColor = true;
            this.btnAddOtel.Click += new System.EventHandler(this.btnAddOtel_Click);
            // 
            // btnAddOtelCancel
            // 
            this.btnAddOtelCancel.Location = new System.Drawing.Point(306, 327);
            this.btnAddOtelCancel.Name = "btnAddOtelCancel";
            this.btnAddOtelCancel.Size = new System.Drawing.Size(113, 33);
            this.btnAddOtelCancel.TabIndex = 10;
            this.btnAddOtelCancel.Text = "İptal";
            this.btnAddOtelCancel.UseVisualStyleBackColor = true;
            this.btnAddOtelCancel.Click += new System.EventHandler(this.btnAddOtelCancel_Click);
            // 
            // txtHotelPhone
            // 
            this.txtHotelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHotelPhone.Location = new System.Drawing.Point(164, 146);
            this.txtHotelPhone.Name = "txtHotelPhone";
            this.txtHotelPhone.Size = new System.Drawing.Size(255, 29);
            this.txtHotelPhone.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(47, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Otel Telefon:";
            // 
            // txtHotelMail
            // 
            this.txtHotelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHotelMail.Location = new System.Drawing.Point(164, 188);
            this.txtHotelMail.Name = "txtHotelMail";
            this.txtHotelMail.Size = new System.Drawing.Size(255, 29);
            this.txtHotelMail.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(47, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Otel Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(47, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Oda Tipi:";
            // 
            // txtRooms
            // 
            this.txtRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRooms.Location = new System.Drawing.Point(164, 230);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.Size = new System.Drawing.Size(255, 29);
            this.txtRooms.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(47, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Oda Sayısı:";
            // 
            // cmbOdaTipi
            // 
            this.cmbOdaTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmbOdaTipi.FormattingEnabled = true;
            this.cmbOdaTipi.Items.AddRange(new object[] {
            "Manzaralı",
            "Manzarasız"});
            this.cmbOdaTipi.Location = new System.Drawing.Point(164, 272);
            this.cmbOdaTipi.Name = "cmbOdaTipi";
            this.cmbOdaTipi.Size = new System.Drawing.Size(255, 32);
            this.cmbOdaTipi.TabIndex = 18;
            // 
            // cmbYıldız
            // 
            this.cmbYıldız.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmbYıldız.FormattingEnabled = true;
            this.cmbYıldız.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.cmbYıldız.Location = new System.Drawing.Point(164, 103);
            this.cmbYıldız.Name = "cmbYıldız";
            this.cmbYıldız.Size = new System.Drawing.Size(255, 32);
            this.cmbYıldız.TabIndex = 19;
            // 
            // Otel_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(438, 392);
            this.Controls.Add(this.cmbYıldız);
            this.Controls.Add(this.cmbOdaTipi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRooms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHotelMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHotelPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddOtelCancel);
            this.Controls.Add(this.btnAddOtel);
            this.Controls.Add(this.cmbboxAddAdres);
            this.Controls.Add(this.txtOtelAddName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Otel_Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel";
            this.Load += new System.EventHandler(this.Otel_Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOtelAddName;
        private System.Windows.Forms.ComboBox cmbboxAddAdres;
        private System.Windows.Forms.Button btnAddOtel;
        private System.Windows.Forms.Button btnAddOtelCancel;
        private System.Windows.Forms.TextBox txtHotelPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHotelMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbOdaTipi;
        private System.Windows.Forms.ComboBox cmbYıldız;
    }
}