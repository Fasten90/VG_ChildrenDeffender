namespace ChildrenDeffenderForm
{
    partial class FormMoviePlayer
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
            this.panelVideo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelVideo
            // 
            this.panelVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVideo.Location = new System.Drawing.Point(0, 0);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(815, 351);
            this.panelVideo.TabIndex = 0;
            this.panelVideo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panelVideo_PreviewKeyDown);
            // 
            // FormMoviePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 351);
            this.Controls.Add(this.panelVideo);
            this.Name = "FormMoviePlayer";
            this.Text = "FormMoviePlayer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMoviePlayer_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVideo;
    }
}