namespace ChildrenDeffenderForm
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.listViewUsersForLogin = new System.Windows.Forms.ListView();
            this.imageListUsersForLogin = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxLoginExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginExit)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewUsersForLogin
            // 
            this.listViewUsersForLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUsersForLogin.LargeImageList = this.imageListUsersForLogin;
            this.listViewUsersForLogin.Location = new System.Drawing.Point(0, 0);
            this.listViewUsersForLogin.Name = "listViewUsersForLogin";
            this.listViewUsersForLogin.Size = new System.Drawing.Size(784, 362);
            this.listViewUsersForLogin.TabIndex = 2;
            this.listViewUsersForLogin.UseCompatibleStateImageBehavior = false;
            this.listViewUsersForLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewUsersForLogin_MouseClick);
            this.listViewUsersForLogin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewUsersForLogin_MouseDoubleClick);
            // 
            // imageListUsersForLogin
            // 
            this.imageListUsersForLogin.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListUsersForLogin.ImageSize = new System.Drawing.Size(128, 128);
            this.imageListUsersForLogin.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBoxLoginExit
            // 
            this.pictureBoxLoginExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLoginExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoginExit.Image")));
            this.pictureBoxLoginExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoginExit.InitialImage")));
            this.pictureBoxLoginExit.Location = new System.Drawing.Point(644, 222);
            this.pictureBoxLoginExit.MaximumSize = new System.Drawing.Size(128, 128);
            this.pictureBoxLoginExit.MinimumSize = new System.Drawing.Size(128, 128);
            this.pictureBoxLoginExit.Name = "pictureBoxLoginExit";
            this.pictureBoxLoginExit.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxLoginExit.TabIndex = 3;
            this.pictureBoxLoginExit.TabStop = false;
            this.pictureBoxLoginExit.Click += new System.EventHandler(this.pictureBoxLoginExit_Click);
            this.pictureBoxLoginExit.DoubleClick += new System.EventHandler(this.pictureBoxLoginExit_DoubleClick);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.pictureBoxLoginExit);
            this.Controls.Add(this.listViewUsersForLogin);
            this.MinimumSize = new System.Drawing.Size(256, 128);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewUsersForLogin;
        private System.Windows.Forms.ImageList imageListUsersForLogin;
        private System.Windows.Forms.PictureBox pictureBoxLoginExit;
    }
}