
namespace TEKNİKSERVİS
{
    partial class FrmTakvim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTakvim));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btngoster = new System.Windows.Forms.Button();
            this.btnsakla = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(250, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 29);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(250, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Takvim";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(28, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btngoster
            // 
            this.btngoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.btngoster.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngoster.ForeColor = System.Drawing.Color.White;
            this.btngoster.Location = new System.Drawing.Point(437, 26);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(100, 29);
            this.btngoster.TabIndex = 2;
            this.btngoster.Text = "Göster";
            this.btngoster.UseVisualStyleBackColor = false;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // btnsakla
            // 
            this.btnsakla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.btnsakla.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsakla.ForeColor = System.Drawing.Color.White;
            this.btnsakla.Location = new System.Drawing.Point(262, 293);
            this.btnsakla.Name = "btnsakla";
            this.btnsakla.Size = new System.Drawing.Size(100, 29);
            this.btnsakla.TabIndex = 3;
            this.btnsakla.Text = "Sakla";
            this.btnsakla.UseVisualStyleBackColor = false;
            this.btnsakla.Click += new System.EventHandler(this.btnsakla_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.btncikis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ForeColor = System.Drawing.Color.White;
            this.btncikis.Location = new System.Drawing.Point(412, 293);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(100, 29);
            this.btncikis.TabIndex = 4;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // FrmTakvim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 367);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnsakla);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTakvim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTakvim";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btngoster;
        private System.Windows.Forms.Button btnsakla;
        private System.Windows.Forms.Button btncikis;
    }
}