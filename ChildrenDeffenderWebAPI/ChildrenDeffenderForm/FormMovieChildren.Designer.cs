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
            this.imageListMoviesForChildren = new System.Windows.Forms.ImageList(this.components);
            this.listViewMoviesForChildren = new System.Windows.Forms.ListView();
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
            this.listViewMoviesForChildren.LargeImageList = this.imageListMoviesForChildren;
            this.listViewMoviesForChildren.Location = new System.Drawing.Point(12, 12);
            this.listViewMoviesForChildren.Name = "listViewMoviesForChildren";
            this.listViewMoviesForChildren.Size = new System.Drawing.Size(810, 271);
            this.listViewMoviesForChildren.TabIndex = 4;
            this.listViewMoviesForChildren.UseCompatibleStateImageBehavior = false;
            // 
            // FormMovieChildren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 295);
            this.Controls.Add(this.listViewMoviesForChildren);
            this.Name = "FormMovieChildren";
            this.Text = "FormMovieChildren";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMovieChildren_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListMoviesForChildren;
        private System.Windows.Forms.ListView listViewMoviesForChildren;
    }
}