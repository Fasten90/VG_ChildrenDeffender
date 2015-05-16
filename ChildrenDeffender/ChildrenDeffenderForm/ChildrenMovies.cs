﻿using ChildrenDeffenderForm.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildrenDeffenderForm
{
    class ChildrenMovies
    {

        public List<Movie> Movies;
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

                    Movies = await resp.Content.ReadAsAsync<List<Movie>>();
                    
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
                    Console.WriteLine("Load Movies from database has been failed.");
                    Console.WriteLine("Error message: {0}.", e.Message);

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
                if (item.NameEnglish != null)
                {
                    // path + name + format
                    String path = Config.MovieIndexImagesDir +
                                    item.NameEnglish.Trim() +
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
                        Console.WriteLine("Cannot load MovieID={0}'s image.", item.MovieID);
                        Console.WriteLine("Error message: {0}.", e.Message);
                    }

                }
                else
                {
                    Console.WriteLine("MovieID={0} Movie hasnt NameEnglish property, so cant load that.", item.MovieID);
                }


            }
            // end of ListView

        }


        private void SortMovies()
        {
            // Itt lehet sort...


            List<Movie> SortedList = Movies.OrderBy(p => p.FavID).ToList();
            Movies = SortedList;

        }



        public int GetMovieMaxID()
        {
            int max = Movies.Max(t => t.MovieID);

            return max;
        }




        public void ChildrenPlayMovie(Movie item, Form backForm)
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




        public void ChildrenPlayMovieSound(Movie item)
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
                        Console.WriteLine("Sound play error with {0}.", soundFileName);
                        Console.WriteLine("Error message: {0}.", e.Message);
                    }


                }
                else
                {
                    Console.WriteLine("Not found the \"{0}\" sound.", soundFullPath);
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
            Movies = XmlSerialization.ReadFromXmlFile<List<Movie>>("Movies.xml");

        }

        private void SaveMoviesToXml()
        {
            // And then in some function.
            //Person person = new Person() { Name = "Dan", Age = 30; HomeAddress = new Address() { StreetAddress = "123 My St", City = "Regina" }};
            //List<Person> people = GetListOfPeople();
            //XmlSerialization.WriteToXmlFile<Person>("C:\person.txt", person);
            //XmlSerialization.WriteToXmlFile<List<People>>("C:\people.txt", people);
            XmlSerialization.WriteToXmlFile<List<Movie>>("Movies.xml", Movies);
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