namespace ShenBao
{
    partial class Import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
            this._btn_import = new System.Windows.Forms.Button();
            this._btn_import_xml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btn_import
            // 
            this._btn_import.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btn_import.BackgroundImage")));
            this._btn_import.Location = new System.Drawing.Point(605, 193);
            this._btn_import.Name = "_btn_import";
            this._btn_import.Size = new System.Drawing.Size(80, 27);
            this._btn_import.TabIndex = 0;
            this._btn_import.UseVisualStyleBackColor = true;
            this._btn_import.Click += new System.EventHandler(this._btn_import_Click);
            // 
            // _btn_import_xml
            // 
            this._btn_import_xml.Location = new System.Drawing.Point(605, 217);
            this._btn_import_xml.Name = "_btn_import_xml";
            this._btn_import_xml.Size = new System.Drawing.Size(105, 37);
            this._btn_import_xml.TabIndex = 1;
            this._btn_import_xml.Text = "导入xml文件";
            this._btn_import_xml.UseVisualStyleBackColor = true;
            this._btn_import_xml.Visible = false;
            this._btn_import_xml.Click += new System.EventHandler(this._btn_import_xml_Click);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 727);
            this.Controls.Add(this._btn_import_xml);
            this.Controls.Add(this._btn_import);
            this.Name = "Import";
            this.Text = "Import";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btn_import;
        private System.Windows.Forms.Button _btn_import_xml;
    }
}