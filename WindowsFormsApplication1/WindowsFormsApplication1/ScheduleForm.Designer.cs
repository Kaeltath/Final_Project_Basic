namespace WindowsFormsApplication1
{
    partial class ScheduleForm
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
            this.Daily_Radio = new System.Windows.Forms.RadioButton();
            this.Hourly_Radio = new System.Windows.Forms.RadioButton();
            this.TenMin_radio = new System.Windows.Forms.RadioButton();
            this.UserSetSch_Radio = new System.Windows.Forms.RadioButton();
            this.Timer_textbox = new System.Windows.Forms.TextBox();
            this.min_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Daily_Radio
            // 
            this.Daily_Radio.AutoSize = true;
            this.Daily_Radio.Location = new System.Drawing.Point(23, 33);
            this.Daily_Radio.Name = "Daily_Radio";
            this.Daily_Radio.Size = new System.Drawing.Size(48, 17);
            this.Daily_Radio.TabIndex = 0;
            this.Daily_Radio.TabStop = true;
            this.Daily_Radio.Text = "Daily";
            this.Daily_Radio.UseVisualStyleBackColor = true;
            
            // 
            // Hourly_Radio
            // 
            this.Hourly_Radio.AutoSize = true;
            this.Hourly_Radio.Location = new System.Drawing.Point(23, 56);
            this.Hourly_Radio.Name = "Hourly_Radio";
            this.Hourly_Radio.Size = new System.Drawing.Size(55, 17);
            this.Hourly_Radio.TabIndex = 1;
            this.Hourly_Radio.TabStop = true;
            this.Hourly_Radio.Text = "Hourly";
            this.Hourly_Radio.UseVisualStyleBackColor = true;
            
            // 
            // TenMin_radio
            // 
            this.TenMin_radio.AutoSize = true;
            this.TenMin_radio.Location = new System.Drawing.Point(23, 79);
            this.TenMin_radio.Name = "TenMin_radio";
            this.TenMin_radio.Size = new System.Drawing.Size(86, 17);
            this.TenMin_radio.TabIndex = 2;
            this.TenMin_radio.TabStop = true;
            this.TenMin_radio.Text = "Every 10 min";
            this.TenMin_radio.UseVisualStyleBackColor = true;
            
            // 
            // UserSetSch_Radio
            // 
            this.UserSetSch_Radio.AutoSize = true;
            this.UserSetSch_Radio.Location = new System.Drawing.Point(23, 102);
            this.UserSetSch_Radio.Name = "UserSetSch_Radio";
            this.UserSetSch_Radio.Size = new System.Drawing.Size(52, 17);
            this.UserSetSch_Radio.TabIndex = 3;
            this.UserSetSch_Radio.TabStop = true;
            this.UserSetSch_Radio.Text = "Every";
            this.UserSetSch_Radio.UseVisualStyleBackColor = true;
            
            // 
            // Timer_textbox
            // 
            this.Timer_textbox.Location = new System.Drawing.Point(72, 101);
            this.Timer_textbox.Name = "Timer_textbox";
            this.Timer_textbox.Size = new System.Drawing.Size(27, 20);
            this.Timer_textbox.TabIndex = 4;
            this.Timer_textbox.Text = "5";
            // 
            // min_label
            // 
            this.min_label.AutoSize = true;
            this.min_label.Location = new System.Drawing.Point(105, 106);
            this.min_label.Name = "min_label";
            this.min_label.Size = new System.Drawing.Size(23, 13);
            this.min_label.TabIndex = 5;
            this.min_label.Text = "min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Synchronization frequency";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 175);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.min_label);
            this.Controls.Add(this.Timer_textbox);
            this.Controls.Add(this.UserSetSch_Radio);
            this.Controls.Add(this.TenMin_radio);
            this.Controls.Add(this.Hourly_Radio);
            this.Controls.Add(this.Daily_Radio);
            this.Name = "ScheduleForm";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Daily_Radio;
        private System.Windows.Forms.RadioButton Hourly_Radio;
        private System.Windows.Forms.RadioButton TenMin_radio;
        private System.Windows.Forms.RadioButton UserSetSch_Radio;
        private System.Windows.Forms.TextBox Timer_textbox;
        private System.Windows.Forms.Label min_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}