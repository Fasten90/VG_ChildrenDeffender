using ChildrenDeffenderForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc;
using Vlc.DotNet.Forms;
using Vlc.DotNet.Core;


namespace ChildrenDeffenderForm
{
    public partial class FormMovieChildren : Form
    {

        //List<IndexImage> ChildrenIndexImages;
        //List<Movie> ChildrenMovies;
        ChildrenDeffenderConfig Config;
        ChildrenMovies ChildrenMovies;
        Form BackForm;

        public FormMovieChildren(ChildrenDeffenderConfig conf, Form backForm ) 
        {
            InitializeComponent();

            this.Config = conf;
            this.BackForm = backForm;
            this.ChildrenMovies = new ChildrenMovies(conf);
 
        }


        private void FormMovieChildren_Load(object sender, EventArgs e)
        {

            //GetIndexImagesForChildren(); IndexImage table....
            ChildrenMovies.GetChildrenMovies(imageListMoviesForChildren, listViewMoviesForChildren);

            // TODO: LOAD FROM XML
            //LoadMoviesFromXml();
            //SaveMoviesToXml();

        }


        /*
        private async void GetMoviesForChildren()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var resp = await client.GetAsync(Config.ApiLink + "Movie");

                    var movies = await resp.Content.ReadAsAsync<List<Movie>>();

                    ChildrenMovies = movies;

                    SaveMoviesToXml();  // TODO: jó itt?

                    LoadIndexImagesForChildren(); // TODO: jó itt?

                }
                catch (Exception e)
                {
                    Console.WriteLine("Load Movies from database has been failed.");
                    Console.WriteLine("Error message: {0}.", e.Message);

                    LoadMoviesFromXml();            // Betöltés Xml-ből

                    LoadIndexImagesForChildren();   // TODO: jó itt?
                }



            }
            
        }
        */


        /*
        private async void GetIndexImagesForChildren()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    // Lekérdezés
                    var resp = await client.GetAsync("http://localhost:3051/api/IndexImage");
                    var indeximages = await resp.Content.ReadAsAsync<List<IndexImage>>();
                    //indeximages.  // TODO: csak a movie jellegűeket?
                    ChildrenIndexImages = indeximages;
                    // End of Lekérdezés

                    SaveIndexImagesToXml();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Cannot get IndexImages from database.");
                    Console.WriteLine("Error message: {0}.", e.Message);
                    try
                    {
                        LoadIndexImagesFromXml();
                        Console.WriteLine("IndexImages has been loaded from Movies.xml");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("LoadIndexImagesFromXml is failed.");
                        Console.WriteLine("Error message: {0}.",ex.Message);
                    }
                    
                }
 
            }

            // Itt lehet sort...
            // TODO: GOND: a listában való sorrendnél feltételezzük az = IndexImageID-t...
            // így ha ez megváltozik, akkor más mese hangját játsszuk le, meg ID-je van mögötte....
            // TODO: BUGFIX
            //List<IndexImage> SortedList = ChildrenIndexImages.OrderBy(p => p.DateAdded).ToList();
            //ChildrenIndexImages = SortedList;


            //LoadIndexImagesForChildren(); // kivéve, mert az IndexImage table...

        }
        */


        /*
        private void LoadIndexImagesForChildren()   // TODO: ezt össze lehetne vonni :P
        {

            //// Eredeti, IndexImage táblás mód... helyette lentebb egy Movie -> NameEnglish...
            //// ListView-be berakás
            //String IndexImageFilePath = Config.MovieIndexImagesDir;
            //foreach (var item in ChildrenIndexImages)
            //{
            //    String path = IndexImageFilePath + item.IndexImageName;
            //    imageListMoviesForChildren.Images.Add(Image.FromFile(path));    // TODO: hiányzó képre exceptiont dob, lekezelni
            //    ListViewItem listViewMovie = new ListViewItem();
            //    listViewMovie.ImageIndex = item.IndexImageID;
            //    listViewMoviesForChildren.Items.Add(listViewMovie);
            //}
            //// end of ListView


            // ListView-be berakás
            int i = 0;

            foreach (var item in ChildrenMovies)
            {
                // If has got Name
                if (item.NameEnglish != null)
                {
                    // path + name + format
                    String path = Config.MovieIndexImagesDir +
                                    item.NameEnglish.Trim() +
                                    Config.MovieIndexImagesFormat;

                    try
                    {
                        imageListMoviesForChildren.Images.Add(Image.FromFile(path));
                        ListViewItem listViewMovie = new ListViewItem();
                        listViewMovie.ImageIndex = i;
                        listViewMovie.Tag = item;                   // AZONOSÍTÓ !!!!!!!!!
                        //listViewMovie.Text = item.NameEnglish;    // Megjelenítené, ezért kockázatos !!!!!!! TODO:
                        listViewMoviesForChildren.Items.Add(listViewMovie);
                        i++; // if it is ok
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Cannot load MovieID={0}'s image.", item.MovieID);
                        Console.WriteLine("Error message: {0}.", e.Message);
                    }

                }

            }
            // end of ListView
        }
        */


