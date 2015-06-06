using ChildrenDeffenderDatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using System.Globalization;
using System.Threading;


namespace ChildrenDeffenderForm
{
    public partial class FormMovieParent : Form
    {
        ChildrenDeffenderConfig Config;
        ChildrenMovies ChildrenMovies;

        ConfigHandler ConfigHandler;

        Form BackForm;
        // Nem lehet kihagyni, mert a ParentForm az előző form is lehet... ? (pl. netplayer....)

        //List<Movie> ChildrenMovies;
        //List<IndexImage> IndexImages;

        int MovieParentDataGriedViewChangedRowIndex;
        bool IsRowChanged;


        public FormMovieParent(ChildrenDeffenderConfig conf, ConfigHandler configHandler, Form backForm) 
        {
            InitializeComponent();

            this.Config = conf;
            //this.BackForm = this.ParentForm;
            this.BackForm = backForm;
            this.ChildrenMovies = new ChildrenMovies(conf);
            this.ConfigHandler = configHandler;

            labelMovieIndexImagesDir.Text = Config.MovieIndexImagesDir;
            labelMoviesDir.Text = Config.MoviesDir;

            // dataGriedView (táblázat) adatok változtatásának észrevételéhez ...
            MovieParentDataGriedViewChangedRowIndex = -1;
            IsRowChanged = false;

            // Language setting;

            comboBoxMovieParentLanguage.Items.Add(new CultureInfo("en"));
            comboBoxMovieParentLanguage.Items.Add(new CultureInfo("hu-Hu"));
            comboBoxMovieParentLanguage.Items.Add(new CultureInfo("de-De"));

            comboBoxMovieParentLanguage.Text = Config.Language;
            SetLanguage(Config.Language);
        }


        ///*
        // Összes Movie betöltése induláskor
        private void FormMovieParent_Load(object sender, EventArgs e)
        {

            // Refresh Movies
            RefreshMovies();

            // NotifyIcon
            notifyIconForParent.Visible = true;

            //GetIndexImagesForParent();
        }


        /*
        // FOR INDEXIMAGE VERSION
        private async void GetIndexImagesForParent()
        {

            using (var client = new HttpClient())
            {
                // Lekérdezés
                var resp = await client.GetAsync(Config.ApiLink + "IndexImage");
                var indeximages = await resp.Content.ReadAsAsync<List<IndexImage>>();
                //indeximages.  // TODO: csak a movie jellegűeket?
                IndexImages = indeximages;
                // End of Lekérdezés


                // ListView-be berakás
                String IndexImageFilePath = Config.MovieIndexImagesDir;
                listViewIndexImagesForParent.Items.Clear(); // összes törlése
                imageListIndexImagesForParent.Images.Clear();   // összes képecske törlécskéje faszom

                foreach (var item in IndexImages)
                {
                    String path = IndexImageFilePath + item.IndexImageName;
                    imageListIndexImagesForParent.Images.Add(Image.FromFile(path));    // TODO: hiányzó képre exceptiont dob, lekezelni
                    ListViewItem listViewImage = new ListViewItem();
                    listViewImage.ImageIndex = item.IndexImageID;
                    listViewIndexImagesForParent.Items.Add(listViewImage);
                }
                // end of ListView
                
            }

        }
        */


        //
        /*
        private async void GetMovies()
        {
            using (var client = new HttpClient())   // TODO: Try + catch
            {
                var resp = await client.GetAsync(Config.ApiLink + "Movie");

                ChildrenMovies.Movies = await resp.Content.ReadAsAsync<List<Movie>>();

                dataGridViewMovies.DataSource = ChildrenMovies;
                //var resp = client.GetAsync(string.Format("http://localhost:3051/api/Movie/{0}", id)).Result;
                //resp.EnsureSuccessStatusCode();
                //var movie = resp.Content.ReadAsAsync<Movie>().Result;
                //return movie;   // TODO: Ide érdemes breakpoint-ot tenni ... látni hogy mit kérdezett le

                //GetIndexImagesForParent();
            }
        }
        //*/

        /*
        private void GetIndexImagesForParent()  // TODO: összevonni a Children-es verzióval!
        {

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
                        imageListIndexImagesForParent.Images.Add(Image.FromFile(path));
                        ListViewItem listViewMovie = new ListViewItem();
                        listViewMovie.ImageIndex = i;
                        listViewMovie.Tag = item;                   // AZONOSÍTÓ !!!!!!!!!
                        //listViewMovie.Text = item.NameEnglish;    // Megjelenítené, ezért kockázatos !!!!!!! TODO:
                        listViewIndexImagesForParent.Items.Add(listViewMovie);
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
        */



