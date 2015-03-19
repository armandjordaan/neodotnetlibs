namespace neolibs.Dialogs
{
    partial class SerialportSetupForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSerialPorts = new System.Windows.Forms.ComboBox();
            this.labBaudrate = new System.Windows.Forms.Label();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.PortSelectStatus = new System.Windows.Forms.Label();
            this.cbIRWakeupEnabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Communications Port:";
            // 
            // cbSerialPorts
            // 
            this.cbSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerialPorts.FormattingEnabled = true;
            this.cbSerialPorts.Location = new System.Drawing.Point(137, 15);
            this.cbSerialPorts.Name = "cbSerialPorts";
            this.cbSerialPorts.Size = new System.Drawing.Size(121, 21);
            this.cbSerialPorts.TabIndex = 3;
            this.cbSerialPorts.SelectedIndexChanged += new System.EventHandler(this.cbSerialPorts_SelectedIndexChanged);
            this.cbSerialPorts.SelectedValueChanged += new System.EventHandler(this.cbSerialPorts_SelectedValueChanged);
            // 
            // labBaudrate
            // 
            this.labBaudrate.AutoSize = true;
            this.labBaudrate.Location = new System.Drawing.Point(22, 45);
            this.labBaudrate.Name = "labBaudrate";
            this.labBaudrate.Size = new System.Drawing.Size(53, 13);
            this.labBaudrate.TabIndex = 4;
            this.labBaudrate.Text = "Baudrate:";
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Location = new System.Drawing.Point(137, 42);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(121, 21);
            this.cbBaudrate.TabIndex = 5;
            // 
            // PortSelectStatus
            // 
            this.PortSelectStatus.AutoSize = true;
            this.PortSelectStatus.Location = new System.Drawing.Point(22, 104);
            this.PortSelectStatus.Name = "PortSelectStatus";
            this.PortSelectStatus.Size = new System.Drawing.Size(35, 13);
            this.PortSelectStatus.TabIndex = 6;
            this.PortSelectStatus.Text = "label3";
            // 
            // cbIRWakeupEnabled
            // 
            this.cbIRWakeupEnabled.AutoSize = true;
            this.cbIRWakeupEnabled.Location = new System.Drawing.Point(25, 71);
            this.cbIRWakeupEnabled.Name = "cbIRWakeupEnabled";
            this.cbIRWakeupEnabled.Size = new System.Drawing.Size(138, 17);
            this.cbIRWakeupEnabled.TabIndex = 7;
            this.cbIRWakeupEnabled.Text = "Enable infrared wakeup";
            this.cbIRWakeupEnabled.UseVisualStyleBackColor = true;
            // 
            // SerialportSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 181);
            this.Controls.Add(this.cbIRWakeupEnabled);
            this.Controls.Add(this.PortSelectStatus);
            this.Controls.Add(this.cbBaudrate);
            this.Controls.Add(this.labBaudrate);
            this.Controls.Add(this.cbSerialPorts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerialportSetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Serialport Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSerialPorts;
        private System.Windows.Forms.Label labBaudrate;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.Label PortSelectStatus;
        private System.Windows.Forms.CheckBox cbIRWakeupEnabled;
    }
}