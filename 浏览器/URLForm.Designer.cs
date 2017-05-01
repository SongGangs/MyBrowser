namespace 浏览器
{
    partial class URLForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.ESC_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 25);
            this.textBox1.TabIndex = 0;
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("宋体", 13F);
            this.OK_button.Location = new System.Drawing.Point(99, 59);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(70, 35);
            this.OK_button.TabIndex = 1;
            this.OK_button.Text = "确定";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // ESC_button
            // 
            this.ESC_button.Font = new System.Drawing.Font("宋体", 13F);
            this.ESC_button.Location = new System.Drawing.Point(296, 59);
            this.ESC_button.Name = "ESC_button";
            this.ESC_button.Size = new System.Drawing.Size(70, 35);
            this.ESC_button.TabIndex = 2;
            this.ESC_button.Text = "取消";
            this.ESC_button.UseVisualStyleBackColor = true;
            this.ESC_button.Click += new System.EventHandler(this.ESC_button_Click);
            // 
            // URLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 106);
            this.Controls.Add(this.ESC_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "URLForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网址";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button ESC_button;
    }
}