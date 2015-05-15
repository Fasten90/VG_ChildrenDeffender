namespace ChildrenDeffenderForm
{
    partial class FormMovieChildrenNetVideoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovieChildrenNetVideoPlayer));
            this.webBrowserForChildrenMovie = new System.Windows.Forms.WebBrowser();
            this.pictureBoxNetBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetBack)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowserForChildrenMovie
            // 
            this.webBrowserForChildrenMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserForChildrenMovie.Location = new System.Drawing.Point(0, 0);
            this.webBrowserForChildrenMovie.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserForChildrenMovie.Name = "webBrowserForChildrenMovie";
            this.webBrowserForChildrenMovie.Size = new System.Drawing.Size(784, 474);
            this.webBrowserForChildrenMovie.TabIndex = 0;
            this.webBrowserForChildrenMovie.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserForChildrenMovie_DocumentCompleted);
            this.webBrowserForChildrenMovie.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.webBrowserForChildrenMovie_PreviewKeyDown);
            // 
            // pictureBoxNetBack
            // 
            this.pictureBoxNetBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNetBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNetBack.Image")));
            this.pictureBoxNetBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxNetBack.InitialImage")));
            this.pictureBoxNetBack.Location = new System.Drawing.Point(752, 0);
            this.pictureBoxNetBack.Name = "pictureBoxNetBack";
            this.pictureBoxNetBack.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxNetBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNetBack.TabIndex = 1;
            this.pictureBoxNetBack.TabStop = false;
            this.pictureBoxNetBack.DoubleClick += new System.EventHandler(this.pictureBoxNetBack_DoubleClick);
            // 
            // FormMovieChildrenNetVideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 474);
            this.Controls.Add(this.pictureBoxNetBack);
            this.Controls.Add(this.webBrowserForChildrenMovie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(512, 512);
            this.Name = "FormMovieChildrenNetVideoPlayer";
            this.Text = "FormMovieChildrenNetVideoPlayer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMovieChildrenNetVideoPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserForChildrenMovie;
        private System.Windows.Forms.PictureBox pictureBoxNetBack;
    }
}