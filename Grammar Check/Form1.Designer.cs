
namespace Grammar_Check
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheckGrammar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.AccessibleDescription = "test";
            this.txtText.AccessibleName = "test";
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.BackColor = System.Drawing.SystemColors.Control;
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(12, 12);
            this.txtText.Margin = new System.Windows.Forms.Padding(12);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(264, 424);
            this.txtText.TabIndex = 0;
            this.txtText.Tag = "";
            this.txtText.Text = "";
            this.txtText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(300, 12);
            this.txtResult.Margin = new System.Windows.Forms.Padding(12);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(632, 424);
            this.txtResult.TabIndex = 5;
            this.txtResult.Text = "";
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Image = global::Grammar_Check.Properties.Resources.about;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(192, 443);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(84, 46);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::Grammar_Check.Properties.Resources.iconfinder_broom_clean_service_labor_website_4622511_122412;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(102, 443);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 46);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheckGrammar
            // 
            this.btnCheckGrammar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckGrammar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckGrammar.Image = global::Grammar_Check.Properties.Resources.research_icon_142638;
            this.btnCheckGrammar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckGrammar.Location = new System.Drawing.Point(12, 443);
            this.btnCheckGrammar.Name = "btnCheckGrammar";
            this.btnCheckGrammar.Size = new System.Drawing.Size(84, 46);
            this.btnCheckGrammar.TabIndex = 1;
            this.btnCheckGrammar.Text = "Check";
            this.btnCheckGrammar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckGrammar.UseVisualStyleBackColor = true;
            this.btnCheckGrammar.Click += new System.EventHandler(this.btnCheckGrammar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnCheckGrammar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grammar Check";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckGrammar;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnAbout;
    }
}

