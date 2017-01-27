namespace WindowsFormsApplication1
{
    partial class FileMaskFrom
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
            this.SaveFilter_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WhiteList_Textbox = new System.Windows.Forms.TextBox();
            this.BlackList_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveFilter_Button
            // 
            this.SaveFilter_Button.Location = new System.Drawing.Point(123, 119);
            this.SaveFilter_Button.Name = "SaveFilter_Button";
            this.SaveFilter_Button.Size = new System.Drawing.Size(75, 23);
            this.SaveFilter_Button.TabIndex = 7;
            this.SaveFilter_Button.Text = "Save Filter";
            this.SaveFilter_Button.UseVisualStyleBackColor = true;
            this.SaveFilter_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "White list:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Black list";
            // 
            // WhiteList_Textbox
            // 
            this.WhiteList_Textbox.Location = new System.Drawing.Point(72, 20);
            this.WhiteList_Textbox.Name = "WhiteList_Textbox";
            this.WhiteList_Textbox.Size = new System.Drawing.Size(247, 20);
            this.WhiteList_Textbox.TabIndex = 10;
            // 
            // BlackList_Textbox
            // 
            this.BlackList_Textbox.Location = new System.Drawing.Point(72, 72);
            this.BlackList_Textbox.Name = "BlackList_Textbox";
            this.BlackList_Textbox.Size = new System.Drawing.Size(247, 20);
            this.BlackList_Textbox.TabIndex = 11;
            // 
            // FileMaskFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 154);
            this.Controls.Add(this.BlackList_Textbox);
            this.Controls.Add(this.WhiteList_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveFilter_Button);
            this.Name = "FileMaskFrom";
            this.Text = "Mask Options";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveFilter_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WhiteList_Textbox;
        private System.Windows.Forms.TextBox BlackList_Textbox;
    }
}