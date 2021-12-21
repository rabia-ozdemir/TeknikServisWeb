
namespace TEKNİKSERVİS.Formlar
{
    partial class FrmYeniPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniPersonel));
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.BtnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TxtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtFotograf = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFotograf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(119, 238);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lookUpEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "AD";
            this.lookUpEdit1.Properties.NullText = "Departman";
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(211, 28);
            this.lookUpEdit1.TabIndex = 3;
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnVazgec.ImageOptions.Image")));
            this.BtnVazgec.Location = new System.Drawing.Point(203, 442);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(127, 34);
            this.BtnVazgec.TabIndex = 8;
            this.BtnVazgec.Text = "VAZGEÇ";
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(51, 442);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(127, 34);
            this.BtnKaydet.TabIndex = 7;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // textEdit7
            // 
            this.textEdit7.EditValue = "YENİ PERSONEL EKLEME";
            this.textEdit7.Location = new System.Drawing.Point(147, 65);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.textEdit7.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit7.Properties.Appearance.Options.UseFont = true;
            this.textEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit7.Size = new System.Drawing.Size(198, 26);
            this.textEdit7.TabIndex = 38;
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Location = new System.Drawing.Point(51, 26);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Size = new System.Drawing.Size(79, 79);
            this.pictureEdit7.TabIndex = 37;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(119, 419);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(211, 3);
            this.panel6.TabIndex = 36;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.EditValue = "Telefon";
            this.TxtTelefon.Location = new System.Drawing.Point(119, 394);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.TxtTelefon.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTelefon.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtTelefon.Properties.Appearance.Options.UseBackColor = true;
            this.TxtTelefon.Properties.Appearance.Options.UseFont = true;
            this.TxtTelefon.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTelefon.Properties.BeepOnError = false;
            this.TxtTelefon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtTelefon.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtTelefon.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.TxtTelefon.Properties.MaskSettings.Set("mask", "000-000-00-00");
            this.TxtTelefon.Size = new System.Drawing.Size(211, 26);
            this.TxtTelefon.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(119, 371);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 3);
            this.panel5.TabIndex = 34;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(51, 336);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit6.Size = new System.Drawing.Size(46, 40);
            this.pictureEdit6.TabIndex = 35;
            // 
            // TxtMail
            // 
            this.TxtMail.EditValue = "Mail ";
            this.TxtMail.Location = new System.Drawing.Point(119, 346);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.TxtMail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtMail.Properties.Appearance.Options.UseBackColor = true;
            this.TxtMail.Properties.Appearance.Options.UseFont = true;
            this.TxtMail.Properties.Appearance.Options.UseForeColor = true;
            this.TxtMail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtMail.Size = new System.Drawing.Size(211, 26);
            this.TxtMail.TabIndex = 5;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(51, 382);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit5.Size = new System.Drawing.Size(46, 40);
            this.pictureEdit5.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(119, 319);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 3);
            this.panel4.TabIndex = 26;
            // 
            // TxtFotograf
            // 
            this.TxtFotograf.EditValue = "Fotoğraf";
            this.TxtFotograf.Location = new System.Drawing.Point(119, 294);
            this.TxtFotograf.Name = "TxtFotograf";
            this.TxtFotograf.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.TxtFotograf.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFotograf.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtFotograf.Properties.Appearance.Options.UseBackColor = true;
            this.TxtFotograf.Properties.Appearance.Options.UseFont = true;
            this.TxtFotograf.Properties.Appearance.Options.UseForeColor = true;
            this.TxtFotograf.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtFotograf.Size = new System.Drawing.Size(211, 26);
            this.TxtFotograf.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(119, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 3);
            this.panel3.TabIndex = 31;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(51, 282);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(46, 40);
            this.pictureEdit4.TabIndex = 22;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(51, 230);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(46, 40);
            this.pictureEdit3.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(119, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 3);
            this.panel2.TabIndex = 27;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.EditValue = "Soyad";
            this.TxtSoyad.Location = new System.Drawing.Point(119, 187);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.TxtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtSoyad.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSoyad.Properties.Appearance.Options.UseFont = true;
            this.TxtSoyad.Properties.Appearance.Options.UseForeColor = true;
            this.TxtSoyad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtSoyad.Size = new System.Drawing.Size(211, 26);
            this.TxtSoyad.TabIndex = 2;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(51, 175);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(46, 40);
            this.pictureEdit2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(119, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 3);
            this.panel1.TabIndex = 19;
            // 
            // TxtAd
            // 
            this.TxtAd.EditValue = "Ad";
            this.TxtAd.Location = new System.Drawing.Point(119, 138);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.TxtAd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtAd.Properties.Appearance.Options.UseBackColor = true;
            this.TxtAd.Properties.Appearance.Options.UseFont = true;
            this.TxtAd.Properties.Appearance.Options.UseForeColor = true;
            this.TxtAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtAd.Size = new System.Drawing.Size(211, 26);
            this.TxtAd.TabIndex = 1;
            // 
            // pictureEdit8
            // 
            this.pictureEdit8.EditValue = ((object)(resources.GetObject("pictureEdit8.EditValue")));
            this.pictureEdit8.Location = new System.Drawing.Point(51, 126);
            this.pictureEdit8.Name = "pictureEdit8";
            this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit8.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit8.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit8.Size = new System.Drawing.Size(46, 40);
            this.pictureEdit8.TabIndex = 39;
            // 
            // FrmYeniPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(381, 502);
            this.Controls.Add(this.pictureEdit8);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.pictureEdit7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.TxtTelefon);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureEdit6);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.pictureEdit5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TxtFotograf);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtAd);
            this.Name = "FrmYeniPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Personel";
            this.Load += new System.EventHandler(this.FrmYeniPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFotograf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton BtnVazgec;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.TextEdit TxtTelefon;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.TextEdit TxtFotograf;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TxtSoyad;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
    }
}