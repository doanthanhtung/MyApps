
namespace Grammar_Check
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnActive = new System.Windows.Forms.Button();
            this.txtActiveResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bản quyền thuộc về Doãn Thanh Tùng";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(31, 57);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(295, 20);
            this.txtKey.TabIndex = 1;
            this.txtKey.Text = "Nhập KEY";
            this.txtKey.Click += new System.EventHandler(this.clearKey);
            this.txtKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveKey);
            // 
            // btnActive
            // 
            this.btnActive.Location = new System.Drawing.Point(251, 90);
            this.btnActive.Margin = new System.Windows.Forms.Padding(10);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(75, 36);
            this.btnActive.TabIndex = 2;
            this.btnActive.Text = "Kích hoạt";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // txtActiveResult
            // 
            this.txtActiveResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActiveResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtActiveResult.Enabled = false;
            this.txtActiveResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActiveResult.Location = new System.Drawing.Point(31, 139);
            this.txtActiveResult.Name = "txtActiveResult";
            this.txtActiveResult.ReadOnly = true;
            this.txtActiveResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtActiveResult.Size = new System.Drawing.Size(295, 67);
            this.txtActiveResult.TabIndex = 3;
            this.txtActiveResult.Text = "";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 227);
            this.Controls.Add(this.txtActiveResult);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.RichTextBox txtActiveResult;
    }
}