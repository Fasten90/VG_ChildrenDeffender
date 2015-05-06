﻿using ChildrenDeffenderForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildrenDeffenderForm
{
    public partial class FormMovieChildren : Form
    {

        List<IndexImage> ChildrenIndexImages;
        List<Movie> ChildrenMovies;

        public FormMovieChildren()
        {
            InitializeComponent();
 
        }


        private void FormMovieChildren_Load(object sender, EventArgs e)
        {

            GetIndexImagesForChildren();
            GetMoviesForChildren();

            //
            /*
            // GOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOODDDDDDDDDDDDDDDDDDDD
            imageListMoviesForChildren.Images.Add(Image.FromFile("c:\\Images\\image1.bmp"));      
            //imageListMoviesForChildren.Images.Add(Bitmap.FromFile("c:\\Images\\image1.bmp"));

            //this.listViewMoviesForChildren.View = View.LargeIcon;
            //this.listViewMoviesForChildren.LargeImageList = this.imageListMoviesForChildren;
            
            ListViewItem listViewMovie = new ListViewItem();
            listViewMovie.ImageIndex = 0;
            listViewMovie.Text = "Test";
            listViewMoviesForChildren.Items.Add(listViewMovie);
            //*/



            // GOOOOOOOOOOOOOOOOODDDDDDDDDDDDDDDDDDD
            // READ DIR images
            /*
            string[] filePaths = Directory.GetFiles(@"D:\Minden\Gabika dolgai\ChildrenDeffender\Images\");

            for (int i=0; i<filePaths.Length; i++)
            {
                imageListMoviesForChildren.Images.Add(Image.FromFile(filePaths[i]));
                ListViewItem listViewMovie = new ListViewItem();
                listViewMovie.ImageIndex = i;
                listViewMoviesForChildren.Items.Add(listViewMovie);
            }
            */


            /*
            // NOT GOOD, a sleep nem jó benne, átrakva a lekérdező függvénybe
            String IndexImageFilePath = @"D:\Minden\Gabika dolgai\ChildrenDeffender\Images\";
            while (ChildrenIndexImages == null) System.Threading.Thread.Sleep(1000);
            foreach ( var item in ChildrenIndexImages )
            {
                String path = IndexImageFilePath + item.IndexImageName;
                imageListMoviesForChildren.Images.Add(Image.FromFile(path));
                ListViewItem listViewMovie = new ListViewItem();
                listViewMovie.ImageIndex = item.IndexImageID;
                listViewMoviesForChildren.Items.Add(listViewMovie);
            }
            */



            /*
            // TEST CODE - DO NOT USE
            this.listView1.View = View.LargeIcon;
            this.imageList1.ImageSize = new Size(32, 32);
            this.listView1.LargeImageList = this.imageList1;        // OK

            //or
            //this.listView1.View = View.SmallIcon;
            //this.listView1.SmallImageList = this.imageList1;

            for (int j = 0; j < this.imageList1.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.listView1.Items.Add(item);
            }
            */


            /*
            // TEST CODE - DO NOT USE
                ImageList il = new ImageList();
                il.Images.Add("test1", Image.FromFile(@"c:\Documents\SharpDevelop Projects\learning2\learning2\Koala.jpg"));

                listView1.View = View.LargeIcon;
                listView1.LargeImageList = il;
                listView1.Items.Add("test");

                for(int i = 0; i < il.Images.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = i;
                    lvi.Text="koala 1";
                    listView1.Items.Add(lvi);
                }
             */

        }

        private async void GetMoviesForChildren()
        {
            using (var client = new HttpClient())
            {
                var resp = await client.GetAsync("http://localhost:3051/api/Movie");

                var movies = await resp.Content.ReadAsAsync<List<Movie>>();

                ChildrenMovies = movies;
            }
            
        }



        private async void GetIndexImagesForChildren()
        {
            using (var client = new HttpClient())
            {
                // Lekérdezés
                var resp = await client.GetAsync("http://localhost:3051/api/IndexImage");
                var indeximages = await resp.Content.ReadAsAsync<List<IndexImage>>();
                //indeximages.  // TODO: csak a movie jellegűeket?
                ChildrenIndexImages = indeximages;
                // End of Lekérdezés


                // ListView-be berakás
                String IndexImageFilePath = @"D:\Minden\Gabika dolgai\ChildrenDeffender\Images\";
                foreach (var item in ChildrenIndexImages)
                {
                    String path = IndexImageFilePath + item.IndexImageName;
                    imageListMoviesForChildren.Images.Add(Image.FromFile(path));    // TODO: hiányzó képre exceptiont dob, lekezelni
                    ListViewItem listViewMovie = new ListViewItem();
                    listViewMovie.ImageIndex = item.IndexImageID;
                    listViewMoviesForChildren.Items.Add(listViewMovie);
                }
                // end of ListView
                
            }



        }

        /*
        	private void Form1_Load(object sender, EventArgs e)
	        {
	            // Add these file names to the ImageList on load.
	            string[] files = { "image.png", "logo.jpg" };
	            var images = imageList1.Images;
	            foreach (string file in files)
	            {
		        // Use Image.FromFile to load the file.
		        images.Add(Image.FromFile(file));
	            }
	        }
         */


    }
}
