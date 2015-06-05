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
            this.btModify = new System.Windows.Forms.Button();
            this.buttonIndexImageRefresh = new System.Windows.Forms.Button();
            this.labelMovieIndexImagesDir = new System.Windows.Forms.Label();
            this.buttonMovieIndexImagesDir = new System.Windows.Forms.Button();
            this.buttonReadMovieDir = new System.Windows.Forms.Button();
            this.labelMoviesDir = new System.Windows.Forms.Label();
            this.imageListMoviesForParent = new System.Windows.Forms.ImageList(this.components);
            this.buttonAddIndexImage = new System.Windows.Forms.Button();
            this.buttonAddSound = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.buttonSoundSave = new System.Windows.Forms.Button();
            this.buttonSoundLoad = new System.Windows.Forms.Button();
            this.labelRecording = new System.Windows.Forms.Label();
            this.btMovieDelete = new System.Windows.Forms.Button();
            this.notifyIconForParent = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonPlayMovieSound = new System.Windows.Forms.Button();
            this.tabControlMovieParent = new System.Windows.Forms.TabControl();
            this.tabPageMovieModify = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxMovieModifyMovieName = new System.Windows.Forms.TextBox();
            this.labelMovieNameText = new System.Windows.Forms.Label();
            this.labelMovieNameEnglishText = new System.Windows.Forms.Label();
            this.textBoxMovieModifyMovieID = new System.Windows.Forms.TextBox();
            this.textBoxMovieModifyMovieNameEnglish = new System.Windows.Forms.TextBox();
            this.labelMovieIDText = new System.Windows.Forms.Label();
            this.tabPageMovieUpload = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMovieUploadMovieLinkType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMovieUploadMovieName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxMovieUploadMovieNameEnglish = new System.Windows.Forms.TextBox();
            this.labelMovieUploadMovieLink = new System.Windows.Forms.Label();
            this.textBoxMovieUploadMovieLink = new System.Windows.Forms.TextBox();
            this.textBoxMovieUploadLinkType = new System.Windows.Forms.TextBox();
            this.btUpload = new System.Windows.Forms.Button();
            this.tabPageMovieImage = new System.Windows.Forms.TabPage();
            this.labelSelectedImage = new System.Windows.Forms.Label();
            this.listViewMoviesForParent = new System.Windows.Forms.ListView();
            this.tabPageMovieSound = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxMovieSoundMovieName = new System.Windows.Forms.TextBox();
            this.labelMovieSoundMovieNameText = new System.Windows.Forms.Label();
            this.labelMovieSoundMovieNameEnglish = new System.Windows.Forms.Label();
            this.textBoxMovieSoundMovieID = new System.Windows.Forms.TextBox();
            this.textBoxMovieSoundMovieNameEnglish = new System.Windows.Forms.TextBox();
            this.labelMovieSoundMovidIDText = new System.Windows.Forms.Label();
            this.buttonRecordImage = new System.Windows.Forms.Button();
            this.buttonExitParent = new System.Windows.Forms.Button();
            this.buttonMovieRefresh = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.tabControlMovieParent.SuspendLayout();
            this.tabPageMovieModify.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageMovieUpload.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageMovieImage.SuspendLayout();
            this.tabPageMovieSound.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.Size = new System.Drawing.Size(736, 202);
            this.dataGridViewMovies.TabIndex = 0;
            this.dataGridViewMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_CellClick);
            this.dataGridViewMovies.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_CellValueChanged);
            this.dataGridViewMovies.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_RowLeave);
            this.dataGridViewMovies.SelectionChanged += new System.EventHandler(this.dataGridViewMovies_SelectionChanged);
            // 
            // btModify
            // 
            this.btModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btModify.Location = new System.Drawing.Point(735, 6);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(75, 23);
            this.btModify.TabIndex = 2;
            this.btModify.Text = "Modify";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // buttonIndexImageRefresh
            // 
            this.buttonIndexImageRefresh.Location = new System.Drawing.Point(647, 6);
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
            this.labelMovieIndexImagesDir.Location = new System.Drawing.Point(647, 61);
            this.labelMovieIndexImagesDir.Name = "labelMovieIndexImagesDir";
            this.labelMovieIndexImagesDir.Size = new System.Drawing.Size(112, 13);
            this.labelMovieIndexImagesDir.TabIndex = 8;
            this.labelMovieIndexImagesDir.Text = "MovieIndexImages Dir";
            // 
            // buttonMovieIndexImagesDir
            // 
            this.buttonMovieIndexImagesDir.Location = new System.Drawing.Point(647, 35);
            this.buttonMovieIndexImagesDir.Name = "buttonMovieIndexImagesDir";
            this.buttonMovieIndexImagesDir.Size = new System.Drawing.Size(163, 23);
            this.buttonMovieIndexImagesDir.TabIndex = 9;
            this.buttonMovieIndexImagesDir.Text = "Change Movie IndexImages Dir";
            this.buttonMovieIndexImagesDir.UseVisualStyleBackColor = true;
            this.buttonMovieIndexImagesDir.Click += new System.EventHandler(this.buttonMovieIndexImagesDir_Click);
            // 
            // buttonReadMovieDir
            // 
            this.buttonReadMovieDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReadMovieDir.Location = new System.Drawing.Point(715, 11);
            this.buttonReadMovieDir.Name = "buttonReadMovieDir";
            this.buttonReadMovieDir.Size = new System.Drawing.Size(95, 23);
            this.buttonReadMovieDir.TabIndex = 11;
            this.buttonReadMovieDir.Text = "Read Movies";
            this.buttonReadMovieDir.UseVisualStyleBackColor = true;
            this.buttonReadMovieDir.Click += new System.EventHandler(this.buttonReadMovieDir_Click);
            // 
            // labelMoviesDir
            // 
            this.labelMoviesDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMoviesDir.AutoSize = true;
            this.labelMoviesDir.Location = new System.Drawing.Point(712, 37);
            this.labelMoviesDir.Name = "labelMoviesDir";
            this.labelMoviesDir.Size = new System.Drawing.Size(57, 13);
            this.labelMoviesDir.TabIndex = 12;
            this.labelMoviesDir.Text = "Movies Dir";
            this.labelMoviesDir.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // imageListMoviesForParent
            // 
            this.imageListMoviesForParent.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageListMoviesForParent.ImageSize = new System.Drawing.Size(128, 128);
            this.imageListMoviesForParent.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonAddIndexImage
            // 
            this.buttonAddIndexImage.Location = new System.Drawing.Point(647, 179);
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
            this.buttonAddSound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAddSound.Location = new System.Drawing.Point(311, 130);
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
            this.buttonRecord.Location = new System.Drawing.Point(6, 6);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(89, 23);
            this.buttonRecord.TabIndex = 18;
            this.buttonRecord.Text = "Sound Record";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // buttonSoundSave
            // 
            this.buttonSoundSave.Location = new System.Drawing.Point(6, 35);
            this.buttonSoundSave.Name = "buttonSoundSave";
            this.buttonSoundSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSoundSave.TabIndex = 19;
            this.buttonSoundSave.Text = "Sound Save";
            this.buttonSoundSave.UseVisualStyleBackColor = true;
            this.buttonSoundSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSoundLoad
            // 
            this.buttonSoundLoad.Location = new System.Drawing.Point(6, 64);
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
            this.labelRecording.Location = new System.Drawing.Point(132, 11);
            this.labelRecording.Name = "labelRecording";
            this.labelRecording.Size = new System.Drawing.Size(65, 13);
            this.labelRecording.TabIndex = 21;
            this.labelRecording.Text = "Recording...";
            this.labelRecording.Visible = false;
            // 
            // btMovieDelete
            // 
            this.btMovieDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMovieDelete.Location = new System.Drawing.Point(735, 35);
            this.btMovieDelete.Name = "btMovieDelete";
            this.btMovieDelete.Size = new System.Drawing.Size(75, 23);
            this.btMovieDelete.TabIndex = 22;
            this.btMovieDelete.Text = "Delete";
            this.btMovieDelete.UseVisualStyleBackColor = true;
            this.btMovieDelete.Click += new System.EventHandler(this.btMovieDelete_Click);
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
            // buttonPlayMovieSound
            // 
            this.buttonPlayMovieSound.Location = new System.Drawing.Point(6, 93);
            this.buttonPlayMovieSound.Name = "buttonPlayMovieSound";
            this.buttonPlayMovieSound.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayMovieSound.TabIndex = 25;
            this.buttonPlayMovieSound.Text = "Play Sound";
            this.buttonPlayMovieSound.UseVisualStyleBackColor = true;
            this.buttonPlayMovieSound.Click += new System.EventHandler(this.buttonPlayMovieSound_Click);
            // 
            // tabControlMovieParent
            // 
            this.tabControlMovieParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMovieParent.Controls.Add(this.tabPageMovieModify);
            this.tabControlMovieParent.Controls.Add(this.tabPageMovieUpload);
            this.tabControlMovieParent.Controls.Add(this.tabPageMovieImage);
            this.tabControlMovieParent.Controls.Add(this.tabPageMovieSound);
            this.tabControlMovieParent.Location = new System.Drawing.Point(12, 220);
            this.tabControlMovieParent.Name = "tabControlMovieParent";
            this.tabControlMovieParent.SelectedIndex = 0;
            this.tabControlMovieParent.Size = new System.Drawing.Size(824, 274);
            this.tabControlMovieParent.TabIndex = 26;
            // 
            // tabPageMovieModify
            // 
            this.tabPageMovieModify.Controls.Add(this.tableLayoutPanel1);
            this.tabPageMovieModify.Controls.Add(this.btModify);
            this.tabPageMovieModify.Controls.Add(this.btMovieDelete);
            this.tabPageMovieModify.Location = new System.Drawing.Point(4, 22);
            this.tabPageMovieModify.Name = "tabPageMovieModify";
            this.tabPageMovieModify.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovieModify.Size = new System.Drawing.Size(816, 248);
            this.tabPageMovieModify.TabIndex = 0;
            this.tabPageMovieModify.Text = "Movie modify";
            this.tabPageMovieModify.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.14829F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.85171F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxMovieModifyMovieName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelMovieNameText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelMovieNameEnglishText, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMovieModifyMovieID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMovieModifyMovieNameEnglish, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelMovieIDText, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.16279F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.83721F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(263, 162);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // textBoxMovieModifyMovieName
            // 
            this.textBoxMovieModifyMovieName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMovieModifyMovieName.Location = new System.Drawing.Point(143, 67);
            this.textBoxMovieModifyMovieName.Name = "textBoxMovieModifyMovieName";
            this.textBoxMovieModifyMovieName.ReadOnly = true;
            this.textBoxMovieModifyMovieName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieModifyMovieName.TabIndex = 30;
            // 
            // labelMovieNameText
            // 
            this.labelMovieNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMovieNameText.AutoSize = true;
            this.labelMovieNameText.Location = new System.Drawing.Point(46, 52);
            this.labelMovieNameText.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.labelMovieNameText.Name = "labelMovieNameText";
            this.labelMovieNameText.Size = new System.Drawing.Size(67, 50);
            this.labelMovieNameText.TabIndex = 27;
            this.labelMovieNameText.Text = "Movie Name";
            this.labelMovieNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMovieNameEnglishText
            // 
            this.labelMovieNameEnglishText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMovieNameEnglishText.AutoSize = true;
            this.labelMovieNameEnglishText.Location = new System.Drawing.Point(9, 102);
            this.labelMovieNameEnglishText.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.labelMovieNameEnglishText.Name = "labelMovieNameEnglishText";
            this.labelMovieNameEnglishText.Size = new System.Drawing.Size(104, 60);
            this.labelMovieNameEnglishText.TabIndex = 28;
            this.labelMovieNameEnglishText.Text = "Movie Name English";
            this.labelMovieNameEnglishText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMovieModifyMovieID
            // 
            this.textBoxMovieModifyMovieID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMovieModifyMovieID.Location = new System.Drawing.Point(143, 16);
            this.textBoxMovieModifyMovieID.Name = "textBoxMovieModifyMovieID";
            this.textBoxMovieModifyMovieID.ReadOnly = true;
            this.textBoxMovieModifyMovieID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieModifyMovieID.TabIndex = 29;
            // 
            // textBoxMovieModifyMovieNameEnglish
            // 
            this.textBoxMovieModifyMovieNameEnglish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMovieModifyMovieNameEnglish.Location = new System.Drawing.Point(143, 122);
            this.textBoxMovieModifyMovieNameEnglish.Name = "textBoxMovieModifyMovieNameEnglish";
            this.textBoxMovieModifyMovieNameEnglish.ReadOnly = true;
            this.textBoxMovieModifyMovieNameEnglish.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieModifyMovieNameEnglish.TabIndex = 31;
            // 
            // labelMovieIDText
            // 
            this.labelMovieIDText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMovieIDText.AutoSize = true;
            this.labelMovieIDText.Location = new System.Drawing.Point(66, 0);
            this.labelMovieIDText.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.labelMovieIDText.Name = "labelMovieIDText";
            this.labelMovieIDText.Size = new System.Drawing.Size(47, 52);
            this.labelMovieIDText.TabIndex = 25;
            this.labelMovieIDText.Text = "MovieID";
            this.labelMovieIDText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageMovieUpload
            // 
            this.tabPageMovieUpload.Controls.Add(this.tableLayoutPanel2);
            this.tabPageMovieUpload.Controls.Add(this.btUpload);
            this.tabPageMovieUpload.Controls.Add(this.buttonReadMovieDir);
            this.tabPageMovieUpload.Controls.Add(this.labelMoviesDir);
            this.tabPageMovieUpload.Location = new System.Drawing.Point(4, 22);
            this.tabPageMovieUpload.Name = "tabPageMovieUpload";
            this.tabPageMovieUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovieUpload.Size = new System.Drawing.Size(816, 248);
            this.tabPageMovieUpload.TabIndex = 1;
            this.tabPageMovieUpload.Text = "Movie upload";
            this.tabPageMovieUpload.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.14829F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.85171F));
            this.tableLayoutPanel2.Controls.Add(this.labelMovieUploadMovieLinkType, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMovieUploadMovieName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMovieUploadMovieNameEnglish, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelMovieUploadMovieLink, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMovieUploadMovieLink, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMovieUploadLinkType, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 11);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.28358F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.71642F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(263, 201);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // labelMovieUploadMovieLinkType
            // 
            this.labelMovieUploadMovieLinkType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMovieUploadMovieLinkType.AutoSize = true;
            this.labelMovieUploadMovieLinkType.Location = new System.Drawing.Point(18, 174);
            this.labelMovieUploadMovieLinkType.Name = "labelMovieUploadMovieLinkType";
            this.labelMovieUploadMovieLinkType.Size = new System.Drawing.Size(86, 13);
            this.labelMovieUploadMovieLinkType.TabIndex = 33;
            this.labelMovieUploadMovieLinkType.Text = "Movie Link Type";
            this.labelMovieUploadMovieLinkType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "MovieID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMovieUploadMovieName
            // 
            this.textBoxMovieUploadMovieName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMovieUploadMovieName.Location = new System.Drawing.Point(143, 56);
            this.textBoxMovieUploadMovieName.Name = "textBoxMovieUploadMovieName";
            this.textBoxMovieUploadMovieName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieUploadMovieName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Movie Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Movie Name English";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(143, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 29;
            // 
            // textBoxMovieUploadMovieNameEnglish
            // 
            this.textBoxMovieUploadMovieNameEnglish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMovieUploadMovieNameEnglish.Location = new System.Drawing.Point(143, 99);
            this.textBoxMovieUploadMovieNameEnglish.Name = "textBoxMovieUploadMovieNameEnglish";
            this.textBoxMovieUploadMovieNameEnglish.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieUploadMovieNameEnglish.TabIndex = 31;
            // 
            // labelMovieUploadMovieLink
            // 
            this.labelMovieUploadMovieLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMovieUploadMovieLink.AutoSize = true;
            this.labelMovieUploadMovieLink.Location = new System.Drawing.Point(32, 136);
            this.labelMovieUploadMovieLink.Name = "labelMovieUploadMovieLink";
            this.labelMovieUploadMovieLink.Size = new System.Drawing.Size(59, 13);
            this.labelMovieUploadMovieLink.TabIndex = 32;
            this.labelMovieUploadMovieLink.Text = "Movie Link";
            this.labelMovieUploadMovieLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMovieUploadMovieLink
            // 
            this.textBoxMovieUploadMovieLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMovieUploadMovieLink.Location = new System.Drawing.Point(143, 133);
            this.textBoxMovieUploadMovieLink.Name = "textBoxMovieUploadMovieLink";
            this.textBoxMovieUploadMovieLink.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieUploadMovieLink.TabIndex = 34;
            // 
            // textBoxMovieUploadLinkType
            // 
            this.textBoxMovieUploadLinkType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMovieUploadLinkType.Location = new System.Drawing.Point(143, 170);
            this.textBoxMovieUploadLinkType.Name = "textBoxMovieUploadLinkType";
            this.textBoxMovieUploadLinkType.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieUploadLinkType.TabIndex = 35;
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(275, 11);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(75, 23);
            this.btUpload.TabIndex = 2;
            this.btUpload.Text = "Upload";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // tabPageMovieImage
            // 
            this.tabPageMovieImage.Controls.Add(this.labelSelectedImage);
            this.tabPageMovieImage.Controls.Add(this.listViewMoviesForParent);
            this.tabPageMovieImage.Controls.Add(this.buttonIndexImageRefresh);
            this.tabPageMovieImage.Controls.Add(this.buttonMovieIndexImagesDir);
            this.tabPageMovieImage.Controls.Add(this.labelMovieIndexImagesDir);
            this.tabPageMovieImage.Controls.Add(this.buttonAddIndexImage);
            this.tabPageMovieImage.Location = new System.Drawing.Point(4, 22);
            this.tabPageMovieImage.Name = "tabPageMovieImage";
            this.tabPageMovieImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovieImage.Size = new System.Drawing.Size(816, 248);
            this.tabPageMovieImage.TabIndex = 2;
            this.tabPageMovieImage.Text = "Movie image";
            this.tabPageMovieImage.UseVisualStyleBackColor = true;
            // 
            // labelSelectedImage
            // 
            this.labelSelectedImage.AutoSize = true;
            this.labelSelectedImage.Location = new System.Drawing.Point(644, 87);
            this.labelSelectedImage.Name = "labelSelectedImage";
            this.labelSelectedImage.Size = new System.Drawing.Size(165, 13);
            this.labelSelectedImage.TabIndex = 24;
            this.labelSelectedImage.Text = "ImageIndex-MovieID-MovieName";
            this.labelSelectedImage.Visible = false;
            // 
            // listViewMoviesForParent
            // 
            this.listViewMoviesForParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMoviesForParent.LargeImageList = this.imageListMoviesForParent;
            this.listViewMoviesForParent.Location = new System.Drawing.Point(6, 6);
            this.listViewMoviesForParent.Name = "listViewMoviesForParent";
            this.listViewMoviesForParent.Size = new System.Drawing.Size(635, 223);
            this.listViewMoviesForParent.TabIndex = 17;
            this.listViewMoviesForParent.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageMovieSound
            // 
            this.tabPageMovieSound.Controls.Add(this.tableLayoutPanel3);
            this.tabPageMovieSound.Controls.Add(this.buttonRecordImage);
            this.tabPageMovieSound.Controls.Add(this.buttonAddSound);
            this.tabPageMovieSound.Controls.Add(this.buttonPlayMovieSound);
            this.tabPageMovieSound.Controls.Add(this.buttonRecord);
            this.tabPageMovieSound.Controls.Add(this.labelRecording);
            this.tabPageMovieSound.Controls.Add(this.buttonSoundSave);
            this.tabPageMovieSound.Controls.Add(this.buttonSoundLoad);
            this.tabPageMovieSound.Location = new System.Drawing.Point(4, 22);
            this.tabPageMovieSound.Name = "tabPageMovieSound";
            this.tabPageMovieSound.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovieSound.Size = new System.Drawing.Size(816, 248);
            this.tabPageMovieSound.TabIndex = 3;
            this.tabPageMovieSound.Text = "Movie sound";
            this.tabPageMovieSound.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.14829F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.85171F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxMovieSoundMovieName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelMovieSoundMovieNameText, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelMovieSoundMovieNameEnglish, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxMovieSoundMovieID, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxMovieSoundMovieNameEnglish, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelMovieSoundMovidIDText, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(547, 11);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.16279F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.83721F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(263, 162);
            this.tableLayoutPanel3.TabIndex = 27;
            // 
            // textBoxMovieSoundMovieName
            // 
            this.textBoxMovieSoundMovieName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMovieSoundMovieName.Location = new System.Drawing.Point(143, 67);
            this.textBoxMovieSoundMovieName.Name = "textBoxMovieSoundMovieName";
            this.textBoxMovieSoundMovieName.ReadOnly = true;
            this.textBoxMovieSoundMovieName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieSoundMovieName.TabIndex = 30;
            // 
            // labelMovieSoundMovieNameText
            // 
            this.labelMovieSoundMovieNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMovieSoundMovieNameText.AutoSize = true;
            this.labelMovieSoundMovieNameText.Location = new System.Drawing.Point(46, 52);
            this.labelMovieSoundMovieNameText.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.labelMovieSoundMovieNameText.Name = "labelMovieSoundMovieNameText";
            this.labelMovieSoundMovieNameText.Size = new System.Drawing.Size(67, 50);
            this.labelMovieSoundMovieNameText.TabIndex = 27;
            this.labelMovieSoundMovieNameText.Text = "Movie Name";
            this.labelMovieSoundMovieNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMovieSoundMovieNameEnglish
            // 
            this.labelMovieSoundMovieNameEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMovieSoundMovieNameEnglish.AutoSize = true;
            this.labelMovieSoundMovieNameEnglish.Location = new System.Drawing.Point(9, 102);
            this.labelMovieSoundMovieNameEnglish.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.labelMovieSoundMovieNameEnglish.Name = "labelMovieSoundMovieNameEnglish";
            this.labelMovieSoundMovieNameEnglish.Size = new System.Drawing.Size(104, 60);
            this.labelMovieSoundMovieNameEnglish.TabIndex = 28;
            this.labelMovieSoundMovieNameEnglish.Text = "Movie Name English";
            this.labelMovieSoundMovieNameEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMovieSoundMovieID
            // 
            this.textBoxMovieSoundMovieID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMovieSoundMovieID.Location = new System.Drawing.Point(143, 16);
            this.textBoxMovieSoundMovieID.Name = "textBoxMovieSoundMovieID";
            this.textBoxMovieSoundMovieID.ReadOnly = true;
            this.textBoxMovieSoundMovieID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieSoundMovieID.TabIndex = 29;
            // 
            // textBoxMovieSoundMovieNameEnglish
            // 
            this.textBoxMovieSoundMovieNameEnglish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMovieSoundMovieNameEnglish.Location = new System.Drawing.Point(143, 122);
            this.textBoxMovieSoundMovieNameEnglish.Name = "textBoxMovieSoundMovieNameEnglish";
            this.textBoxMovieSoundMovieNameEnglish.ReadOnly = true;
            this.textBoxMovieSoundMovieNameEnglish.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieSoundMovieNameEnglish.TabIndex = 31;
            // 
            // labelMovieSoundMovidIDText
            // 
            this.labelMovieSoundMovidIDText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMovieSoundMovidIDText.AutoSize = true;
            this.labelMovieSoundMovidIDText.Location = new System.Drawing.Point(66, 0);
            this.labelMovieSoundMovidIDText.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.labelMovieSoundMovidIDText.Name = "labelMovieSoundMovidIDText";
            this.labelMovieSoundMovidIDText.Size = new System.Drawing.Size(47, 52);
            this.labelMovieSoundMovidIDText.TabIndex = 25;
            this.labelMovieSoundMovidIDText.Text = "MovieID";
            this.labelMovieSoundMovidIDText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonRecordImage
            // 
            this.buttonRecordImage.BackgroundImage = global::ChildrenDeffenderForm.Properties.Resources.Record;
            this.buttonRecordImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRecordImage.Location = new System.Drawing.Point(135, 35);
            this.buttonRecordImage.Name = "buttonRecordImage";
            this.buttonRecordImage.Size = new System.Drawing.Size(64, 64);
            this.buttonRecordImage.TabIndex = 26;
            this.buttonRecordImage.Text = "Record...";
            this.buttonRecordImage.UseVisualStyleBackColor = true;
            this.buttonRecordImage.Visible = false;
            this.buttonRecordImage.Click += new System.EventHandler(this.buttonRecordImage_Click);
            // 
            // buttonExitParent
            // 
            this.buttonExitParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExitParent.BackgroundImage = global::ChildrenDeffenderForm.Properties.Resources.Exit;
            this.buttonExitParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExitParent.Location = new System.Drawing.Point(772, 150);
            this.buttonExitParent.Name = "buttonExitParent";
            this.buttonExitParent.Size = new System.Drawing.Size(64, 64);
            this.buttonExitParent.TabIndex = 15;
            this.buttonExitParent.Text = "Exit";
            this.buttonExitParent.UseVisualStyleBackColor = true;
            this.buttonExitParent.Click += new System.EventHandler(this.buttonExitParent_Click);
            // 
            // buttonMovieRefresh
            // 
            this.buttonMovieRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMovieRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMovieRefresh.BackgroundImage")));
            this.buttonMovieRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMovieRefresh.Location = new System.Drawing.Point(772, 12);
            this.buttonMovieRefresh.Name = "buttonMovieRefresh";
            this.buttonMovieRefresh.Size = new System.Drawing.Size(64, 64);
            this.buttonMovieRefresh.TabIndex = 13;
            this.buttonMovieRefresh.Text = "Refresh";
            this.buttonMovieRefresh.UseVisualStyleBackColor = true;
            this.buttonMovieRefresh.Click += new System.EventHandler(this.buttonMovieRefresh_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.Location = new System.Drawing.Point(772, 82);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(64, 64);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormMovieParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 506);
            this.Controls.Add(this.tabControlMovieParent);
            this.Controls.Add(this.buttonExitParent);
            this.Controls.Add(this.buttonMovieRefresh);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewMovies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(512, 512);
            this.Name = "FormMovieParent";
            this.Text = "ChildrenDeffender - Parent - Movie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMovieParent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.tabControlMovieParent.ResumeLayout(false);
            this.tabPageMovieModify.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageMovieUpload.ResumeLayout(false);
            this.tabPageMovieUpload.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPageMovieImage.ResumeLayout(false);
            this.tabPageMovieImage.PerformLayout();
            this.tabPageMovieSound.ResumeLayout(false);
            this.tabPageMovieSound.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button buttonIndexImageRefresh;
        private System.Windows.Forms.Label labelMovieIndexImagesDir;
        private System.Windows.Forms.Button buttonMovieIndexImagesDir;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonReadMovieDir;
        private System.Windows.Forms.Label labelMoviesDir;
        private System.Windows.Forms.Button buttonMovieRefresh;
        private System.Windows.Forms.ImageList imageListMoviesForParent;
        private System.Windows.Forms.Button buttonExitParent;
        private System.Windows.Forms.Button buttonAddIndexImage;
        private System.Windows.Forms.Button buttonAddSound;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonSoundSave;
        private System.Windows.Forms.Button buttonSoundLoad;
        private System.Windows.Forms.Label labelRecording;
        private System.Windows.Forms.Button btMovieDelete;
        public System.Windows.Forms.NotifyIcon notifyIconForParent;
        private System.Windows.Forms.Button buttonPlayMovieSound;
        private System.Windows.Forms.TabControl tabControlMovieParent;
        private System.Windows.Forms.TabPage tabPageMovieModify;
        private System.Windows.Forms.TabPage tabPageMovieUpload;
        private System.Windows.Forms.TextBox textBoxMovieUploadMovieName;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.TabPage tabPageMovieImage;
        private System.Windows.Forms.TabPage tabPageMovieSound;
        private System.Windows.Forms.ListView listViewMoviesForParent;
        private System.Windows.Forms.Label labelMovieIDText;
        private System.Windows.Forms.Button buttonRecordImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxMovieModifyMovieName;
        private System.Windows.Forms.Label labelMovieNameText;
        private System.Windows.Forms.Label labelMovieNameEnglishText;
        private System.Windows.Forms.TextBox textBoxMovieModifyMovieID;
        private System.Windows.Forms.TextBox textBoxMovieModifyMovieNameEnglish;
        private System.Windows.Forms.Label labelSelectedImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxMovieUploadMovieNameEnglish;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBoxMovieSoundMovieName;
        private System.Windows.Forms.Label labelMovieSoundMovieNameText;
        private System.Windows.Forms.Label labelMovieSoundMovieNameEnglish;
        private System.Windows.Forms.TextBox textBoxMovieSoundMovieID;
        private System.Windows.Forms.TextBox textBoxMovieSoundMovieNameEnglish;
        private System.Windows.Forms.Label labelMovieSoundMovidIDText;
        private System.Windows.Forms.Label labelMovieUploadMovieLinkType;
        private System.Windows.Forms.Label labelMovieUploadMovieLink;
        private System.Windows.Forms.TextBox textBoxMovieUploadMovieLink;
        private System.Windows.Forms.TextBox textBoxMovieUploadLinkType;
    }
}

