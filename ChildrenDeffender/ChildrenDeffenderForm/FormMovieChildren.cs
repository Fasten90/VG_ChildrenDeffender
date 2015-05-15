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
        List<Movie> ChildrenMovies;
        ChildrenDeffenderConfig Config;


        public FormMovieChildren(ChildrenDeffenderConfig conf)
        {
            InitializeComponent();
            this.Config = conf;
 
        }


        private void FormMovieChildren_Load(object sender, EventArgs e)
        {

            //GetIndexImagesForChildren(); IndexImage table....
            GetMoviesForChildren();

            // TODO: LOAD FROM XML
            //LoadMoviesFromXml();
            //SaveMoviesToXml();

        }

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

                    LoadMoviesFromXml();
                }



            }
            
        }


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

        private void LoadIndexImagesForChildren()   // TODO: ezt össze lehetne vonni :P
        {
            /*
            // Eredeti, IndexImage táblás mód... helyette lentebb egy Movie -> NameEnglish...
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
            */

            // ListView-be berakás
            int i = 0;

            foreach (var item in ChildrenMovies)
            {
                // path + name + format
                String path = Config.MovieIndexImagesDir + item.NameEnglish.Trim() + Config.MovieIndexImagesFormat;
                try
                {
                    imageListMoviesForChildren.Images.Add(Image.FromFile(path));
                    ListViewItem listViewMovie = new ListViewItem();
                    listViewMovie.ImageIndex = i;
                    listViewMovie.Tag = item;               // AZONOSÍTÓ !!!!!!!!!
                    //listViewMovie.Text = item.NameEnglish;    // Megjelenítené, ezért kockázatos !!!!!!! TODO:
                    listViewMoviesForChildren.Items.Add(listViewMovie);
                    i++; // if it is ok
                }
                catch (Exception e)
                {
                    Console.WriteLine("Cannot load MovieID={0}. image.",item.IndexImageID);
                    Console.WriteLine("Error message: {0}.", e.Message);
                }

            }
            // end of ListView
        }


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
                ChildrenPlayMovie(movie); // lejátszás
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



         void ChildrenPlayMovie(Movie item)
         {

            String linkType = item.LinkType;

            if (linkType != null)   // if has got linkType
            {
                linkType = linkType.Trim();
                if (linkType == "local")
                {
                    Common.PlayLocalMovie(item, Config);
                }
                else if (linkType == "youtube")
                {
                    Common.PlayNetMovie(item, this);
                }
                else
                {   // no local, no youtube
                    Common.PlayLocalMovie(item, Config);
                }
            }
            else
            {   // Nope linkType
                Common.PlaySound(Config.SoundThereIsNoVideo);
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

             ListViewItem listViewItem = new ListViewItem();
             listViewItem = listViewMoviesForChildren.FocusedItem;

             //int imageID = listViewItem.ImageIndex; // for table...
             Movie movie = new Movie();
             movie = (Movie)listViewItem.Tag;

             if (movie != null)
             {
                 ChildrenPlayMovieSound(movie); // lejátszás
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


         void ChildrenPlayMovieSound(Movie item)
         {
            String soundFileName = item.NameEnglish.Trim();
            String soundDir = Config.MovieSoundsDir;
            String format = Config.MovieSoundsFormat;
            String soundFullPath = soundDir + soundFileName + format;

            if (soundFileName != null)        // TODO - külön függvénybe !!!!!!!!!!!!!!!!!!
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundFullPath);
                if (player != null)
                {
                    try
                    {
                        player.Play();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Sound play error with {0}.",soundFileName);
                        Console.WriteLine("Error message: {0}.", e.Message);
                    }

                    
                }
                else
                {
                    Console.WriteLine("Not found the \"{0}\" sound.",soundFullPath);
                }
                
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


        /*
        private void LoadIndexImagesFromXml()
        {

            // Then in some other function.
            //Person person = XmlSerialization.ReadFromXmlFile<Person>("C:\person.txt");
            //List<Person> people = XmlSerialization.ReadFromXmlFile<List<Person>>("C:\people.txt");
            ChildrenIndexImages = XmlSerialization.ReadFromXmlFile<List<IndexImage>>("IndexImages.xml");

        }
        */

        /*
        private void SaveIndexImagesToXml()
        {
            // And then in some function.
            //Person person = new Person() { Name = "Dan", Age = 30; HomeAddress = new Address() { StreetAddress = "123 My St", City = "Regina" }};
            //List<Person> people = GetListOfPeople();
            //XmlSerialization.WriteToXmlFile<Person>("C:\person.txt", person);
            //XmlSerialization.WriteToXmlFile<List<People>>("C:\people.txt", people);
            XmlSerialization.WriteToXmlFile<List<IndexImage>>("IndexImages.xml", ChildrenIndexImages);
        }
        */

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


// FOR WORK
//Console.WriteLine("Error message: {0}.", e.Message);


