namespace SaveText.UI
{
    partial class FrmSaveText
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtStory = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnSavePDF = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(13, 13);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(234, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // txtStory
            // 
            this.txtStory.Location = new System.Drawing.Point(13, 39);
            this.txtStory.Multiline = true;
            this.txtStory.Name = "txtStory";
            this.txtStory.Size = new System.Drawing.Size(234, 208);
            this.txtStory.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Opslaan txt";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(133, 263);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(114, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Openen";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.Ofd_FileOk);
            // 
            // btnSavePDF
            // 
            this.btnSavePDF.Location = new System.Drawing.Point(12, 292);
            this.btnSavePDF.Name = "btnSavePDF";
            this.btnSavePDF.Size = new System.Drawing.Size(114, 23);
            this.btnSavePDF.TabIndex = 4;
            this.btnSavePDF.Text = "Opslaan PDF";
            this.btnSavePDF.UseVisualStyleBackColor = true;
            this.btnSavePDF.Click += new System.EventHandler(this.BtnSavePDF_Click);
            // 
            // sfd
            // 
            this.sfd.Filter = "Tekstbestanden|*.txt|PDF bestanden|*.pdf";
            this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.Sfd_FileOk);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(133, 292);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(114, 23);
            this.btnSaveAs.TabIndex = 5;
            this.btnSaveAs.Text = "Opslaan als";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
            // 
            // FrmSaveText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 322);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnSavePDF);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStory);
            this.Controls.Add(this.txtTitle);
            this.Name = "FrmSaveText";
            this.Text = "Sprookjes";
            this.Load += new System.EventHandler(this.FrmSaveText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtStory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnSavePDF;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnSaveAs;
    }
}

