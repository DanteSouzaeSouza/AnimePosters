namespace AnimePosters
{
    partial class FrmAnimes
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
            this.cboAnimes = new System.Windows.Forms.ComboBox();
            this.picPoster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAnimes
            // 
            this.cboAnimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnimes.FormattingEnabled = true;
            this.cboAnimes.Location = new System.Drawing.Point(36, 22);
            this.cboAnimes.Margin = new System.Windows.Forms.Padding(2);
            this.cboAnimes.Name = "cboAnimes";
            this.cboAnimes.Size = new System.Drawing.Size(361, 21);
            this.cboAnimes.TabIndex = 0;
            this.cboAnimes.SelectedIndexChanged += new System.EventHandler(this.cboAnimes_SelectedIndexChanged);
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(36, 46);
            this.picPoster.Margin = new System.Windows.Forms.Padding(2);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(361, 490);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 1;
            this.picPoster.TabStop = false;
            // 
            // FrmAnimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 564);
            this.Controls.Add(this.picPoster);
            this.Controls.Add(this.cboAnimes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAnimes";
            this.Text = "Posters";
            this.Load += new System.EventHandler(this.FrmAnimes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAnimes;
        private System.Windows.Forms.PictureBox picPoster;
    }
}