       // 
        /*
        private void FormMovieParent_Load(object sender, EventArgs e)
        {

            var movie = GetProduct(1);
            
            dataGridViewMovies.DataSource = movie;
        }


        // WEb Api 2 :: program.cs-be javasolják, de a console application miatt
        static Movie GetProduct(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                var resp = client.GetAsync(string.Format("http://localhost:3051/api/Movie/{0}", id)).Result;
                resp.EnsureSuccessStatusCode();
                var movie = resp.Content.ReadAsAsync<Movie>().Result;
                return movie;   // TODO: Ide érdemes breakpoint-ot tenni ... látni hogy mit kérdezett le
            }
        }//*/


        // Upload gomb - POST
        private async void btUpload_Click(object sender, EventArgs e)
        {
            // new movie
            var movie = new movie
            {
                //MovieID = 11,
                //MovieID = int.Parse(textBoxMovieID.Text), // Good, but so MAX ID
               // MovieID = ChildrenMovies.GetMovieMaxID() + 1,   // TODO: e helyett más? MySQL auto increment?
               // !! IMPORTANT !! --> Changed to Auto Increment

                //MovieName = "Micimackó",
                MovieName = textBoxMovieUploadMovieName.Text.Trim(),    // TODO:Megcsinálni biztonságosabbra?

                MovieNameEnglish = textBoxMovieUploadMovieNameEnglish.Text.Trim(),  // TODO: ide validáció?

                MovieLink = textBoxMovieUploadMovieLink.Text.Trim(),

                LinkType = textBoxMovieUploadLinkType.Text.Trim(),

                //MovieLink = "C:\\",
                //LinkType = "local",
                //Language = "HU",
                //NameEnglish = "Winnie the Pooh",
                //Category = "állatos",
                MinAge = 6,
                ManyViews  = 0,
                DateLastModified = DateTime.Now,
                DateAdded = DateTime.Now
            };


            using (var client = new HttpClient())
            {
                // Post
                // await client.PostAsJsonAsync(Config.ApiLink + "Movie", movie);
                await client.PostAsJsonAsync(Config.ApiLink + "Movie", movie);

                // Get
                var resp = await client.GetAsync(Config.ApiLink + "Movie");  // BUG de hát ez get ...
                var movies = (await resp.Content.ReadAsAsync<List<movie>>());
                dataGridViewMovies.DataSource = movies;
            }


            // Succesful textbox
            //MessageBox.Show("Sikeres feltöltés");
            String message = "Sikeres feltöltés! \n" +
                            "MovieID: " + movie.MovieID + "\n" +
                            "Name:" + movie.MovieName;

            MessageForParent(message);
            Log.SendEventLog(message);

        }

        private void MessageForParent(String message)
        {
            
            notifyIconForParent.BalloonTipText = message;
            //notifyIconForParent.Text = message;   // Ikon neve
            notifyIconForParent.BalloonTipTitle = "ChildrenDeffender";
            notifyIconForParent.ShowBalloonTip(1000);
        }



        // Módosítás gomb - PUT
        // Hasonló az "static void UpdateV1(int id)"-hoz
        private void btModify_Click(object sender, EventArgs e)
        {

            MovieModify(dataGridViewMovies.CurrentRow);
   

        }

