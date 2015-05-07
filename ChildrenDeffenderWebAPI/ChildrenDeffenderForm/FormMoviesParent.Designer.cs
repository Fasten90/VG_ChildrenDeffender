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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.Size = new System.Drawing.Size(811, 202);
            this.dataGridViewMovies.TabIndex = 0;
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(12, 220);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(75, 23);
            this.btUpload.TabIndex = 1;
            this.btUpload.Text = "Upload";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(12, 249);
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
            this.labelMovieID.Location = new System.Drawing.Point(93, 225);
            this.labelMovieID.Name = "labelMovieID";
            this.labelMovieID.Size = new System.Drawing.Size(47, 13);
            this.labelMovieID.TabIndex = 3;
            this.labelMovieID.Text = "MovieID";
            // 
            // labelMovieName
            // 
            this.labelMovieName.AutoSize = true;
            this.labelMovieName.Location = new System.Drawing.Point(197, 225);
            this.labelMovieName.Name = "labelMovieName";
            this.labelMovieName.Size = new System.Drawing.Size(64, 13);
            this.labelMovieName.TabIndex = 4;
            this.labelMovieName.Text = "MovieName";
            // 
            // textBoxMovieID
            // 
            this.textBoxMovieID.Location = new System.Drawing.Point(146, 222);
            this.textBoxMovieID.Name = "textBoxMovieID";
            this.textBoxMovieID.Size = new System.Drawing.Size(45, 20);
            this.textBoxMovieID.TabIndex = 5;
            // 
            // textBoxMovieName
            // 
            this.textBoxMovieName.Location = new System.Drawing.Point(267, 222);
            this.textBoxMovieName.Name = "textBoxMovieName";
            this.textBoxMovieName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieName.TabIndex = 6;
            // 
            // buttonIndexImageRefresh
            // 
            this.buttonIndexImageRefresh.Location = new System.Drawing.Point(13, 279);
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
            this.labelMovieIndexImagesDir.Location = new System.Drawing.Point(182, 318);
            this.labelMovieIndexImagesDir.Name = "labelMovieIndexImagesDir";
            this.labelMovieIndexImagesDir.Size = new System.Drawing.Size(113, 13);
            this.labelMovieIndexImagesDir.TabIndex = 8;
            this.labelMovieIndexImagesDir.Text = "MovieIndexImage DIR";
            // 
            // buttonMovieIndexImagesDir
            // 
            this.buttonMovieIndexImagesDir.Location = new System.Drawing.Point(13, 313);
            this.buttonMovieIndexImagesDir.Name = "buttonMovieIndexImagesDir";
            this.buttonMovieIndexImagesDir.Size = new System.Drawing.Size(163, 23);
            this.buttonMovieIndexImagesDir.TabIndex = 9;
            this.buttonMovieIndexImagesDir.Text = "Change Movie IndexImages Dir";
            this.buttonMovieIndexImagesDir.UseVisualStyleBackColor = true;
            this.buttonMovieIndexImagesDir.Click += new System.EventHandler(this.buttonMovieIndexImagesDir_Click);
            // 
            // FormMovieParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 348);
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
    }
}

