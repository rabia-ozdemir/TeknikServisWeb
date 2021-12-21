
namespace TEKNİKSERVİS.İletisim
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.TxtAlıcı = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtKonu = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Txtİcerik = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.BtnVazgec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlıcı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtİcerik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAlıcı
            // 
            this.TxtAlıcı.EditValue = "Alıcı";
            this.TxtAlıcı.Location = new System.Drawing.Point(101, 102);
            this.TxtAlıcı.Name = "TxtAlıcı";
            this.TxtAlıcı.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.TxtAlıcı.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAlıcı.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtAlıcı.Properties.Appearance.Options.UseBackColor = true;
            this.TxtAlıcı.Properties.Appearance.Options.UseFont = true;
            this.TxtAlıcı.Properties.Appearance.Options.UseForeColor = true;
            this.TxtAlıcı.Size = new System.Drawing.Size(200, 28);
            this.TxtAlıcı.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(101, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 4);
            this.panel1.TabIndex = 1;
            // 
            // BtnGonder
            // 
            this.BtnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnGonder.Location = new System.Drawing.Point(29, 265);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(134, 37);
            this.BtnGonder.TabIndex = 2;
            this.BtnGonder.Text = "GÖNDER";
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(29, 90);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(47, 46);
            this.pictureEdit1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(73, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(199, 26);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mail Gönderme Paneli";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(101, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 4);
            this.panel2.TabIndex = 6;
            // 
            // TxtKonu
            // 
            this.TxtKonu.EditValue = "Konu";
            this.TxtKonu.Location = new System.Drawing.Point(101, 156);
            this.TxtKonu.Name = "TxtKonu";
            this.TxtKonu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.TxtKonu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKonu.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtKonu.Properties.Appearance.Options.UseBackColor = true;
            this.TxtKonu.Properties.Appearance.Options.UseFont = true;
            this.TxtKonu.Properties.Appearance.Options.UseForeColor = true;
            this.TxtKonu.Size = new System.Drawing.Size(200, 28);
            this.TxtKonu.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(101, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 4);
            this.panel3.TabIndex = 9;
            // 
            // Txtİcerik
            // 
            this.Txtİcerik.EditValue = "İçerik";
            this.Txtİcerik.Location = new System.Drawing.Point(101, 209);
            this.Txtİcerik.Name = "Txtİcerik";
            this.Txtİcerik.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.Txtİcerik.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtİcerik.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.Txtİcerik.Properties.Appearance.Options.UseBackColor = true;
            this.Txtİcerik.Properties.Appearance.Options.UseFont = true;
            this.Txtİcerik.Properties.Appearance.Options.UseForeColor = true;
            this.Txtİcerik.Size = new System.Drawing.Size(200, 28);
            this.Txtİcerik.TabIndex = 3;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(29, 144);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Size = new System.Drawing.Size(47, 46);
            this.pictureEdit2.TabIndex = 10;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(29, 197);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit3.Size = new System.Drawing.Size(47, 46);
            this.pictureEdit3.TabIndex = 11;
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.BtnVazgec.Location = new System.Drawing.Point(169, 265);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(134, 37);
            this.BtnVazgec.TabIndex = 12;
            this.BtnVazgec.Text = "VAZGEÇ";
            this.BtnVazgec.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(340, 339);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Txtİcerik);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtKonu);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.BtnGonder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtAlıcı);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail";
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlıcı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtİcerik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtAlıcı;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton BtnGonder;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TxtKonu;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit Txtİcerik;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.SimpleButton BtnVazgec;
    }
}