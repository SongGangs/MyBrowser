namespace 浏览器
{
    partial class BookMarkForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.URLText = new System.Windows.Forms.TextBox();
            this.BOOKcomboBox = new System.Windows.Forms.ComboBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.ESC_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "书签分类";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "书签名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "书签网址";
            // 
            // TitleTxt
            // 
            this.TitleTxt.Location = new System.Drawing.Point(175, 97);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(277, 25);
            this.TitleTxt.TabIndex = 4;
            // 
            // URLText
            // 
            this.URLText.Location = new System.Drawing.Point(175, 163);
            this.URLText.Name = "URLText";
            this.URLText.Size = new System.Drawing.Size(277, 25);
            this.URLText.TabIndex = 5;
            // 
            // BOOKcomboBox
            // 
            this.BOOKcomboBox.FormattingEnabled = true;
            this.BOOKcomboBox.Location = new System.Drawing.Point(175, 33);
            this.BOOKcomboBox.Name = "BOOKcomboBox";
            this.BOOKcomboBox.Size = new System.Drawing.Size(277, 23);
            this.BOOKcomboBox.TabIndex = 6;
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("宋体", 15F);
            this.OK_button.Location = new System.Drawing.Point(128, 220);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(84, 33);
            this.OK_button.TabIndex = 7;
            this.OK_button.Text = "确定";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // ESC_button
            // 
            this.ESC_button.Font = new System.Drawing.Font("宋体", 15F);
            this.ESC_button.Location = new System.Drawing.Point(304, 220);
            this.ESC_button.Name = "ESC_button";
            this.ESC_button.Size = new System.Drawing.Size(84, 33);
            this.ESC_button.TabIndex = 8;
            this.ESC_button.Text = "取消";
            this.ESC_button.UseVisualStyleBackColor = true;
            this.ESC_button.Click += new System.EventHandler(this.ESC_button_Click);
            // 
            // BookMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 265);
            this.Controls.Add(this.ESC_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.BOOKcomboBox);
            this.Controls.Add(this.URLText);
            this.Controls.Add(this.TitleTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BookMarkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "书签收藏";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.TextBox URLText;
        private System.Windows.Forms.ComboBox BOOKcomboBox;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button ESC_button;
    }
}