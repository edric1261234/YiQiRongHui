namespace ShenBao
{
    partial class WangShangJiaoFei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WangShangJiaoFei));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_suode = new System.Windows.Forms.Button();
            this.btn_zengzhi = new System.Windows.Forms.Button();
            this._txt_shuie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(721, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_suode
            // 
            this.btn_suode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_suode.BackgroundImage")));
            this.btn_suode.Location = new System.Drawing.Point(351, 63);
            this.btn_suode.Name = "btn_suode";
            this.btn_suode.Size = new System.Drawing.Size(96, 43);
            this.btn_suode.TabIndex = 2;
            this.btn_suode.UseVisualStyleBackColor = true;
            this.btn_suode.Click += new System.EventHandler(this.btn_suode_Click);
            // 
            // btn_zengzhi
            // 
            this.btn_zengzhi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_zengzhi.BackgroundImage")));
            this.btn_zengzhi.Location = new System.Drawing.Point(243, 61);
            this.btn_zengzhi.Name = "btn_zengzhi";
            this.btn_zengzhi.Size = new System.Drawing.Size(104, 43);
            this.btn_zengzhi.TabIndex = 3;
            this.btn_zengzhi.UseVisualStyleBackColor = true;
            this.btn_zengzhi.Click += new System.EventHandler(this.btn_zengzhi_Click);
            // 
            // _txt_shuie
            // 
            this._txt_shuie.Location = new System.Drawing.Point(1038, 322);
            this._txt_shuie.Name = "_txt_shuie";
            this._txt_shuie.Size = new System.Drawing.Size(100, 21);
            this._txt_shuie.TabIndex = 4;
            // 
            // WangShangJiaoFei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1364, 729);
            this.Controls.Add(this._txt_shuie);
            this.Controls.Add(this.btn_zengzhi);
            this.Controls.Add(this.btn_suode);
            this.Controls.Add(this.button1);
            this.Name = "WangShangJiaoFei";
            this.Text = "WangShangJiaoFei";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_suode;
        private System.Windows.Forms.Button btn_zengzhi;
        private System.Windows.Forms.TextBox _txt_shuie;
    }
}