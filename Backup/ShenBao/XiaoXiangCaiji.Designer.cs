namespace ShenBao
{
    partial class XiaoXiangCaiji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XiaoXiangCaiji));
            this.btn_suode = new System.Windows.Forms.Button();
            this.btn_zengzhi = new System.Windows.Forms.Button();
            this._btn_get_xiaoxiang = new System.Windows.Forms.Button();
            this._txt_shuie = new System.Windows.Forms.TextBox();
            this._btn_jine = new System.Windows.Forms.Button();
            this._txt_total_shuier = new System.Windows.Forms.TextBox();
            this._txt_total_jiner = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_suode
            // 
            this.btn_suode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_suode.BackgroundImage")));
            this.btn_suode.Location = new System.Drawing.Point(349, 61);
            this.btn_suode.Name = "btn_suode";
            this.btn_suode.Size = new System.Drawing.Size(96, 43);
            this.btn_suode.TabIndex = 2;
            this.btn_suode.UseVisualStyleBackColor = true;
            this.btn_suode.Click += new System.EventHandler(this.btn_suode_Click);
            // 
            // btn_zengzhi
            // 
            this.btn_zengzhi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_zengzhi.BackgroundImage")));
            this.btn_zengzhi.Location = new System.Drawing.Point(245, 61);
            this.btn_zengzhi.Name = "btn_zengzhi";
            this.btn_zengzhi.Size = new System.Drawing.Size(104, 43);
            this.btn_zengzhi.TabIndex = 3;
            this.btn_zengzhi.UseVisualStyleBackColor = true;
            this.btn_zengzhi.Click += new System.EventHandler(this.btn_zengzhi_Click);
            // 
            // _btn_get_xiaoxiang
            // 
            this._btn_get_xiaoxiang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btn_get_xiaoxiang.BackgroundImage")));
            this._btn_get_xiaoxiang.Location = new System.Drawing.Point(1162, 168);
            this._btn_get_xiaoxiang.Name = "_btn_get_xiaoxiang";
            this._btn_get_xiaoxiang.Size = new System.Drawing.Size(130, 36);
            this._btn_get_xiaoxiang.TabIndex = 5;
            this._btn_get_xiaoxiang.UseVisualStyleBackColor = true;
            this._btn_get_xiaoxiang.Visible = false;
            // 
            // _txt_shuie
            // 
            this._txt_shuie.Location = new System.Drawing.Point(1008, 263);
            this._txt_shuie.Name = "_txt_shuie";
            this._txt_shuie.Size = new System.Drawing.Size(100, 21);
            this._txt_shuie.TabIndex = 6;
            this._txt_shuie.Text = "0";
            // 
            // _btn_jine
            // 
            this._btn_jine.Location = new System.Drawing.Point(808, 261);
            this._btn_jine.Name = "_btn_jine";
            this._btn_jine.Size = new System.Drawing.Size(75, 23);
            this._btn_jine.TabIndex = 7;
            this._btn_jine.Text = "0";
            this._btn_jine.UseVisualStyleBackColor = true;
            this._btn_jine.Click += new System.EventHandler(this._btn_jine_Click);
            // 
            // _txt_total_shuier
            // 
            this._txt_total_shuier.Enabled = false;
            this._txt_total_shuier.Location = new System.Drawing.Point(1008, 553);
            this._txt_total_shuier.Name = "_txt_total_shuier";
            this._txt_total_shuier.Size = new System.Drawing.Size(100, 21);
            this._txt_total_shuier.TabIndex = 6;
            this._txt_total_shuier.Text = "0";
            // 
            // _txt_total_jiner
            // 
            this._txt_total_jiner.Enabled = false;
            this._txt_total_jiner.Location = new System.Drawing.Point(783, 553);
            this._txt_total_jiner.Name = "_txt_total_jiner";
            this._txt_total_jiner.Size = new System.Drawing.Size(100, 21);
            this._txt_total_jiner.TabIndex = 6;
            this._txt_total_jiner.Text = "0";
            // 
            // XiaoXiangCaiji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1362, 678);
            this.Controls.Add(this._btn_jine);
            this.Controls.Add(this._txt_total_jiner);
            this.Controls.Add(this._txt_total_shuier);
            this.Controls.Add(this._txt_shuie);
            this.Controls.Add(this._btn_get_xiaoxiang);
            this.Controls.Add(this.btn_zengzhi);
            this.Controls.Add(this.btn_suode);
            this.Name = "XiaoXiangCaiji";
            this.Text = "XiaoXiangCaiji";
            this.Load += new System.EventHandler(this.XiaoXiangCaiji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_suode;
        private System.Windows.Forms.Button btn_zengzhi;
        private System.Windows.Forms.Button _btn_get_xiaoxiang;
        private System.Windows.Forms.TextBox _txt_shuie;
        private System.Windows.Forms.Button _btn_jine;
        private System.Windows.Forms.TextBox _txt_total_shuier;
        private System.Windows.Forms.TextBox _txt_total_jiner;
    }
}