        private void listViewMoviesForChildren_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // TODO: függvény a listViewItem --> movie konvertálásra


            ListViewItem listViewItem = new ListViewItem();
            listViewItem = listViewMoviesForChildren.FocusedItem;

            //int imageID = listViewItem.ImageIndex; // for table...
            Movie movie = new Movie();
            movie = (Movie)listViewItem.Tag;

            if (movie != null)
            {
                ChildrenMovies.ChildrenPlayMovie(movie, this); // lejátszás
            }


            /*
            // OLD_GOOD: IndexImage table-s verzió ...
            ListViewItem listViewItem = new ListViewItem();
            listViewItem = listViewMoviesForChildren.FocusedItem;

            int imageID = listViewItem.ImageIndex;

            //ChildrenMovies.Find()
            foreach (var item in ChildrenMovies)
            {
                if (item.IndexImageID == imageID)
                {
                    ChildrenPlayMovie(item);
                    break;
                }
            }
            */

         }



         private void listViewMoviesForChildren_MouseClick(object sender, MouseEventArgs e)
         {

             ListViewItem listViewItem = new ListViewItem();
             listViewItem = listViewMoviesForChildren.FocusedItem;

             //int imageID = listViewItem.ImageIndex; // for table...
             Movie movie = new Movie();
             movie = (Movie)listViewItem.Tag;

             if (movie != null)
             {
                 ChildrenMovies.ChildrenPlayMovieSound(movie); // lejátszás
             }
             else
             {      // Error log
                 Console.WriteLine("There is not found the movie from ListViewMoviesForChildren, index: {0}",
                     listViewItem.ImageIndex);
             }


             /*
             // OLD_GOOD: IndexImage version
             ListViewItem listViewItem = new ListViewItem();
             listViewItem = listViewMoviesForChildren.FocusedItem;

             int imageID = listViewItem.ImageIndex; 

             foreach (var item in ChildrenMovies)
             {
                 if (item.IndexImageID == imageID)
                 {
                     ChildrenPlayMovieSound(item);
                     break;
                 }
             }
             */
         }



         private void pictureBoxBack_Click(object sender, EventArgs e)
         {
            // TODO: sound for back
            Common.PlaySound(Config.SoundMenuBack);
         }

         private void pictureBoxBack_DoubleClick(object sender, EventArgs e)
         {
             // Good, but memory is growing...
             //this.Hide();
             //FormLogin form = new FormLogin();
             //form.Show();
             //this.ParentForm.Show();
             ThisFormSwitchToBackForm();
         }


        private void ThisFormSwitchToBackForm ()
        {
             this.Close();
             this.BackForm.Show();
        }


         private void pictureBoxExit_Click(object sender, EventArgs e)
         {
             // TODO: sound for exit
             Common.PlaySound(Config.SoundMenuExit);

         }

         private void pictureBoxExit_DoubleClick(object sender, EventArgs e)
         {
             Application.Exit();
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

      
        /*
        private void timerFormMovieChildrenForDownload_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("The 'timerFormMovieCHildrenForDownload' timer is has ended.");
            if ( ChildrenMovies == null)
            {
                LoadMoviesFromXml();
                LoadIndexImagesForChildren();   // TODO: jó itt?
                Console.WriteLine("ChildrenMovies has been loaded from Movies.xml");
            }
            timerFormMovieChildrenForDownload.Enabled = false;
            
        }
         */


         public bool PlayNetMovie(Movie item)
         {

             //String movielink = item.MovieLink;

             this.Hide();
             FormMovieChildrenNetVideoPlayer form = new FormMovieChildrenNetVideoPlayer(item,this);   //,oldform
             form.Show();

             return true;

         }




    }
}


// FOR WORK
//Console.WriteLine("Error message: {0}.", e.Message);


