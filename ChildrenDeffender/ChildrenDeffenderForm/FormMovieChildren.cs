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

        List<IndexImage> ChildrenIndexImages;
        List<Movie> ChildrenMovies;
        ChildrenDeffenderConfig Config;


        public FormMovieChildren(ChildrenDeffenderConfig conf)
        {
            InitializeComponent();
            this.Config = conf;
 
        }


        private void FormMovieChildren_Load(object sender, EventArgs e)
        {

            GetIndexImagesForChildren();
            GetMoviesForChildren();

            // TODO: LOAD FROM XML
            //LoadMoviesFromXml();
            //SaveMoviesToXml();

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


                // TODO: SAVE TO XML
                SaveMoviesToXml();

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
                String IndexImageFilePath = Config.MovieIndexImagesDir;
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

        private void listViewMoviesForChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListViewItem items = new ListViewItem();
            //items = listViewMoviesForChildren.SelectedItems();

            //MessageBox.Show("Klikkeltél{0}"+items.ImageIndex.ToString());
        }

        private void listViewMoviesForChildren_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            //ListViewItem items = new ListViewItem();
            //items = listViewMoviesForChildren.SelectedItems;

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



            /*
            DependencyObject obj = (DependencyObject)e.OriginalSource;

            while (obj != null && obj != myListView)
            {
                if (obj.GetType() == typeof(ListViewItem))
                {
                    // Do something here
                    MessageBox.Show("A ListViewItem was double clicked!");

                    break;
                }
                obj = VisualTreeHelper.GetParent(obj);
            }
             * */
         }

         void ChildrenPlayMovie(Movie item)
         {
             String linkType = item.LinkType.Trim();

             if (linkType == "local")
             {
                 Common.PlayLocalMovie(item, Config);
             }
             else if (linkType == "youtube")
             {
                 Common.PlayNetMovie(item, this);
             }
             else
             {
                 Common.PlayLocalMovie(item, Config);
             }

             // TODO: ManyVIews++


            // PLAYING LOCAL MOVIE
             /*
             String moviename = item.MovieLink.Trim();
             String program = Config.MoviePlayer;
             String moviedir = Config.MoviesDir;

             //Process secondProc = new Process();
             // "parancs" "paraméter"
             //secondProc.StartInfo.FileName = "\"" + program + "\"; //  \"" + moviedir + moviename + "\"";
             //secondProc.Start();

             //System.Diagnostics.Process.Start(@"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe");
             String command = program;
             String argument = moviedir + moviename;
             System.Diagnostics.Process.Start(command, argument);
             */






             // FOR TEST
             //String command = "\"" + program + "\"";
             //System.Diagnostics.Process.Start(command);

             // JÓ: program
             // NEM JÓ: "\"" + program + "\"; //  \"" + moviedir + moviename + "\""

             




             // TODO:
             // FOR VLC ..............

             /*
             // TODO: VLC, megbízhatatlannak tűnik és hiányzik a példakódból is valami .... 
             //Vlc.DotNet.Core.VlcMediaPlayer;
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);

             VlcControl VlcContext = new VlcControl();
             //Set libvlc.dll and libvlccore.dll directory path
             VlcContext.LibVlcDllsPath = CommonStrings.LIBVLC_DLLS_PATH_DEFAULT_VALUE_AMD64;
             //Set the vlc plugins directory path
             VlcContext.LibVlcPluginsPath = CommonStrings.PLUGINS_PATH_DEFAULT_VALUE_AMD64;

             //Set the startup options
             VlcContext.StartupOptions.IgnoreConfig = true;
             VlcContext.StartupOptions.LogOptions.LogInFile = true;
             VlcContext.StartupOptions.LogOptions.ShowLoggerConsole = true;
             VlcContext.StartupOptions.LogOptions.Verbosity = VlcLogOptions.Verbosities.Debug;

             //Initialize the VlcContext
             VlcContext.Initialize();

             Application.Run(new Form1());

             //Close the VlcContext
             VlcContext.CloseAll(); 
             */
         }

         private void listViewMoviesForChildren_MouseClick(object sender, MouseEventArgs e)
         {
             //ListViewItem items = new ListViewItem();
             //items = listViewMoviesForChildren.SelectedItems;

             ListViewItem listViewItem = new ListViewItem();
             listViewItem = listViewMoviesForChildren.FocusedItem;

             int imageID = listViewItem.ImageIndex;

             //ChildrenMovies.Find()
             foreach (var item in ChildrenMovies)
             {
                 if (item.IndexImageID == imageID)
                 {
                     ChildrenPlayMovieSound(item);
                     break;
                 }
             }
         }


         void ChildrenPlayMovieSound(Movie item)
         {
            String soundFileName = item.NameEnglish.Trim();
            String soundDir = Config.MovieSoundsDir;
            String format = Config.MovieSoundsFormat;


            if (soundFileName != null)        // TODO - külön függvénybe !!!!!!!!!!!!!!!!!!
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundDir + soundFileName + format);
                player.Play();
            }

         }

        /*
         void PlaySound(String sound)   // At Common class 
         {

             if (sound != null)        // TODO - külön függvénybe !!!!!!!!!!!!!!!!!!
             {
                 System.Media.SoundPlayer player = new System.Media.SoundPlayer(sound);
                 player.Play();
             }

         }
        */

         private void pictureBoxBack_Click(object sender, EventArgs e)
         {
            // TODO: sound for back
            Common.PlaySound(Config.SoundMenuBack);
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

         private void pictureBoxBack_DoubleClick(object sender, EventArgs e)
         {
             this.Hide();
             FormLogin form = new FormLogin();
             form.Show();
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

        private void LoadMoviesFromXml ()
        {

            // Then in some other function.
            //Person person = XmlSerialization.ReadFromXmlFile<Person>("C:\person.txt");
            //List<Person> people = XmlSerialization.ReadFromXmlFile<List<Person>>("C:\people.txt");
            ChildrenMovies = XmlSerialization.ReadFromXmlFile<List<Movie>>("Movies.xml");

        }

        private void SaveMoviesToXml ()
        {
            // And then in some function.
            //Person person = new Person() { Name = "Dan", Age = 30; HomeAddress = new Address() { StreetAddress = "123 My St", City = "Regina" }};
            //List<Person> people = GetListOfPeople();
            //XmlSerialization.WriteToXmlFile<Person>("C:\person.txt", person);
            //XmlSerialization.WriteToXmlFile<List<People>>("C:\people.txt", people);
            XmlSerialization.WriteToXmlFile<List<Movie>>("Movies.xml", ChildrenMovies);
        }

        private void timerFormMovieChildrenForDownload_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("The 'timerFormMovieCHildrenForDownload' timer is has ended.");
            if ( ChildrenMovies == null)
            {
                LoadMoviesFromXml();
                Console.WriteLine("ChildrenMovies has been loaded from Movies.xml");
            }
            timerFormMovieChildrenForDownload.Enabled = false;
            
        }




    }
}
