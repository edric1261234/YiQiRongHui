namespace ShenBao
{
    partial class JinXiangCaiJi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JinXiangCaiJi));
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_koushui = new System.Windows.Forms.TextBox();
            this.btn_suode = new System.Windows.Forms.Button();
            this.btn_zengzhi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(677, 255);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 21);
            this.txt_total.TabIndex = 0;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // txt_koushui
            // 
            this.txt_koushui.Location = new System.Drawing.Point(1033, 255);
            this.txt_koushui.Name = "txt_koushui";
            this.txt_koushui.Size = new System.Drawing.Size(100, 21);
            this.txt_koushui.TabIndex = 1;
            // 
            // btn_suode
            // 
            this.btn_suode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_suode.BackgroundImage")));
            this.btn_suode.Location = new System.Drawing.Point(348, 63);
            this.btn_suode.Name = "btn_suode";
            this.btn_suode.Size = new System.Drawing.Size(96, 43);
            this.btn_suode.TabIndex = 2;
            this.btn_suode.UseVisualStyleBackColor = true;
            this.btn_suode.Click += new System.EventHandler(this.btn_suode_Click);
            // 
            // btn_zengzhi
            // 
            this.btn_zengzhi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_zengzhi.BackgroundImage")));
            this.btn_zengzhi.Location = new System.Drawing.Point(247, 63);
            this.btn_zengzhi.Name = "btn_zengzhi";
            this.btn_zengzhi.Size = new System.Drawing.Size(104, 43);
            this.btn_zengzhi.TabIndex = 3;
            this.btn_zengzhi.UseVisualStyleBackColor = true;
            this.btn_zengzhi.Click += new System.EventHandler(this.btn_zengzhi_Click);
            // 
            // JinXiangCaiJi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1364, 729);
            this.Controls.Add(this.btn_zengzhi);
            this.Controls.Add(this.btn_suode);
            this.Controls.Add(this.txt_koushui);
            this.Controls.Add(this.txt_total);
            this.Name = "JinXiangCaiJi";
            this.Text = "JinXiangCaiJi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_koushui;
        private System.Windows.Forms.Button btn_suode;
        private System.Windows.Forms.Button btn_zengzhi;
    }
}