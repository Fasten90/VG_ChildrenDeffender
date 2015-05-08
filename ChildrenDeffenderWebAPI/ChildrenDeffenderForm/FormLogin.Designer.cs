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
            this.buttonLoginChildren = new System.Windows.Forms.Button();
            this.buttonLoginParent = new System.Windows.Forms.Button();
            this.listViewUsersForLogin = new System.Windows.Forms.ListView();
            this.imageListUsersForLogin = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // buttonLoginChildren
            // 
            this.buttonLoginChildren.Location = new System.Drawing.Point(681, 54);
            this.buttonLoginChildren.Name = "buttonLoginChildren";
            this.buttonLoginChildren.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginChildren.TabIndex = 0;
            this.buttonLoginChildren.Text = "Children";
            this.buttonLoginChildren.UseVisualStyleBackColor = true;
            this.buttonLoginChildren.Click += new System.EventHandler(this.buttonLoginChildren_Click);
            // 
            // buttonLoginParent
            // 
            this.buttonLoginParent.Location = new System.Drawing.Point(681, 83);
            this.buttonLoginParent.Name = "buttonLoginParent";
            this.buttonLoginParent.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginParent.TabIndex = 1;
            this.buttonLoginParent.Text = "Parent";
            this.buttonLoginParent.UseVisualStyleBackColor = true;
            this.buttonLoginParent.Click += new System.EventHandler(this.buttonLoginParent_Click);
            // 
            // listViewUsersForLogin
            // 
            this.listViewUsersForLogin.LargeImageList = this.imageListUsersForLogin;
            this.listViewUsersForLogin.Location = new System.Drawing.Point(13, 13);
            this.listViewUsersForLogin.Name = "listViewUsersForLogin";
            this.listViewUsersForLogin.Size = new System.Drawing.Size(662, 337);
            this.listViewUsersForLogin.TabIndex = 2;
            this.listViewUsersForLogin.UseCompatibleStateImageBehavior = false;
            this.listViewUsersForLogin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewUsersForLogin_MouseDoubleClick);
            // 
            // imageListUsersForLogin
            // 
            this.imageListUsersForLogin.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListUsersForLogin.ImageSize = new System.Drawing.Size(128, 128);
            this.imageListUsersForLogin.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.listViewUsersForLogin);
            this.Controls.Add(this.buttonLoginParent);
            this.Controls.Add(this.buttonLoginChildren);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginChildren;
        private System.Windows.Forms.Button buttonLoginParent;
        private System.Windows.Forms.ListView listViewUsersForLogin;
        private System.Windows.Forms.ImageList imageListUsersForLogin;
    }
}