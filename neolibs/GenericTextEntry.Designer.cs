namespace Sema.Dialogs
{
    partial class GenericTextEntry
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
            this.tbEditText = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.TextEntryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEditText
            // 
            this.tbEditText.Location = new System.Drawing.Point(30, 50);
            this.tbEditText.Name = "tbEditText";
            this.tbEditText.Size = new System.Drawing.Size(371, 20);
            this.tbEditText.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(120, 76);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(201, 76);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // TextEntryLabel
            // 
            this.TextEntryLabel.AutoSize = true;
            this.TextEntryLabel.Location = new System.Drawing.Point(27, 18);
            this.TextEntryLabel.Name = "TextEntryLabel";
            this.TextEntryLabel.Size = new System.Drawing.Size(35, 13);
            this.TextEntryLabel.TabIndex = 3;
            this.TextEntryLabel.Text = "label1";
            // 
            // GenericTextEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 125);
            this.Controls.Add(this.TextEntryLabel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tbEditText);
            this.Name = "GenericTextEntry";
            this.Text = "GenericTextEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEditText;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label TextEntryLabel;
    }
}