        private async void MovieModify(DataGridViewRow dataGridViewRow)
        {
            //int id = int.Parse(dataGridViewRow.Cells["MovieID"].Value.ToString());
            //Movie modifiedMovie = GetMovie(id);

            movie modifiedMovie = new movie();

            // TODO: lecserélni majd valami objektumosabbra?

            modifiedMovie.MovieID = int.Parse(dataGridViewRow.Cells["MovieID"].Value.ToString());

            modifiedMovie.MovieName = dataGridViewRow.Cells["MovieName"].Value.ToString().Trim(); // végéről leszedi a white space-eket


            // TODO: Lehet, hogy ezekre jobb lenne külön függvény...
            //modifiedMovie.MovieLink = dataGridViewRow.Cells["MovieLink"].Value.ToString();
            var value = dataGridViewRow.Cells["MovieLink"].Value;
            if (value != null)
            {
                modifiedMovie.MovieLink = value.ToString().Trim();
            }

            var linktype = dataGridViewRow.Cells["LinkType"].Value;
            if (linktype != null)
            {
                modifiedMovie.LinkType = linktype.ToString().Trim();
            }
            else
            {
                linktype = "";
            }

            //modifiedMovie.Language = dataGridViewRow.Cells["Language"].Value.ToString();
            var language = dataGridViewRow.Cells["Language"].Value;
            if (language != null)
            {
                modifiedMovie.Language = language.ToString().Trim();
            }

            //modifiedMovie.NameEnglish = dataGridViewRow.Cells["NameEnglish"].Value.ToString();
            var movieNameEnglish = dataGridViewRow.Cells["MovieNameEnglish"].Value;
            if (movieNameEnglish != null)
            {
                modifiedMovie.MovieNameEnglish = movieNameEnglish.ToString().Trim();
            }


            //modifiedMovie.Category = dataGridViewRow.Cells["Category"].Value.ToString();
            var category = dataGridViewRow.Cells["Category"].Value;
            if (category != null)
            {
                modifiedMovie.Category = category.ToString().Trim();
            }

            var minAge = dataGridViewRow.Cells["MinAge"].Value;
            if (minAge != null)
            {
                //modifiedMovie.MinAge = short.Parse(minAge.ToString());

                modifiedMovie.MinAge = (decimal)minAge;

            }


            var favID = dataGridViewRow.Cells["FavID"].Value;
            if (favID != null)
            {
                modifiedMovie.FavID = (int)favID;
            }


            //modifiedMovie.ManyViews  = int.Parse(dataGridViewRow.Cells["ManyViews"].Value.ToString());
            var manyViews = dataGridViewRow.Cells["ManyViews"].Value;
            if ( manyViews != null)
            {
                modifiedMovie.ManyViews = (int)manyViews;
            }
            

            //modifiedMovie.DateAdded = DateTime.Parse(dataGridViewRow.Cells["DateAdded"].Value.ToString());
            var dateAdded = dataGridViewRow.Cells["DateAdded"].Value;
            if ( dateAdded != null)
            {
                modifiedMovie.DateAdded = (DateTime)dateAdded;
            }

            modifiedMovie.DateLastModified = DateTime.Now;


            // MOVIE ÖSSZEÁLLÍTVA


            using (var client = new HttpClient())
            {
                //modifiedMovie.MovieName = "Módosított"; // FOR TEST

                // Async + await kell ?s
                // Mégse, nem ez volt a baj: A Name az rövidebb kell legyen ?????
                await client.PutAsJsonAsync(Config.ApiLink + "Movie/UpdateMovie", modifiedMovie);

                // TODO: BUG: exceptiont dob a savechange-nél - régen, amíg nem figyeltem a name hosszra, ellenőrizni!!!!
                //var resp = client.PutAsJsonAsync(Config.ApiLink + "UpdateMovie", modifiedMovie).Result;                
                //resp.EnsureSuccessStatusCode();


                // Succesful textbox
                //MessageBox.Show("Sikeres módosítás");
                //String message = "Sikeres módosítás: " + movie.MovieID + "\n" +
                //"Name:" + movie.MovieName;
                String message = "Sikeres módosítás!\n" +
                                "MovieID: " + modifiedMovie.MovieID + "\n" +
                                "MovieName: " + modifiedMovie.MovieName;
                MessageForParent(message);
                Log.SendEventLog(message);
            }


        }




        // Egy Movie lekérdezése
        private movie GetMovie(int id)
        {
            using (var client = new HttpClient())   // static volt...
            {
                var resp = client.GetAsync(string.Format(
                    Config.ApiLink + "Movie/{0}", id)).Result;
                resp.EnsureSuccessStatusCode();
                var movie = resp.Content.ReadAsAsync<movie>().Result;
                return movie;
            }
        }


        private void ReadDirForIndexImages()
        {
            ImageList imageListMoviesForParent = new ImageList();
            ListView listViewMoviesForParent = new ListView();

            // READ DIR images

            //string[] filePaths = Directory.GetFiles(@"D:\Minden\Gabika dolgai\ChildrenDeffender\Images\Movies\");
            String[] filePaths = Directory.GetFiles(Config.MovieIndexImagesDir);

            for (int i=0; i<filePaths.Length; i++)
            {
                imageListMoviesForParent.Images.Add(Image.FromFile(filePaths[i]));
                ListViewItem listViewMovie = new ListViewItem();
                listViewMovie.ImageIndex = i;
                listViewMoviesForParent.Items.Add(listViewMovie);
            }

            // TODO: lista mentése adatbázisba?
        }



        private void buttonIndexImagesReadFromDir_Click(object sender, EventArgs e)
        {
            ReadDirForIndexImages();
        }


        private void ReadDirForUploadMovies()
        {
            String Dir = Config.MoviesDir;

            // READ DIR images

            //string[] filePaths = Directory.GetFiles(@"D:\Minden\Gabika dolgai\ChildrenDeffender\Images\Movies\");
            String[] filePaths = Directory.GetFiles(Dir);

            if ( filePaths.Length > 0)
            {
                // Movie lista az átalakításhoz
                List<movie> movies = new List<movie>();

                // String[] --> List<Movie>
                for (int i = 0; i < filePaths.Length; i++)
                {
                    movie movie = new movie();
                    movie.MovieLink = filePaths[i].Remove(0, Config.MoviesDir.Length);  // link elejének leszedése
                    movie.MovieName = movie.MovieLink;                                  // name = link ideiglenesen    

                    //MovieID = 11,
                    movie.MovieID = ChildrenMovies.GetMovieMaxID() + 1 + i;
                    //MovieName = "Micimackó",
                    //movies[i].MovieName = textBoxMovieName.Text,
                    //MovieLink = "C:\\",
                    movie.LinkType = "local";
                    //Language = "HU",
                    //NameEnglish = "Winnie the Pooh",
                    //Category = "állatos",
                    movie.MinAge = 6;
                    movie.ManyViews = 0;
                    movie.DateAdded = DateTime.Now;

                    movies.Add(movie);
                }

                // Checking ???????????
                // TODO:

                // Uploads
                for (int i = 0; i < movies.Count; i++)
                {

                    UploadMovie(movies[i]);
                    
                }

                // After END
                RefreshMovies(); // Refresh // TODO: ez lehet itt? async, mielőtt szívbajt kapnál
                // BUG: nem működik !!!!!!!!!!!!!!!!!!!!!!!!!4

            }


            
        }


