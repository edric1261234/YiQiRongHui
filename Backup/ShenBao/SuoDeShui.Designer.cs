namespace ShenBao
{
    partial class SuoDeShui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuoDeShui));
            this.btn_sbbtx = new System.Windows.Forms.Button();
            this.btn_wssb = new System.Windows.Forms.Button();
            this.btn_suode = new System.Windows.Forms.Button();
            this.btn_zengzhi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sbbtx
            // 
            this.btn_sbbtx.Location = new System.Drawing.Point(52, 204);
            this.btn_sbbtx.Name = "btn_sbbtx";
            this.btn_sbbtx.Size = new System.Drawing.Size(113, 23);
            this.btn_sbbtx.TabIndex = 0;
            this.btn_sbbtx.Text = "报表填写";
            this.btn_sbbtx.UseVisualStyleBackColor = true;
            this.btn_sbbtx.Click += new System.EventHandler(this.btn_sbbtx_Click);
            // 
            // btn_wssb
            // 
            this.btn_wssb.Location = new System.Drawing.Point(52, 228);
            this.btn_wssb.Name = "btn_wssb";
            this.btn_wssb.Size = new System.Drawing.Size(113, 28);
            this.btn_wssb.TabIndex = 1;
            this.btn_wssb.Text = "申报表发送";
            this.btn_wssb.UseVisualStyleBackColor = true;
            this.btn_wssb.Click += new System.EventHandler(this.btn_wssb_Click);
            // 
            // btn_suode
            // 
            this.btn_suode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_suode.BackgroundImage")));
            this.btn_suode.Location = new System.Drawing.Point(350, 62);
            this.btn_suode.Name = "btn_suode";
            this.btn_suode.Size = new System.Drawing.Size(96, 43);
            this.btn_suode.TabIndex = 2;
            this.btn_suode.UseVisualStyleBackColor = true;
            this.btn_suode.Click += new System.EventHandler(this.btn_suode_Click);
            // 
            // btn_zengzhi
            // 
            this.btn_zengzhi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_zengzhi.BackgroundImage")));
            this.btn_zengzhi.Location = new System.Drawing.Point(246, 62);
            this.btn_zengzhi.Name = "btn_zengzhi";
            this.btn_zengzhi.Size = new System.Drawing.Size(104, 43);
            this.btn_zengzhi.TabIndex = 3;
            this.btn_zengzhi.UseVisualStyleBackColor = true;
            this.btn_zengzhi.Click += new System.EventHandler(this.btn_zengzhi_Click);
            // 
            // SuoDeShui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 727);
            this.Controls.Add(this.btn_zengzhi);
            this.Controls.Add(this.btn_suode);
            this.Controls.Add(this.btn_wssb);
            this.Controls.Add(this.btn_sbbtx);
            this.Name = "SuoDeShui";
            this.Text = "SuoDeShui";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sbbtx;
        private System.Windows.Forms.Button btn_wssb;
        private System.Windows.Forms.Button btn_suode;
        private System.Windows.Forms.Button btn_zengzhi;
    }
}