namespace ChildrenDeffenderForm
{
    partial class FormMovieChildren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovieChildren));
            this.imageListMoviesForChildren = new System.Windows.Forms.ImageList(this.components);
            this.listViewMoviesForChildren = new System.Windows.Forms.ListView();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.splitContainerChildrenMovie = new System.Windows.Forms.SplitContainer();
            this.timerFormMovieChildrenForDownload = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChildrenMovie)).BeginInit();
            this.splitContainerChildrenMovie.Panel1.SuspendLayout();
            this.splitContainerChildrenMovie.Panel2.SuspendLayout();
            this.splitContainerChildrenMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListMoviesForChildren
            // 
            this.imageListMoviesForChildren.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageListMoviesForChildren.ImageSize = new System.Drawing.Size(128, 128);
            this.imageListMoviesForChildren.TransparentColor = System.Drawing.Color.Gray;
            // 
            // listViewMoviesForChildren
            // 
            this.listViewMoviesForChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMoviesForChildren.LargeImageList = this.imageListMoviesForChildren;
            this.listViewMoviesForChildren.Location = new System.Drawing.Point(0, 0);
            this.listViewMoviesForChildren.Margin = new System.Windows.Forms.Padding(0);
            this.listViewMoviesForChildren.Name = "listViewMoviesForChildren";
            this.listViewMoviesForChildren.Size = new System.Drawing.Size(834, 166);
            this.listViewMoviesForChildren.TabIndex = 4;
            this.listViewMoviesForChildren.UseCompatibleStateImageBehavior = false;
            this.listViewMoviesForChildren.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewMoviesForChildren_MouseClick);
            this.listViewMoviesForChildren.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewMoviesForChildren_MouseDoubleClick);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBack.Image")));
            this.pictureBoxBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBack.InitialImage")));
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 3);
            this.pictureBoxBack.MaximumSize = new System.Drawing.Size(128, 128);
            this.pictureBoxBack.MinimumSize = new System.Drawing.Size(128, 128);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxBack.TabIndex = 5;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.DoubleClick += new System.EventHandler(this.pictureBoxBack_DoubleClick);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.InitialImage")));
            this.pictureBoxExit.Location = new System.Drawing.Point(143, 3);
            this.pictureBoxExit.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.pictureBoxExit.MaximumSize = new System.Drawing.Size(128, 128);
            this.pictureBoxExit.MinimumSize = new System.Drawing.Size(128, 128);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxExit.TabIndex = 6;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            this.pictureBoxExit.DoubleClick += new System.EventHandler(this.pictureBoxExit_DoubleClick);
            // 
            // splitContainerChildrenMovie
            // 
            this.splitContainerChildrenMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerChildrenMovie.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerChildrenMovie.IsSplitterFixed = true;
            this.splitContainerChildrenMovie.Location = new System.Drawing.Point(0, 0);
            this.splitContainerChildrenMovie.MinimumSize = new System.Drawing.Size(256, 256);
            this.splitContainerChildrenMovie.Name = "splitContainerChildrenMovie";
            this.splitContainerChildrenMovie.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerChildrenMovie.Panel1
            // 
            this.splitContainerChildrenMovie.Panel1.AutoScroll = true;
            this.splitContainerChildrenMovie.Panel1.AutoScrollMinSize = new System.Drawing.Size(256, 128);
            this.splitContainerChildrenMovie.Panel1.Controls.Add(this.listViewMoviesForChildren);
            this.splitContainerChildrenMovie.Panel1MinSize = 128;
            // 
            // splitContainerChildrenMovie.Panel2
            // 
            this.splitContainerChildrenMovie.Panel2.AutoScroll = true;
            this.splitContainerChildrenMovie.Panel2.AutoScrollMinSize = new System.Drawing.Size(256, 128);
            this.splitContainerChildrenMovie.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainerChildrenMovie.Panel2.Controls.Add(this.pictureBoxExit);
            this.splitContainerChildrenMovie.Panel2.Controls.Add(this.pictureBoxBack);
            this.splitContainerChildrenMovie.Panel2MinSize = 128;
            this.splitContainerChildrenMovie.Size = new System.Drawing.Size(834, 310);
            this.splitContainerChildrenMovie.SplitterDistance = 166;
            this.splitContainerChildrenMovie.SplitterWidth = 1;
            this.splitContainerChildrenMovie.TabIndex = 7;
            // 
            // timerFormMovieChildrenForDownload
            // 
            this.timerFormMovieChildrenForDownload.Enabled = true;
            this.timerFormMovieChildrenForDownload.Interval = 10000;
            this.timerFormMovieChildrenForDownload.Tick += new System.EventHandler(this.timerFormMovieChildrenForDownload_Tick);
            // 
            // FormMovieChildren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 310);
            this.Controls.Add(this.splitContainerChildrenMovie);
            this.Name = "FormMovieChildren";
            this.Text = "FormMovieChildren";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMovieChildren_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.splitContainerChildrenMovie.Panel1.ResumeLayout(false);
            this.splitContainerChildrenMovie.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChildrenMovie)).EndInit();
            this.splitContainerChildrenMovie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListMoviesForChildren;
        private System.Windows.Forms.ListView listViewMoviesForChildren;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.SplitContainer splitContainerChildrenMovie;
        private System.Windows.Forms.Timer timerFormMovieChildrenForDownload;
    }
}