
namespace TEKNİKSERVİS.Formlar
{
    partial class FrmMaps
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
            this.Txtcadde = new System.Windows.Forms.TextBox();
            this.Txtsehir = new System.Windows.Forms.TextBox();
            this.Txtulke = new System.Windows.Forms.TextBox();
            this.Txtposta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txtcadde
            // 
            this.Txtcadde.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtcadde.Location = new System.Drawing.Point(111, 30);
            this.Txtcadde.Name = "Txtcadde";
            this.Txtcadde.Size = new System.Drawing.Size(190, 29);
            this.Txtcadde.TabIndex = 0;
            // 
            // Txtsehir
            // 
            this.Txtsehir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtsehir.Location = new System.Drawing.Point(111, 66);
            this.Txtsehir.Name = "Txtsehir";
            this.Txtsehir.Size = new System.Drawing.Size(190, 29);
            this.Txtsehir.TabIndex = 1;
            // 
            // Txtulke
            // 
            this.Txtulke.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtulke.Location = new System.Drawing.Point(111, 103);
            this.Txtulke.Name = "Txtulke";
            this.Txtulke.Size = new System.Drawing.Size(190, 29);
            this.Txtulke.TabIndex = 2;
            // 
            // Txtposta
            // 
            this.Txtposta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtposta.Location = new System.Drawing.Point(111, 143);
            this.Txtposta.Name = "Txtposta";
            this.Txtposta.Size = new System.Drawing.Size(190, 29);
            this.Txtposta.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(141, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(309, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1042, 507);
            this.webBrowser1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cadde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şehir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(59, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ülke:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Posta Kodu:";
            // 
            // FrmMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txtposta);
            this.Controls.Add(this.Txtulke);
            this.Controls.Add(this.Txtsehir);
            this.Controls.Add(this.Txtcadde);
            this.Name = "FrmMaps";
            this.Text = "FrmMaps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtcadde;
        private System.Windows.Forms.TextBox Txtsehir;
        private System.Windows.Forms.TextBox Txtulke;
        private System.Windows.Forms.TextBox Txtposta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}