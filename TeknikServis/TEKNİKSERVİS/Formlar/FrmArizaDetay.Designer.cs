
namespace TEKNİKSERVİS.Formlar
{
    partial class FrmArizaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArizaDetay));
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.TxtTarih = new DevExpress.XtraEditors.TextEdit();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TxtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnVazgec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(10, 409);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(148, 34);
            this.BtnGuncelle.TabIndex = 5;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(242, 21);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "ARIZALI ÜRÜN KAYDI AÇIKLAMA";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(78, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 3);
            this.panel4.TabIndex = 80;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(10, 146);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(46, 40);
            this.pictureEdit4.TabIndex = 79;
            // 
            // TxtTarih
            // 
            this.TxtTarih.EditValue = "Tarih";
            this.TxtTarih.Location = new System.Drawing.Point(78, 158);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.TxtTarih.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarih.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtTarih.Properties.Appearance.Options.UseBackColor = true;
            this.TxtTarih.Properties.Appearance.Options.UseFont = true;
            this.TxtTarih.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTarih.Properties.BeepOnError = false;
            this.TxtTarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtTarih.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.TxtTarih.Properties.MaskSettings.Set("mask", "d");
            this.TxtTarih.Size = new System.Drawing.Size(99, 26);
            this.TxtTarih.TabIndex = 2;
            this.TxtTarih.Click += new System.EventHandler(this.TxtTarih_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Location = new System.Drawing.Point(78, 125);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(211, 3);
            this.panel7.TabIndex = 96;
            // 
            // TxtSeriNo
            // 
            this.TxtSeriNo.EditValue = "Seri No";
            this.TxtSeriNo.Location = new System.Drawing.Point(78, 99);
            this.TxtSeriNo.Name = "TxtSeriNo";
            this.TxtSeriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.TxtSeriNo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSeriNo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtSeriNo.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSeriNo.Properties.Appearance.Options.UseFont = true;
            this.TxtSeriNo.Properties.Appearance.Options.UseForeColor = true;
            this.TxtSeriNo.Properties.BeepOnError = false;
            this.TxtSeriNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtSeriNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSeriNo.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.TxtSeriNo.Properties.MaskSettings.Set("mask", "AAAAA");
            this.TxtSeriNo.Size = new System.Drawing.Size(80, 26);
            this.TxtSeriNo.TabIndex = 1;
            this.TxtSeriNo.Tag = "";
            this.TxtSeriNo.Click += new System.EventHandler(this.TxtSeriNo_Click);
            // 
            // pictureEdit8
            // 
            this.pictureEdit8.EditValue = ((object)(resources.GetObject("pictureEdit8.EditValue")));
            this.pictureEdit8.Location = new System.Drawing.Point(10, 88);
            this.pictureEdit8.Name = "pictureEdit8";
            this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit8.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit8.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit8.Size = new System.Drawing.Size(46, 40);
            this.pictureEdit8.TabIndex = 95;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(10, 281);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(282, 112);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Arıza Detayları";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(10, 209);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(46, 40);
            this.pictureEdit2.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(78, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 3);
            this.panel1.TabIndex = 98;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ürün Kaydoldu",
            "Parça Bekliyor",
            "Mesaj Bekliyor",
            "İptal Edildi",
            "Fiyat Verildi"});
            this.comboBox1.Location = new System.Drawing.Point(78, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 29);
            this.comboBox1.TabIndex = 3;
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnVazgec.ImageOptions.Image")));
            this.BtnVazgec.Location = new System.Drawing.Point(165, 409);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(127, 34);
            this.BtnVazgec.TabIndex = 100;
            this.BtnVazgec.Text = "Vazgeç";
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // FrmArizaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(304, 469);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.TxtSeriNo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureEdit8);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.TxtTarih);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnGuncelle);
            this.Name = "FrmArizaDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arıza Detay";
            this.Load += new System.EventHandler(this.FrmArizaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.TextEdit TxtTarih;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.TextEdit TxtSeriNo;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.SimpleButton BtnVazgec;
    }
}