        private void RefreshMovies() // TODO: NEM LEHET ASYNC, HA NINCS AWAIT, DE AZ SE LEHET :(
        {
            // REFRESH
            // Movie-k letöltése... és betöltése listView-ba
            ChildrenMovies.GetChildrenMovies(imageListMoviesForParent, listViewMoviesForParent, dataGridViewMovies);

            // Betöltés a dataGridView-be is !
            // dataGridViewMovies.DataSource = ChildrenMovies; // TODO: !!! ITT NEM LEHET.... Átrakva a GetChildrenMovies() függvénybe

            //Console.WriteLine("Movies has been refreshed.");
            Log.SendEventLog("Movies has been refreshed.");
        }


        private async void UploadMovie (movie movie)
        {

            using (var client = new HttpClient())
            {
                // Post
                await client.PostAsJsonAsync(Config.ApiLink + "Movie", movie);

                // Get
                //var resp = await client.GetAsync(Config.ApiLink + "Movie");  // BUG de hát ez get ...
                //var movies = (await resp.Content.ReadAsAsync<List<Movie>>());
                //dataGridViewMovies.DataSource = movies;
            }
        }
  


        private void buttonMovieIndexImagesDir_Click(object sender, EventArgs e)
        {

            // Folder Browser
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            Config.MovieIndexImagesDir = fbd.SelectedPath;
            //
            //string[] files = Directory.GetFiles(fbd.SelectedPath);
            //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            //


            labelMovieIndexImagesDir.Text = fbd.SelectedPath;
        }



        private void buttonReadMovieDir_Click(object sender, EventArgs e)
        {
            ReadDirForUploadMovies();
        }

        private void buttonMovieRefresh_Click(object sender, EventArgs e)
        {
            RefreshMovies();
        }



        private void buttonBack_Click(object sender, EventArgs e)
        {
            ThisFormSwitchToBackForm();
        }



        private void ThisFormSwitchToBackForm()
        {
            this.Hide();
            //FormLogin form = new FormLogin(); // Újat létrehoz
            //form.Show();
            BackForm.Show();

            notifyIconForParent.Visible = false;

        }


        private void buttonExitParent_Click(object sender, EventArgs e)
        {
            notifyIconForParent.Visible = false;        // Exit függvény ???
            Application.Exit();
        }


        private void buttonAddSound_Click(object sender, EventArgs e)
        {
            // TODO: Add Sound
            //System.Media.SoundPlayer();
            /*
            String soundPath = null;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundPath);
            player.Play();
            */

            //();
        }

        /*
        private void RecordSound()
        {

            int waveInDevices = WaveIn.DeviceCount;
            for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);
                Console.WriteLine("Device {0}: {1}, {2} channels",
                    waveInDevice, deviceInfo.ProductName, deviceInfo.Channels);
            }



            WaveIn waveIn = new WaveIn();
            waveIn.DeviceNumber = selectedDevice;
            waveIn.DataAvailable += waveIn_DataAvailable;
            int sampleRate = 8000; // 8 kHz
            int channels = 1; // mono
            waveIn.WaveFormat = new WaveFormat(sampleRate, channels);
            waveIn.StartRecording();
        }
        */

        /*
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
          private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        
        private void RecordSound()
        {
           
            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);
            
            MessageBox.Show("zárd be");
            //Console.WriteLine("recording, press Enter to stop and save ...");
            //Console.ReadLine();

            
            mciSendString("save recsound " + Config.MovieSoundsDir + "name1" + Config.MovieSoundsFormat, "", 0, 0);
            mciSendString("close recsound ", "", 0, 0);

        }
        */


        [DllImport("winmm.dll")]
        private static extern int mciSendString(string MciComando, string MciRetorno, int MciRetornoLeng, int CallBack);
 
        string musica = "";
 
        private void buttonRecord_Click(object sender, EventArgs e)
        {
            labelRecording.Visible = true;
            buttonRecordImage.Visible = true;
            mciSendString("open new type waveaudio alias Som", null, 0, 0);
            mciSendString("record Som", null, 0, 0);
         
        }
 
