namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.translateButton = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.numberTextbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(251, 16);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(75, 23);
            this.translateButton.TabIndex = 0;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // languageComboBox
            // 
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "German",
            "French",
            "Spanish"});
            this.languageComboBox.Location = new System.Drawing.Point(114, 16);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(121, 21);
            this.languageComboBox.TabIndex = 1;
            // 
            // numberTextbox
            // 
            this.numberTextbox.Location = new System.Drawing.Point(8, 16);
            this.numberTextbox.Mask = "0000";
            this.numberTextbox.Name = "numberTextbox";
            this.numberTextbox.Size = new System.Drawing.Size(100, 20);
            this.numberTextbox.TabIndex = 3;
            this.numberTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 261);
            this.Controls.Add(this.numberTextbox);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.translateButton);
            this.Name = "Form1";
            this.Text = "Translate Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.MaskedTextBox numberTextbox;
    }
}

