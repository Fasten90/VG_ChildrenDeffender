using ChildrenDeffenderForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildrenDeffenderForm
{
    public partial class FormMovieChildren : Form
    {
        public FormMovieChildren()
        {
            InitializeComponent();
 
        }


        private void FormMovieChildren_Load(object sender, EventArgs e)
        {
            //GetMoviesForChildren();
            imageListMoviesForChildren.Images.Add(Image.FromFile("D:\\Minden\\Gabika dolgai\\ChildrenDeffender\\Images\\image1.bmp"));
            listViewMoviesForChildren.Refresh();
            /*
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

                //dataGridViewMovies.DataSource = movies;
                //var resp = client.GetAsync(string.Format("http://localhost:3051/api/Movie/{0}", id)).Result;
                //resp.EnsureSuccessStatusCode();
                //var movie = resp.Content.ReadAsAsync<Movie>().Result;
                //return movie;   // TODO: Ide érdemes breakpoint-ot tenni ... látni hogy mit kérdezett le

                // TODO: itt kéne értékadás
                //flowLayoutPanel.DataBindings = movies;
            }

            
            // TODO: kiszedni
            imageListMoviesForChildren.Images.Add(Image.FromFile(@"D:\Minden\Gabika dolgai\ChildrenDeffender\Images\image1.bmp"));
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
