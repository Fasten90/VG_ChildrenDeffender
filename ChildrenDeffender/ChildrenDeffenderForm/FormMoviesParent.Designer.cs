namespace ChildrenDeffenderForm
{
    partial class FormMovieParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovieParent));
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.btUpload = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.labelMovieName = new System.Windows.Forms.Label();
            this.textBoxMovieName = new System.Windows.Forms.TextBox();
            this.buttonIndexImageRefresh = new System.Windows.Forms.Button();
            this.labelMovieIndexImagesDir = new System.Windows.Forms.Label();
            this.buttonMovieIndexImagesDir = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonReadMovieDir = new System.Windows.Forms.Button();
            this.labelMoviesDir = new System.Windows.Forms.Label();
            this.buttonMovieRefresh = new System.Windows.Forms.Button();
            this.listViewMoviesForParent = new System.Windows.Forms.ListView();
            this.imageListMoviesForParent = new System.Windows.Forms.ImageList(this.components);
            this.buttonExitParent = new System.Windows.Forms.Button();
            this.buttonAddIndexImage = new System.Windows.Forms.Button();
            this.buttonAddSound = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.buttonSoundSave = new System.Windows.Forms.Button();
            this.buttonSoundLoad = new System.Windows.Forms.Button();
            this.labelRecording = new System.Windows.Forms.Label();
            this.btMovieDelete = new System.Windows.Forms.Button();
            this.labelSelectedImage = new System.Windows.Forms.Label();
            this.notifyIconForParent = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelSelectedMovie = new System.Windows.Forms.Label();
            this.buttonPlayMovieSound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.Size = new System.Drawing.Size(824, 202);
            this.dataGridViewMovies.TabIndex = 0;
            this.dataGridViewMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_CellContentClick);
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(12, 254);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(75, 23);
            this.btUpload.TabIndex = 1;
            this.btUpload.Text = "Upload";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(12, 225);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(75, 23);
            this.btModify.TabIndex = 2;
            this.btModify.Text = "Modify";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // labelMovieName
            // 
            this.labelMovieName.AutoSize = true;
            this.labelMovieName.Location = new System.Drawing.Point(93, 259);
            this.labelMovieName.Name = "labelMovieName";
            this.labelMovieName.Size = new System.Drawing.Size(64, 13);
            this.labelMovieName.TabIndex = 4;
            this.labelMovieName.Text = "MovieName";
            // 
            // textBoxMovieName
            // 
            this.textBoxMovieName.Location = new System.Drawing.Point(163, 256);
            this.textBoxMovieName.Name = "textBoxMovieName";
            this.textBoxMovieName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieName.TabIndex = 6;
            // 
            // buttonIndexImageRefresh
            // 
            this.buttonIndexImageRefresh.Location = new System.Drawing.Point(12, 283);
            this.buttonIndexImageRefresh.Name = "buttonIndexImageRefresh";
            this.buttonIndexImageRefresh.Size = new System.Drawing.Size(127, 23);
            this.buttonIndexImageRefresh.TabIndex = 7;
            this.buttonIndexImageRefresh.Text = "IndexImages Refresh";
            this.buttonIndexImageRefresh.UseVisualStyleBackColor = true;
            this.buttonIndexImageRefresh.Click += new System.EventHandler(this.buttonIndexImageRefresh_Click);
            // 
            // labelMovieIndexImagesDir
            // 
            this.labelMovieIndexImagesDir.AutoSize = true;
            this.labelMovieIndexImagesDir.Location = new System.Drawing.Point(314, 288);
            this.labelMovieIndexImagesDir.Name = "labelMovieIndexImagesDir";
            this.labelMovieIndexImagesDir.Size = new System.Drawing.Size(112, 13);
            this.labelMovieIndexImagesDir.TabIndex = 8;
            this.labelMovieIndexImagesDir.Text = "MovieIndexImages Dir";
            // 
            // buttonMovieIndexImagesDir
            // 
            this.buttonMovieIndexImagesDir.Location = new System.Drawing.Point(145, 283);
            this.buttonMovieIndexImagesDir.Name = "buttonMovieIndexImagesDir";
            this.buttonMovieIndexImagesDir.Size = new System.Drawing.Size(163, 23);
            this.buttonMovieIndexImagesDir.TabIndex = 9;
            this.buttonMovieIndexImagesDir.Text = "Change Movie IndexImages Dir";
            this.buttonMovieIndexImagesDir.UseVisualStyleBackColor = true;
            this.buttonMovieIndexImagesDir.Click += new System.EventHandler(this.buttonMovieIndexImagesDir_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 341);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonReadMovieDir
            // 
            this.buttonReadMovieDir.Location = new System.Drawing.Point(12, 312);
            this.buttonReadMovieDir.Name = "buttonReadMovieDir";
            this.buttonReadMovieDir.Size = new System.Drawing.Size(95, 23);
            this.buttonReadMovieDir.TabIndex = 11;
            this.buttonReadMovieDir.Text = "Read Movies";
            this.buttonReadMovieDir.UseVisualStyleBackColor = true;
            this.buttonReadMovieDir.Click += new System.EventHandler(this.buttonReadMovieDir_Click);
            // 
            // labelMoviesDir
            // 
            this.labelMoviesDir.AutoSize = true;
            this.labelMoviesDir.Location = new System.Drawing.Point(113, 317);
            this.labelMoviesDir.Name = "labelMoviesDir";
            this.labelMoviesDir.Size = new System.Drawing.Size(57, 13);
            this.labelMoviesDir.TabIndex = 12;
            this.labelMoviesDir.Text = "Movies Dir";
            // 
            // buttonMovieRefresh
            // 
            this.buttonMovieRefresh.Location = new System.Drawing.Point(174, 225);
            this.buttonMovieRefresh.Name = "buttonMovieRefresh";
            this.buttonMovieRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonMovieRefresh.TabIndex = 13;
            this.buttonMovieRefresh.Text = "Refresh";
            this.buttonMovieRefresh.UseVisualStyleBackColor = true;
            this.buttonMovieRefresh.Click += new System.EventHandler(this.buttonMovieRefresh_Click);
            // 
            // listViewMoviesForParent
            // 
            this.listViewMoviesForParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMoviesForParent.LargeImageList = this.imageListMoviesForParent;
            this.listViewMoviesForParent.Location = new System.Drawing.Point(12, 373);
            this.listViewMoviesForParent.Name = "listViewMoviesForParent";
            this.listViewMoviesForParent.Size = new System.Drawing.Size(824, 93);
            this.listViewMoviesForParent.TabIndex = 14;
            this.listViewMoviesForParent.UseCompatibleStateImageBehavior = false;
            this.listViewMoviesForParent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewIndexImagesForParent_MouseClick);
            // 
            // imageListMoviesForParent
            // 
            this.imageListMoviesForParent.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageListMoviesForParent.ImageSize = new System.Drawing.Size(128, 128);
            this.imageListMoviesForParent.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonExitParent
            // 
            this.buttonExitParent.Location = new System.Drawing.Point(93, 341);
            this.buttonExitParent.Name = "buttonExitParent";
            this.buttonExitParent.Size = new System.Drawing.Size(75, 23);
            this.buttonExitParent.TabIndex = 15;
            this.buttonExitParent.Text = "Exit";
            this.buttonExitParent.UseVisualStyleBackColor = true;
            this.buttonExitParent.Click += new System.EventHandler(this.buttonExitParent_Click);
            // 
            // buttonAddIndexImage
            // 
            this.buttonAddIndexImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddIndexImage.Location = new System.Drawing.Point(454, 259);
            this.buttonAddIndexImage.Name = "buttonAddIndexImage";
            this.buttonAddIndexImage.Size = new System.Drawing.Size(75, 23);
            this.buttonAddIndexImage.TabIndex = 16;
            this.buttonAddIndexImage.Text = "Add Image";
            this.buttonAddIndexImage.UseVisualStyleBackColor = true;
            this.buttonAddIndexImage.Visible = false;
            this.buttonAddIndexImage.Click += new System.EventHandler(this.buttonAddIndexImage_Click);
            // 
            // buttonAddSound
            // 
            this.buttonAddSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddSound.Location = new System.Drawing.Point(454, 286);
            this.buttonAddSound.Name = "buttonAddSound";
            this.buttonAddSound.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSound.TabIndex = 17;
            this.buttonAddSound.Text = "Add Sound";
            this.buttonAddSound.UseVisualStyleBackColor = true;
            this.buttonAddSound.Visible = false;
            this.buttonAddSound.Click += new System.EventHandler(this.buttonAddSound_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecord.Location = new System.Drawing.Point(747, 225);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(89, 23);
            this.buttonRecord.TabIndex = 18;
            this.buttonRecord.Text = "Sound Record";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // buttonSoundSave
            // 
            this.buttonSoundSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSoundSave.Location = new System.Drawing.Point(761, 254);
            this.buttonSoundSave.Name = "buttonSoundSave";
            this.buttonSoundSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSoundSave.TabIndex = 19;
            this.buttonSoundSave.Text = "Sound Save";
            this.buttonSoundSave.UseVisualStyleBackColor = true;
            this.buttonSoundSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSoundLoad
            // 
            this.buttonSoundLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSoundLoad.Location = new System.Drawing.Point(761, 283);
            this.buttonSoundLoad.Name = "buttonSoundLoad";
            this.buttonSoundLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonSoundLoad.TabIndex = 20;
            this.buttonSoundLoad.Text = "Sound Load";
            this.buttonSoundLoad.UseVisualStyleBackColor = true;
            this.buttonSoundLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelRecording
            // 
            this.labelRecording.AutoSize = true;
            this.labelRecording.Location = new System.Drawing.Point(588, 259);
            this.labelRecording.Name = "labelRecording";
            this.labelRecording.Size = new System.Drawing.Size(65, 13);
            this.labelRecording.TabIndex = 21;
            this.labelRecording.Text = "Recording...";
            this.labelRecording.Visible = false;
            // 
            // btMovieDelete
            // 
            this.btMovieDelete.Location = new System.Drawing.Point(93, 225);
            this.btMovieDelete.Name = "btMovieDelete";
            this.btMovieDelete.Size = new System.Drawing.Size(75, 23);
            this.btMovieDelete.TabIndex = 22;
            this.btMovieDelete.Text = "Delete";
            this.btMovieDelete.UseVisualStyleBackColor = true;
            this.btMovieDelete.Click += new System.EventHandler(this.btMovieDelete_Click);
            // 
            // labelSelectedImage
            // 
            this.labelSelectedImage.AutoSize = true;
            this.labelSelectedImage.Location = new System.Drawing.Point(588, 317);
            this.labelSelectedImage.Name = "labelSelectedImage";
            this.labelSelectedImage.Size = new System.Drawing.Size(165, 13);
            this.labelSelectedImage.TabIndex = 23;
            this.labelSelectedImage.Text = "ImageIndex-MovieID-MovieName";
            this.labelSelectedImage.Visible = false;
            // 
            // notifyIconForParent
            // 
            this.notifyIconForParent.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconForParent.BalloonTipText = "ChildrenDeffender started";
            this.notifyIconForParent.BalloonTipTitle = "ChildrenDeffender";
            this.notifyIconForParent.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconForParent.Icon")));
            this.notifyIconForParent.Text = "ChildrenDeffender";
            this.notifyIconForParent.Visible = true;
            // 
            // labelSelectedMovie
            // 
            this.labelSelectedMovie.AutoSize = true;
            this.labelSelectedMovie.Location = new System.Drawing.Point(588, 230);
            this.labelSelectedMovie.Name = "labelSelectedMovie";
            this.labelSelectedMovie.Size = new System.Drawing.Size(100, 13);
            this.labelSelectedMovie.TabIndex = 24;
            this.labelSelectedMovie.Text = "labelSelectedMovie";
            // 
            // buttonPlayMovieSound
            // 
            this.buttonPlayMovieSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlayMovieSound.Location = new System.Drawing.Point(761, 312);
            this.buttonPlayMovieSound.Name = "buttonPlayMovieSound";
            this.buttonPlayMovieSound.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayMovieSound.TabIndex = 25;
            this.buttonPlayMovieSound.Text = "Play Sound";
            this.buttonPlayMovieSound.UseVisualStyleBackColor = true;
            this.buttonPlayMovieSound.Click += new System.EventHandler(this.buttonPlayMovieSound_Click);
            // 
            // FormMovieParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 478);
            this.Controls.Add(this.buttonPlayMovieSound);
            this.Controls.Add(this.labelSelectedMovie);
            this.Controls.Add(this.labelSelectedImage);
            this.Controls.Add(this.btMovieDelete);
            this.Controls.Add(this.labelRecording);
            this.Controls.Add(this.buttonSoundLoad);
            this.Controls.Add(this.buttonSoundSave);
            this.Controls.Add(this.buttonRecord);
            this.Controls.Add(this.buttonAddSound);
            this.Controls.Add(this.buttonAddIndexImage);
            this.Controls.Add(this.buttonExitParent);
            this.Controls.Add(this.listViewMoviesForParent);
            this.Controls.Add(this.buttonMovieRefresh);
            this.Controls.Add(this.labelMoviesDir);
            this.Controls.Add(this.buttonReadMovieDir);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonMovieIndexImagesDir);
            this.Controls.Add(this.labelMovieIndexImagesDir);
            this.Controls.Add(this.buttonIndexImageRefresh);
            this.Controls.Add(this.textBoxMovieName);
            this.Controls.Add(this.labelMovieName);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.dataGridViewMovies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(512, 512);
            this.Name = "FormMovieParent";
            this.Text = "ChildrenDeffender - Parent - Movie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMovieParent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Label labelMovieName;
        private System.Windows.Forms.TextBox textBoxMovieName;
        private System.Windows.Forms.Button buttonIndexImageRefresh;
        private System.Windows.Forms.Label labelMovieIndexImagesDir;
        private System.Windows.Forms.Button buttonMovieIndexImagesDir;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonReadMovieDir;
        private System.Windows.Forms.Label labelMoviesDir;
        private System.Windows.Forms.Button buttonMovieRefresh;
        private System.Windows.Forms.ListView listViewMoviesForParent;
        private System.Windows.Forms.ImageList imageListMoviesForParent;
        private System.Windows.Forms.Button buttonExitParent;
        private System.Windows.Forms.Button buttonAddIndexImage;
        private System.Windows.Forms.Button buttonAddSound;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonSoundSave;
        private System.Windows.Forms.Button buttonSoundLoad;
        private System.Windows.Forms.Label labelRecording;
        private System.Windows.Forms.Button btMovieDelete;
        private System.Windows.Forms.Label labelSelectedImage;
        public System.Windows.Forms.NotifyIcon notifyIconForParent;
        private System.Windows.Forms.Label labelSelectedMovie;
        private System.Windows.Forms.Button buttonPlayMovieSound;
    }
}

