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
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.btUpload = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.labelMovieID = new System.Windows.Forms.Label();
            this.labelMovieName = new System.Windows.Forms.Label();
            this.textBoxMovieID = new System.Windows.Forms.TextBox();
            this.textBoxMovieName = new System.Windows.Forms.TextBox();
            this.buttonIndexImageRefresh = new System.Windows.Forms.Button();
            this.labelMovieIndexImagesDir = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonMovieIndexImagesDir = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonReadMovieDir = new System.Windows.Forms.Button();
            this.labelMoviesDir = new System.Windows.Forms.Label();
            this.buttonMovieRefresh = new System.Windows.Forms.Button();
            this.listViewIndexImagesForParent = new System.Windows.Forms.ListView();
            this.imageListIndexImagesForParent = new System.Windows.Forms.ImageList(this.components);
            this.buttonExitParent = new System.Windows.Forms.Button();
            this.buttonAddIndexImage = new System.Windows.Forms.Button();
            this.buttonAddSound = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.buttonSoundSave = new System.Windows.Forms.Button();
            this.buttonSoundLoad = new System.Windows.Forms.Button();
            this.labelRecording = new System.Windows.Forms.Label();
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
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(12, 225);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(75, 23);
            this.btUpload.TabIndex = 1;
            this.btUpload.Text = "Upload";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(12, 254);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(75, 23);
            this.btModify.TabIndex = 2;
            this.btModify.Text = "Modify";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // labelMovieID
            // 
            this.labelMovieID.AutoSize = true;
            this.labelMovieID.Location = new System.Drawing.Point(93, 230);
            this.labelMovieID.Name = "labelMovieID";
            this.labelMovieID.Size = new System.Drawing.Size(47, 13);
            this.labelMovieID.TabIndex = 3;
            this.labelMovieID.Text = "MovieID";
            // 
            // labelMovieName
            // 
            this.labelMovieName.AutoSize = true;
            this.labelMovieName.Location = new System.Drawing.Point(197, 230);
            this.labelMovieName.Name = "labelMovieName";
            this.labelMovieName.Size = new System.Drawing.Size(64, 13);
            this.labelMovieName.TabIndex = 4;
            this.labelMovieName.Text = "MovieName";
            // 
            // textBoxMovieID
            // 
            this.textBoxMovieID.Location = new System.Drawing.Point(146, 227);
            this.textBoxMovieID.Name = "textBoxMovieID";
            this.textBoxMovieID.Size = new System.Drawing.Size(45, 20);
            this.textBoxMovieID.TabIndex = 5;
            // 
            // textBoxMovieName
            // 
            this.textBoxMovieName.Location = new System.Drawing.Point(267, 228);
            this.textBoxMovieName.Name = "textBoxMovieName";
            this.textBoxMovieName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieName.TabIndex = 6;
            // 
            // buttonIndexImageRefresh
            // 
            this.buttonIndexImageRefresh.Location = new System.Drawing.Point(12, 286);
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
            this.labelMovieIndexImagesDir.Location = new System.Drawing.Point(314, 291);
            this.labelMovieIndexImagesDir.Name = "labelMovieIndexImagesDir";
            this.labelMovieIndexImagesDir.Size = new System.Drawing.Size(112, 13);
            this.labelMovieIndexImagesDir.TabIndex = 8;
            this.labelMovieIndexImagesDir.Text = "MovieIndexImages Dir";
            // 
            // buttonMovieIndexImagesDir
            // 
            this.buttonMovieIndexImagesDir.Location = new System.Drawing.Point(145, 286);
            this.buttonMovieIndexImagesDir.Name = "buttonMovieIndexImagesDir";
            this.buttonMovieIndexImagesDir.Size = new System.Drawing.Size(163, 23);
            this.buttonMovieIndexImagesDir.TabIndex = 9;
            this.buttonMovieIndexImagesDir.Text = "Change Movie IndexImages Dir";
            this.buttonMovieIndexImagesDir.UseVisualStyleBackColor = true;
            this.buttonMovieIndexImagesDir.Click += new System.EventHandler(this.buttonMovieIndexImagesDir_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 344);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonReadMovieDir
            // 
            this.buttonReadMovieDir.Location = new System.Drawing.Point(12, 315);
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
            this.labelMoviesDir.Location = new System.Drawing.Point(113, 320);
            this.labelMoviesDir.Name = "labelMoviesDir";
            this.labelMoviesDir.Size = new System.Drawing.Size(57, 13);
            this.labelMoviesDir.TabIndex = 12;
            this.labelMoviesDir.Text = "Movies Dir";
            // 
            // buttonMovieRefresh
            // 
            this.buttonMovieRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMovieRefresh.Location = new System.Drawing.Point(761, 225);
            this.buttonMovieRefresh.Name = "buttonMovieRefresh";
            this.buttonMovieRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonMovieRefresh.TabIndex = 13;
            this.buttonMovieRefresh.Text = "Refresh";
            this.buttonMovieRefresh.UseVisualStyleBackColor = true;
            this.buttonMovieRefresh.Click += new System.EventHandler(this.buttonMovieRefresh_Click);
            // 
            // listViewIndexImagesForParent
            // 
            this.listViewIndexImagesForParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewIndexImagesForParent.LargeImageList = this.imageListIndexImagesForParent;
            this.listViewIndexImagesForParent.Location = new System.Drawing.Point(12, 373);
            this.listViewIndexImagesForParent.Name = "listViewIndexImagesForParent";
            this.listViewIndexImagesForParent.Size = new System.Drawing.Size(824, 93);
            this.listViewIndexImagesForParent.TabIndex = 14;
            this.listViewIndexImagesForParent.UseCompatibleStateImageBehavior = false;
            // 
            // imageListIndexImagesForParent
            // 
            this.imageListIndexImagesForParent.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageListIndexImagesForParent.ImageSize = new System.Drawing.Size(128, 128);
            this.imageListIndexImagesForParent.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonExitParent
            // 
            this.buttonExitParent.Location = new System.Drawing.Point(93, 344);
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
            this.buttonAddIndexImage.Location = new System.Drawing.Point(761, 341);
            this.buttonAddIndexImage.Name = "buttonAddIndexImage";
            this.buttonAddIndexImage.Size = new System.Drawing.Size(75, 23);
            this.buttonAddIndexImage.TabIndex = 16;
            this.buttonAddIndexImage.Text = "Add Image";
            this.buttonAddIndexImage.UseVisualStyleBackColor = true;
            this.buttonAddIndexImage.Click += new System.EventHandler(this.buttonAddIndexImage_Click);
            // 
            // buttonAddSound
            // 
            this.buttonAddSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddSound.Location = new System.Drawing.Point(761, 370);
            this.buttonAddSound.Name = "buttonAddSound";
            this.buttonAddSound.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSound.TabIndex = 17;
            this.buttonAddSound.Text = "Add Sound";
            this.buttonAddSound.UseVisualStyleBackColor = true;
            this.buttonAddSound.Click += new System.EventHandler(this.buttonAddSound_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecord.Location = new System.Drawing.Point(747, 254);
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
            this.buttonSoundSave.Location = new System.Drawing.Point(761, 283);
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
            this.buttonSoundLoad.Location = new System.Drawing.Point(761, 312);
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
            this.labelRecording.Location = new System.Drawing.Point(676, 259);
            this.labelRecording.Name = "labelRecording";
            this.labelRecording.Size = new System.Drawing.Size(65, 13);
            this.labelRecording.TabIndex = 21;
            this.labelRecording.Text = "Recording...";
            this.labelRecording.Visible = false;
            // 
            // FormMovieParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 478);
            this.Controls.Add(this.labelRecording);
            this.Controls.Add(this.buttonSoundLoad);
            this.Controls.Add(this.buttonSoundSave);
            this.Controls.Add(this.buttonRecord);
            this.Controls.Add(this.buttonAddSound);
            this.Controls.Add(this.buttonAddIndexImage);
            this.Controls.Add(this.buttonExitParent);
            this.Controls.Add(this.listViewIndexImagesForParent);
            this.Controls.Add(this.buttonMovieRefresh);
            this.Controls.Add(this.labelMoviesDir);
            this.Controls.Add(this.buttonReadMovieDir);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonMovieIndexImagesDir);
            this.Controls.Add(this.labelMovieIndexImagesDir);
            this.Controls.Add(this.buttonIndexImageRefresh);
            this.Controls.Add(this.textBoxMovieName);
            this.Controls.Add(this.textBoxMovieID);
            this.Controls.Add(this.labelMovieName);
            this.Controls.Add(this.labelMovieID);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.dataGridViewMovies);
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
        private System.Windows.Forms.Label labelMovieID;
        private System.Windows.Forms.Label labelMovieName;
        private System.Windows.Forms.TextBox textBoxMovieID;
        private System.Windows.Forms.TextBox textBoxMovieName;
        private System.Windows.Forms.Button buttonIndexImageRefresh;
        private System.Windows.Forms.Label labelMovieIndexImagesDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonMovieIndexImagesDir;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonReadMovieDir;
        private System.Windows.Forms.Label labelMoviesDir;
        private System.Windows.Forms.Button buttonMovieRefresh;
        private System.Windows.Forms.ListView listViewIndexImagesForParent;
        private System.Windows.Forms.ImageList imageListIndexImagesForParent;
        private System.Windows.Forms.Button buttonExitParent;
        private System.Windows.Forms.Button buttonAddIndexImage;
        private System.Windows.Forms.Button buttonAddSound;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonSoundSave;
        private System.Windows.Forms.Button buttonSoundLoad;
        private System.Windows.Forms.Label labelRecording;
    }
}

