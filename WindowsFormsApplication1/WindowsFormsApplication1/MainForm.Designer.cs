namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.Ext_Config_Button = new System.Windows.Forms.Button();
            this.ClientBased_Sync_Radio = new System.Windows.Forms.RadioButton();
            this.ServerBased_sync_Radio = new System.Windows.Forms.RadioButton();
            this.Schedule_Button = new System.Windows.Forms.Button();
            this.Sync_Button = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // Ext_Config_Button
            // 
            this.Ext_Config_Button.Location = new System.Drawing.Point(201, 279);
            this.Ext_Config_Button.Name = "Ext_Config_Button";
            this.Ext_Config_Button.Size = new System.Drawing.Size(83, 23);
            this.Ext_Config_Button.TabIndex = 0;
            this.Ext_Config_Button.Text = "Ext. Config";
            this.Ext_Config_Button.UseVisualStyleBackColor = true;
            this.Ext_Config_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientBased_Sync_Radio
            // 
            this.ClientBased_Sync_Radio.AutoSize = true;
            this.ClientBased_Sync_Radio.Location = new System.Drawing.Point(50, 25);
            this.ClientBased_Sync_Radio.Name = "ClientBased_Sync_Radio";
            this.ClientBased_Sync_Radio.Size = new System.Drawing.Size(110, 17);
            this.ClientBased_Sync_Radio.TabIndex = 1;
            this.ClientBased_Sync_Radio.TabStop = true;
            this.ClientBased_Sync_Radio.Text = "Client-Client Sync.";
            this.ClientBased_Sync_Radio.UseVisualStyleBackColor = true;
            // 
            // ServerBased_sync_Radio
            // 
            this.ServerBased_sync_Radio.AutoSize = true;
            this.ServerBased_sync_Radio.Location = new System.Drawing.Point(50, 48);
            this.ServerBased_sync_Radio.Name = "ServerBased_sync_Radio";
            this.ServerBased_sync_Radio.Size = new System.Drawing.Size(115, 17);
            this.ServerBased_sync_Radio.TabIndex = 2;
            this.ServerBased_sync_Radio.TabStop = true;
            this.ServerBased_sync_Radio.Text = "Server-Client Sync.";
            this.ServerBased_sync_Radio.UseVisualStyleBackColor = true;
            // 
            // Schedule_Button
            // 
            this.Schedule_Button.Location = new System.Drawing.Point(290, 279);
            this.Schedule_Button.Name = "Schedule_Button";
            this.Schedule_Button.Size = new System.Drawing.Size(83, 23);
            this.Schedule_Button.TabIndex = 3;
            this.Schedule_Button.Text = "Schedule";
            this.Schedule_Button.UseVisualStyleBackColor = true;
            this.Schedule_Button.Click += new System.EventHandler(this.Schedule_Button_Click);
            // 
            // Sync_Button
            // 
            this.Sync_Button.Location = new System.Drawing.Point(688, 279);
            this.Sync_Button.Name = "Sync_Button";
            this.Sync_Button.Size = new System.Drawing.Size(83, 23);
            this.Sync_Button.TabIndex = 4;
            this.Sync_Button.Text = "Force_Sync";
            this.Sync_Button.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;            
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 314);
            this.Controls.Add(this.Sync_Button);
            this.Controls.Add(this.Schedule_Button);
            this.Controls.Add(this.ServerBased_sync_Radio);
            this.Controls.Add(this.ClientBased_Sync_Radio);
            this.Controls.Add(this.Ext_Config_Button);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ext_Config_Button;
        private System.Windows.Forms.RadioButton ClientBased_Sync_Radio;
        private System.Windows.Forms.RadioButton ServerBased_sync_Radio;
        private System.Windows.Forms.Button Schedule_Button;
        private System.Windows.Forms.Button Sync_Button;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

