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
            this.FileExt_Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OnlySync_Radio = new System.Windows.Forms.RadioButton();
            this.ExcludeFromSync_Radio = new System.Windows.Forms.RadioButton();
            this.SaveFilter_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileExt_Label
            // 
            this.FileExt_Label.AutoSize = true;
            this.FileExt_Label.Location = new System.Drawing.Point(12, 9);
            this.FileExt_Label.Name = "FileExt_Label";
            this.FileExt_Label.Size = new System.Drawing.Size(75, 13);
            this.FileExt_Label.TabIndex = 2;
            this.FileExt_Label.Text = "File extention :";
            this.FileExt_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 3;
            // 
            // OnlySync_Radio
            // 
            this.OnlySync_Radio.AutoSize = true;
            this.OnlySync_Radio.Location = new System.Drawing.Point(15, 36);
            this.OnlySync_Radio.Name = "OnlySync_Radio";
            this.OnlySync_Radio.Size = new System.Drawing.Size(213, 17);
            this.OnlySync_Radio.TabIndex = 4;
            this.OnlySync_Radio.TabStop = true;
            this.OnlySync_Radio.Text = "Synchronize only files with this extention";
            this.OnlySync_Radio.UseVisualStyleBackColor = true;
            // 
            // ExcludeFromSync_Radio
            // 
            this.ExcludeFromSync_Radio.AutoSize = true;
            this.ExcludeFromSync_Radio.Location = new System.Drawing.Point(15, 59);
            this.ExcludeFromSync_Radio.Name = "ExcludeFromSync_Radio";
            this.ExcludeFromSync_Radio.Size = new System.Drawing.Size(180, 17);
            this.ExcludeFromSync_Radio.TabIndex = 6;
            this.ExcludeFromSync_Radio.TabStop = true;
            this.ExcludeFromSync_Radio.Text = "Synchronize all but this Extention";
            this.ExcludeFromSync_Radio.UseVisualStyleBackColor = true;
            // 
            // SaveFilter_Button
            // 
            this.SaveFilter_Button.Location = new System.Drawing.Point(93, 94);
            this.SaveFilter_Button.Name = "SaveFilter_Button";
            this.SaveFilter_Button.Size = new System.Drawing.Size(75, 23);
            this.SaveFilter_Button.TabIndex = 7;
            this.SaveFilter_Button.Text = "Save Filter";
            this.SaveFilter_Button.UseVisualStyleBackColor = true;
            this.SaveFilter_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileMaskFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 129);
            this.Controls.Add(this.SaveFilter_Button);
            this.Controls.Add(this.ExcludeFromSync_Radio);
            this.Controls.Add(this.OnlySync_Radio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FileExt_Label);
            this.Name = "FileMaskFrom";
            this.Text = "Mask Options";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileExt_Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton OnlySync_Radio;
        private System.Windows.Forms.RadioButton ExcludeFromSync_Radio;
        private System.Windows.Forms.Button SaveFilter_Button;
    }
}