namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.img_path = new System.Windows.Forms.TextBox();
            this.btn_selpath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.sel_txt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // img_path
            // 
            this.img_path.Location = new System.Drawing.Point(53, 50);
            this.img_path.Name = "img_path";
            this.img_path.Size = new System.Drawing.Size(363, 22);
            this.img_path.TabIndex = 0;
            // 
            // btn_selpath
            // 
            this.btn_selpath.Location = new System.Drawing.Point(413, 50);
            this.btn_selpath.Name = "btn_selpath";
            this.btn_selpath.Size = new System.Drawing.Size(30, 23);
            this.btn_selpath.TabIndex = 1;
            this.btn_selpath.Text = "...";
            this.btn_selpath.UseVisualStyleBackColor = true;
            this.btn_selpath.Click += new System.EventHandler(this.btn_selpath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "狀態";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(53, 119);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 3;
            this.btn_change.Text = "修改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.Btn_change_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(53, 79);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(363, 22);
            this.txt_path.TabIndex = 5;
            // 
            // sel_txt
            // 
            this.sel_txt.Location = new System.Drawing.Point(413, 78);
            this.sel_txt.Name = "sel_txt";
            this.sel_txt.Size = new System.Drawing.Size(30, 23);
            this.sel_txt.TabIndex = 6;
            this.sel_txt.Text = "...";
            this.sel_txt.UseVisualStyleBackColor = true;
            this.sel_txt.Click += new System.EventHandler(this.Sel_txt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 223);
            this.Controls.Add(this.sel_txt);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_selpath);
            this.Controls.Add(this.img_path);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox img_path;
        private System.Windows.Forms.Button btn_selpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button sel_txt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