        private void buttonSave_Click(object sender, EventArgs e)
        {
            labelRecording.Visible = false;
            buttonRecordImage.Visible = false;
            mciSendString("pause Som", null, 0, 0);

            String dir = Config.MovieSoundsDir;
            String fileName =  dataGridViewMovies.CurrentRow.Cells["MovieNameEnglish"].Value.ToString().Trim();
            String format = Config.MovieSoundsFormat;

            String fullPath = dir + fileName + format;

            SaveMCI(fullPath);

            /*
            SaveFileDialog save = new SaveFileDialog();
 
            save.Filter = "wave|*.wav";
 
 
            if (save.ShowDialog() == DialogResult.OK)
            {
                String fileName = save.FileName;
                SaveMCI(fileName);
  
            }
            */
            
            String message = "Hangfájl sikeresen lementve:\n" +
                          fullPath;
            MessageForParent(message);
            Log.SendEventLog(message);
             
        }
 
        private void SaveMCI(String path) 
        {
            mciSendString("save Som \"" + path + "\"", null, 0, 0);
            mciSendString("close Som", null, 0, 0);
        }


        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (musica == "")
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Wave|*.wav";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    musica = open.FileName;
                }
            }
            mciSendString("play \"" + musica + "\"", null, 0, 0);
        }
 
        /*
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
        */

 

        private async void btMovieDelete_Click(object sender, EventArgs e)
        {

            int id;

            id = int.Parse(dataGridViewMovies.CurrentRow.Cells["MovieID"].Value.ToString());

            using (var client = new HttpClient())
            {

                await client.DeleteAsync(string.Format(Config.ApiLink + "Movie/{0}", id));

                //resp.EnsureSuccessStatusCode();
                //var product = resp.Content.ReadAsAsync<Product>().Result;


                // Succesful delete message:
           
                Console.WriteLine("Movie: {0} has been deleted.",id);
                //MessageBox.Show("Sikeres törlés");
                String message = "Sikeres törlés! \n" +
                              "MovieID: " + id;
                MessageForParent(message);
                Log.SendEventLog(message);


                // Refresh
                RefreshMovies();
                
            }
        }


        private void buttonAddIndexImage_Click(object sender, EventArgs e)
        {

            String movieName= textBoxMovieModifyMovieNameEnglish.Text;  // Fontos, hogy az angol név alapján mentünk le képeket...

            String imageNewDir = Config.MovieIndexImagesDir;

            String imageFormat = Config.MovieIndexImagesFormat;

            String imageNewPath = imageNewDir + movieName + imageFormat;


            // Az eredeti, lementésre kerülő fájl:

            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Példa: „Szövegfájlok (*.txt)|*.txt|Minden fájl (*.*)|*.*”
            openFileDialog.Filter = "Jpeg (*" + imageFormat + "|*" + imageFormat;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String imageOriginalPath = openFileDialog.FileName;

                // átmásolni a saját helyünkre ???

                try
                {
                    // Másolás
                    // File.Copy(imageOriginalPath, imageNewPath);    // felülírás nincs engedélyezve
                    File.Copy(imageOriginalPath, imageNewPath, true);       // felülírás engedélyezve
                    
                    // Ha sikeres, üzenet
                    MessageForParent("Image has been added.\r\n" +
                                    imageNewPath);

                    // Ha sikeres, kép betöltése ...
                    pictureBoxSelectedMovieImage.ImageLocation = imageNewPath;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    return;
                }



            }


        }



        /*
        // FELTÖLTÉSES VERZIÓ ... OLD
        
        private void buttonAddIndexImage_Click(object sender, EventArgs e)
        {

        // TODO: Add Image
        String fileName = null;
        
        OpenFileDialog openFileDialog1 = new OpenFileDialog();


        openFileDialog1.InitialDirectory = Config.MovieIndexImagesDir;
        openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
        openFileDialog1.FilterIndex = 2;
        openFileDialog1.RestoreDirectory = true;

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            try
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    using (myStream)
                    {
                        // Insert code to read the stream here.
                    }
                    //filePath = openFileDialog1.FileName;  // full path!!
                    fileName = openFileDialog1.SafeFileName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                return;
            }
        }

        if (fileName != null)
        {
            // new IndexImage
            var indexImage = new IndexImage
            {
                IndexImageID = IndexImages.Max(t => t.IndexImageID) + 1,    // Max + 1
                IndexImageName = fileName,
                Type = "Movie",
                SizeX = 128,
                SizeY = 128,
                IsTransparency = false,
                Version = 1,
                DateAdded = DateTime.Now
            };

            UploadIndexImage(indexImage);

        }

        }



   
        private async void UploadIndexImage ( IndexImage indexImage)
        {
            using (var client = new HttpClient())
            {
                // Post
                await client.PostAsJsonAsync(Config.ApiLink + "IndexImage", indexImage);

                // Get
                ChildrenMovies.LoadMoviesImages(imageList)

            }
        }
        */
        




        private void buttonPlayMovieSound_Click(object sender, EventArgs e)
        {

            var valueEnglishName = dataGridViewMovies.CurrentRow.Cells["MovieNameEnglish"].Value;
            if (valueEnglishName != null)
            {
                String englishName = valueEnglishName.ToString().Trim();

                String soundPath = Config.MovieSoundsDir + englishName + Config.MovieSoundsFormat;

                Common.PlaySound(soundPath);

                // Message
                String message = "Sound played:\n" +
                              soundPath;
                MessageForParent(message);
                Log.SendEventLog(message);
            }
                
        }

        private void buttonRecordImage_Click(object sender, EventArgs e)
        {
            buttonSave_Click(sender,e);
        }

        private void dataGridViewMovies_SelectionChanged(object sender, EventArgs e)
        {

            // EXAMPLE
            //AdressBokPerson currentObject = (AdressBokPerson)dataGridView1.CurrentRow.DataBoundItem;

            //e.RowIndex;
            //Movie movie = (Movie)dataGridViewMovies.Tag;  // WRONG
            //Movie movie = (Movie)dataGridViewMovies.CurrentRow; // WRONG


            // MODE 1  -> object
            //Movie movie = (Movie)dataGridViewMovies.CurrentRow.DataBoundItem;       
            //String movieID = movie.MovieID.ToString();
            //String movieName = movie.MovieName.Trim();

            // MODE 2 - from cells data

            // TODO: átírni Tag-es, mert az idézőjeles... karbantarthatatlanabb kódot eredményez
            String movieID = dataGridViewMovies.CurrentRow.Cells["MovieID"].Value.ToString().Trim();
            String movieName = dataGridViewMovies.CurrentRow.Cells["MovieName"].Value.ToString().Trim();
            //String movieNameEnglish = ((movie)dataGridViewMovies.CurrentRow.Tag).MovieNameEnglish;
            String movieNameEnglish = dataGridViewMovies.CurrentRow.Cells["MovieNameEnglish"].Value.ToString().Trim();

            /*
            // Már nem használt ... TODO: törölni
            // Text
            String labelText = "MovieID: " + movieID + "\n" +
                               "MovieName: " + movieName;

            labelSelectedMovie.Text = labelText;
            */

            textBoxMovieModifyMovieID.Text = movieID;
            textBoxMovieModifyMovieName.Text = movieName;
            textBoxMovieModifyMovieNameEnglish.Text = movieNameEnglish;

            textBoxMovieSoundMovieID.Text = movieID;
            textBoxMovieSoundMovieName.Text = movieName;
            textBoxMovieSoundMovieNameEnglish.Text = movieNameEnglish;

            textBoxMovieImageAddMovieID.Text = movieID;
            textBoxMovieImageAddMovieName.Text = movieName;
            textBoxMovieImageAddMovieNameEnglish.Text = movieNameEnglish;


            pictureBoxSelectedMovieImage.ImageLocation = Config.MovieIndexImagesDir + movieNameEnglish + Config.MovieIndexImagesFormat;

        }

        private void dataGridViewMovies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            MovieParentDataGriedViewChangedRowIndex = e.RowIndex;
            IsRowChanged = true;
        }

        private void dataGridViewMovies_RowLeave(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridViewMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ha az index más, és volt változás, akkor módosítás esemény kiváltása ...
            if ((MovieParentDataGriedViewChangedRowIndex != e.RowIndex) && (IsRowChanged == true))
            {

                MovieModify(dataGridViewMovies.Rows[MovieParentDataGriedViewChangedRowIndex]);
                MovieParentDataGriedViewChangedRowIndex = -1;
                IsRowChanged = false;
            }
        }


        // FOR EXAMPLE, NOT USED
        // https://msdn.microsoft.com/en-us/library/system.windows.forms.control.validating%28v=vs.110%29.aspx?cs-save-lang=1&cs-lang=csharp#code-snippet-2


        private void textBox1_Validating(object sender, 
 				System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(textBoxMovieUploadMovieName.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxMovieUploadMovieName.Select(0, textBoxMovieUploadMovieName.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errorProviderMovieUpload.SetError(textBoxMovieUploadMovieName, errorMsg);
            }
        }


        private void textBox1_Validated(object sender, System.EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProviderMovieUpload.SetError(textBoxMovieUploadMovieName, "");
        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the e-mail address string is not empty. 
            if (emailAddress.Length == 0)
            {
                errorMessage = "e-mail address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "e-mail address must be valid e-mail address format.\n" +
               "For example 'someone@example.com' ";
            return false;
        }


        // END OF MSDN VALIDATING EXAMPLE


        ////////////////////////////////////////////////////////////////////////////


        // from MSDN example ... my Validate for Movie uploading

        private bool ValidMovieName(string inputText, out string errorMessage)
        {

            if (inputText.Length == 0)
            {
                errorMessage = "Movie Name is required";
                return false;
            }
            else if (inputText.Length >= ChildrenMovies.ValidMovieNameMaxLength)
            {
                errorMessage = "Movie Name is too long";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }

        private bool ValidMovieLink(string inputText, out string errorMessage)
        {

            if (inputText.Length == 0)
            {
                errorMessage = "Movie Link is required";
                return false;
            }
            else if (inputText.Length >= ChildrenMovies.ValidMovieNameMaxLength)
            {
                errorMessage = "Movie Link is too long";
                return false;
            }
            else if (!(inputText.IndexOf("\\") > -1) && 
                    !(inputText.IndexOf("http:\\") > -1) &&
                    !(inputText.IndexOf("https:\\") > -1) )
            {
                errorMessage = "There is no \\ for local link or http:\\\\ / http:\\\\ for internet link";
                return false;              
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }

        private bool ValidMovielLinkType(string inputText, out string errorMessage)
        {

            if (inputText.Length == 0)
            {
                errorMessage = "Link type is required";
                return false;
            }
            else if (inputText.Length >= ChildrenMovies.ValidMovieLinkTypeMaxLength)
            {
                errorMessage = "Link type is too long";
                return false;
            }
            else if (!inputText.Equals("youtube") && !inputText.Equals("local"))
            {
                errorMessage = "Link type is only be \"youtube\" or \"local\"";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }



        private void textBoxMovieUploadMovieName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidMovieName(textBoxMovieUploadMovieName.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxMovieUploadMovieName.Select(0, textBoxMovieUploadMovieName.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errorProviderMovieUpload.SetError(textBoxMovieUploadMovieName, errorMsg);
            }

        }

        private void textBoxMovieUploadMovieName_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProviderMovieUpload.SetError(textBoxMovieUploadMovieName, "");
        }


        private void textBoxMovieUploadMovieNameEnglish_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidMovieName(textBoxMovieUploadMovieNameEnglish.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxMovieUploadMovieNameEnglish.Select(0, textBoxMovieUploadMovieNameEnglish.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errorProviderMovieUpload.SetError(textBoxMovieUploadMovieNameEnglish, errorMsg);
            }
        }


        private void textBoxMovieUploadMovieNameEnglish_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProviderMovieUpload.SetError(textBoxMovieUploadMovieNameEnglish, "");
        }


        private void textBoxMovieUploadMovieLink_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidMovieLink(textBoxMovieUploadMovieLink.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxMovieUploadMovieLink.Select(0, textBoxMovieUploadMovieLink.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errorProviderMovieUpload.SetError(textBoxMovieUploadMovieLink, errorMsg);
            }
        }


        private void textBoxMovieUploadMovieLink_Validated(object sender, EventArgs e)
        {   
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProviderMovieUpload.SetError(textBoxMovieUploadMovieLink, "");
        }


        private void textBoxMovieUploadLinkType_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidMovielLinkType(textBoxMovieUploadLinkType.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxMovieUploadLinkType.Select(0, textBoxMovieUploadLinkType.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errorProviderMovieUpload.SetError(textBoxMovieUploadLinkType, errorMsg);
            }
        }


        private void textBoxMovieUploadLinkType_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProviderMovieUpload.SetError(textBoxMovieUploadLinkType, "");
        }


        ////////////////////////////////////////////////////////////////////////////


        // FOR LANGUAGE - combobox ...
        private void comboBoxMovieParentLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Config.Language = comboBoxMovieParentLanguage.SelectedText;
            //SetLanguage(Config.Language);


            if (comboBoxMovieParentLanguage.SelectedIndex == -1)
            return;

            CultureInfo ci = (CultureInfo)comboBoxMovieParentLanguage.SelectedItem;

            if (ci != null)
            {
                Thread.CurrentThread.CurrentUICulture = ci;
                ComponentResourceManager resources = new ComponentResourceManager(this.GetType());
                ApplyResourceToControl(resources, this);

                // Config lementése
                Config.Language = ci.ToString();
                ConfigHandler.SaveConfigsToXML(Config);
                Log.SendEventLog("Config changed (Language). Config has been saved to Config.xml file.");

            }

        }


         private static void ApplyResourceToControl(ComponentResourceManager res, Control control)
        {
            foreach (Control c in control.Controls)
            ApplyResourceToControl(res, c);

            var text = res.GetString(String.Format("{0}.Text", control.Name));
            control.Text = text ?? control.Text;
        }


         /*
         private void comboBoxMovieParentLanguage_SelectedValueChanged(object sender, EventArgs e)
         {

         }
         */

         private void SetLanguage(String language)
         {
             CultureInfo ci = new CultureInfo(language);

             if (ci != null)
             {
                 //CultureInfo ci = (CultureInfo)comboBoxMovieParentLanguage.SelectedItem;
                 Thread.CurrentThread.CurrentUICulture = ci;
             }
             else
             {
                 Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
             }
             
             ComponentResourceManager resources = new ComponentResourceManager(this.GetType());
             ApplyResourceToControl(resources, this);

         }

         private void listViewMoviesForParent_Click(object sender, EventArgs e)
         {
             ListViewItem listViewItem = new ListViewItem();
             listViewItem = listViewMoviesForParent.FocusedItem;    //a kiválasztott elem


             movie movie = new movie();
             movie = (movie)listViewItem.Tag;

             if (movie != null)
             {
                 
                 // az adott image kiírása

                 labelMovieParentSelectedImageMovieID.Text = "MovieID: " + movie.MovieID.ToString();
                 labelMovieParentSelectedImageMovieName.Text = "MovieName: " + movie.MovieName;

                 //ChildrenMovies.ChildrenPlayMovieSound(movie); // lejátszás

             }
             else
             {
                 //labelMovieParentSelectedImageMovieName.Visible = false;

                 // Error log
                 Log.SendErrorLog("There is not found the movie from ListViewMoviesForChildren, index: " +
                     listViewItem.ImageIndex.ToString());
             }


         }

         private void buttonMovieImageChange_Click(object sender, EventArgs e)
         {

         }

         private void listViewMoviesForParent_DoubleClick(object sender, EventArgs e)
         {
             // Hang lejátszása
             MoviePlaySound(listViewMoviesForParent.FocusedItem);
         }

         private void MoviePlaySound(ListViewItem listViewItem)
         {

             //ListViewItem listViewItem = new ListViewItem();
             //listViewItem = listViewMoviesForParent.FocusedItem;

             //int imageID = listViewItem.ImageIndex; // for table...
             movie movie = new movie();
             movie = (movie)listViewItem.Tag;

             if (movie != null)
             {
                 ChildrenMovies.ChildrenPlayMovieSound(movie); // lejátszás
             }
             else
             {      // Error log
                 Log.SendErrorLog("There is not found the movie's sound from ListViewMoviesForChildren, index: " +
                     listViewItem.ImageIndex.ToString());
             }

         }

         private void buttonPlayMovie_Click(object sender, EventArgs e)
         {
             // Film lejátszása
             MoviePlayMovie(listViewMoviesForParent.FocusedItem);

         }

         private void MoviePlayMovie(ListViewItem listViewItem)
         {

             //ListViewItem listViewItem = new ListViewItem();
             //listViewItem = listViewMoviesForParent.FocusedItem;

             //int imageID = listViewItem.ImageIndex; // for table...
             movie movie = new movie();
             movie = (movie)listViewItem.Tag;

             if (movie != null)
             {
                 ChildrenMovies.ChildrenPlayMovie(movie, this); // lejátszás
             }

         }


         private void buttonMoviePlaySound_Click(object sender, EventArgs e)
         {
             MoviePlaySound(listViewMoviesForParent.FocusedItem);
         }
          

        /*
         private void SetLanguage (CultureInfo language)
        {
            if (language.ToString() == "HU")
            {
                CultureInfo newCulture = new CultureInfo("de");
                this.Instance.ChangeCurrentThreadUICulture(newCulture);
                this.Instance.ChangeLanguage(this);
            }
            else if (language.ToString() == "EN")
            {
                CultureInfo newCulture = new CultureInfo("de");
                this.Instance.ChangeCurrentThreadUICulture(newCulture);
                this.Instance.ChangeLanguage(this);
            }
            else if (language.ToString() == "DU")
            {
                
            }
            else
            {

            }
        }
         */

        

        ////////////////////////////////////////////////////////////////////////////



        /*
        private void dataGridViewMovies_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            // EXAMPLE
            //AdressBokPerson currentObject = (AdressBokPerson)dataGridView1.CurrentRow.DataBoundItem;

            //e.RowIndex;
            //Movie movie = (Movie)dataGridViewMovies.Tag;  // WRONG
            //Movie movie = (Movie)dataGridViewMovies.CurrentRow; // WRONG
            Movie movie = (Movie)dataGridViewMovies.CurrentRow.DataBoundItem;

            //String movieID = dataGridViewMovies.CurrentRow.Cells["MovieID"].Value.ToString().Trim();
            //String movieName = dataGridViewMovies.CurrentRow.Cells["MovieName"].Value.ToString().Trim();
            String movieID = movie.MovieID.ToString();
            String movieName = movie.MovieName.Trim();

            String labelText = "MovieID: " + movieID + "\n" +
                                " MovieName: " + movieName;

            labelSelectedMovie.Text = labelText;
        }
        */


    }
}
