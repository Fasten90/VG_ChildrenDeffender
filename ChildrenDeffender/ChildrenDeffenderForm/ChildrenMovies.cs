using ChildrenDeffenderDatabaseModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Core;

namespace ChildrenDeffenderForm
{
    class ChildrenMovies
    {

        public List<movie> Movies;
        ChildrenDeffenderConfig Config;



        public ChildrenMovies(ChildrenDeffenderConfig conf)
        {
            this.Config = conf;

        }



        public async void GetChildrenMovies(ImageList imageListMovies, ListView listViewMovies, DataGridView dataGridView = null)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var resp = await client.GetAsync(Config.ApiLink + "Movie");

                    Movies = await resp.Content.ReadAsAsync<List<movie>>();
                    
                    SaveMoviesToXml();              // Mentés XML-be

                    SortMovies();

                    LoadMoviesImages(imageListMovies, listViewMovies); // ImageList-be és ListView-ba betöltés
                    
                    if (dataGridView != null)   // dataGriedView-ba betöltés
                    {
                        dataGridView.DataSource = Movies;
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine("Load Movies from database has been failed.");
                    //Console.WriteLine("Error message: {0}.", e.Message);
                    Log.SendErrorLog("Load Movies from database has been failed: " + e.Message);

                    LoadMoviesFromXml();            // Betöltés Xml-ből

                    LoadMoviesImages(imageListMovies, listViewMovies);   // TODO: jó itt?
                }



            }

        }



        public void LoadMoviesImages(ImageList imageListMovies, ListView listViewMovies)  // TODO: összevonni a Children-es verzióval!
        {

            // imageList, listView törlése        
            imageListMovies.Images.Clear();
            listViewMovies.Items.Clear();

            // ListView-be berakás
            int i = 0;


            // Movie-k megnézése
            foreach (var item in Movies)
            {
                // If has got Name
                if (item.MovieNameEnglish != null)
                {
                    // path + name + format
                    String path = Config.MovieIndexImagesDir +
                                    item.MovieNameEnglish.Trim() +
                                    Config.MovieIndexImagesFormat;

                    try
                    {
                        imageListMovies.Images.Add(Image.FromFile(path));
                        ListViewItem listViewMovie = new ListViewItem();
                        listViewMovie.ImageIndex = i;
                        listViewMovie.Tag = item;                   // AZONOSÍTÓ !!!!!!!!!
                        //listViewMovie.Text = item.NameEnglish;    // Megjelenítené, ezért kockázatos !!!!!!! TODO:
                        listViewMovies.Items.Add(listViewMovie);
                        i++; // if it is ok
                    }
                    catch (Exception e)
                    {
                        //Console.WriteLine("Cannot load MovieID={0}'s image.", item.MovieID);
                        //Console.WriteLine("Error message: {0}.", e.Message);
                        Log.SendErrorLog("Cannot load image MovieID= " + item.MovieID.ToString() + " "+ e.Message);
                    }

                }
                else
                {
                    //Console.WriteLine("MovieID={0} Movie hasnt NameEnglish property, so cant load that.", item.MovieID);
                    Log.SendErrorLog("MovieID={0} Movie hasnt NameEnglish property, so cant load that." + item.MovieID.ToString());
                    
                }


            }
            // end of ListView

        }


        private void SortMovies()
        {
            // Itt lehet sort...


            List<movie> SortedList = Movies.OrderBy(p => p.FavID).ToList();
            Movies = SortedList;

        }



        public int GetMovieMaxID()
        {
            int max = Movies.Max(t => t.MovieID);

            return max;
        }




        public void ChildrenPlayMovie(movie item, Form backForm)
        {

            String linkType = item.LinkType;

            if (linkType != null)   // if has got linkType
            {
                linkType = linkType.Trim();
                if (linkType == "local")
                {
                    //Common.PlayLocalMovie(item, Config);

                    // TEST1
                    FormMoviePlayer form = new FormMoviePlayer(item,Config,backForm);

                    // TEST2: static... ?
                    //Common.PlayLocalMovieVLC();

                    // TEST3:
                    //PlayLocalMovieVLC();
                }
                else if (linkType == "youtube")
                {
                    //Common.PlayNetMovie(item, oldform);
                    Common.PlayNetMovie(item, backForm);
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



        private void PlayLocalMovieVLC()    // Törölni, a FormMoviePlayer-ben is benne van ...
        {

     

            // VLC
            // GOOOD, de vezérelhetetlen, és elérhetetlen form ???
            ///*
            
            DirectoryInfo vlcLibDirectory = new DirectoryInfo(@"c:\Program Files (x86)\VideoLAN\VLC\");
            VlcMediaPlayer vlcPlayer = new VlcMediaPlayer(vlcLibDirectory);

            // VlcMedia SetMedia(FileInfo file, params string[] options);

            Uri uri = new Uri(@"d:\Minden\Mese\BigHero.avi");
            vlcPlayer.SetMedia(uri, null);
            vlcPlayer.Play();
            vlcPlayer.Pause();

            //*/


            /*
            // Processként...
            string vlc = @"C:\Program Files\VideoLAN\VLC\vlc.exe";
            Process vlcProcess = new Process();
            vlcProcess.StartInfo.FileName = vlc;
            vlcProcess.StartInfo.Arguments = "\"" + videoFile + "\"";
            vlcProcess.StartInfo.Arguments += " --play-and-exit";
            vlcProcess.Start();
            vlcProcess.Exit();  
            */


            //vlcPlayer.
            // TODO: FULL SCREEN
            // TODO: DLL HIBÁK VANNAK
        }




        public void ChildrenPlayMovieSound(movie item)
        {
            String soundFileName = item.MovieNameEnglish.Trim();
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
                        //Console.WriteLine("Sound play error with {0}.", soundFileName);
                        //Console.WriteLine("Error message: {0}.", e.Message);
                        Log.SendErrorLog("Sound play error with " + soundFileName.ToString() + " " + e.Message );
                    }


                }
                else
                {
                    //Console.WriteLine("Not found the \"{0}\" sound.", soundFullPath);
                    Log.SendErrorLog("Not found the sound:  " + soundFullPath);
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





        private void LoadMoviesFromXml()
        {

            // Then in some other function.
            //Person person = XmlSerialization.ReadFromXmlFile<Person>("C:\person.txt");
            //List<Person> people = XmlSerialization.ReadFromXmlFile<List<Person>>("C:\people.txt");
            Movies = XmlSerialization.ReadFromXmlFile<List<movie>>("Movies.xml");

            Log.SendEventLog("Load movies from Movies.xml has been successful.");

        }

        private void SaveMoviesToXml()
        {
            // And then in some function.
            //Person person = new Person() { Name = "Dan", Age = 30; HomeAddress = new Address() { StreetAddress = "123 My St", City = "Regina" }};
            //List<Person> people = GetListOfPeople();
            //XmlSerialization.WriteToXmlFile<Person>("C:\person.txt", person);
            //XmlSerialization.WriteToXmlFile<List<People>>("C:\people.txt", people);
            XmlSerialization.WriteToXmlFile<List<movie>>("Movies.xml", Movies);

            Log.SendEventLog("Save movies from Movies.xml has been successful.");
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







        // PASTE NEW FUNCTIONS...

    }
}
