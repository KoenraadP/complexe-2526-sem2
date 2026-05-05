namespace Flags
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
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.pbxFlag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Items.AddRange(new object[] {
            "Nederlands",
            "English",
            "Français",
            "Deutsch"});
            this.cbxLanguage.Location = new System.Drawing.Point(13, 13);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(197, 21);
            this.cbxLanguage.TabIndex = 0;
            this.cbxLanguage.SelectedIndexChanged += new System.EventHandler(this.CbxLanguage_SelectedIndexChanged);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(13, 41);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(71, 13);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "Hallo Wereld!";
            // 
            // pbxFlag
            // 
            this.pbxFlag.Location = new System.Drawing.Point(13, 58);
            this.pbxFlag.Name = "pbxFlag";
            this.pbxFlag.Size = new System.Drawing.Size(197, 139);
            this.pbxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFlag.TabIndex = 2;
            this.pbxFlag.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 214);
            this.Controls.Add(this.pbxFlag);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.cbxLanguage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxLanguage;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.PictureBox pbxFlag;
    }
}

