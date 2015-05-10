using ChildrenDeffenderForm.Model;
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

namespace ChildrenDeffenderForm
{
    public partial class FormMovieParent : Form
    {
        ChildrenDeffenderConfig Config;
        List<Movie> Movies;
        List<IndexImage> IndexImages;

        
        public FormMovieParent(ChildrenDeffenderConfig conf)
        {
            InitializeComponent();
            Config = conf;

            labelMovieIndexImagesDir.Text = Config.MovieIndexImagesDir;
            labelMoviesDir.Text = Config.MoviesDir;

        }


        ///*
        // Összes Movie betöltése induláskor
        private void FormMovieParent_Load(object sender, EventArgs e)
        {
            GetMovies();
            GetIndexImagesForParent();
        }

        private async void GetIndexImagesForParent()
        {

            using (var client = new HttpClient())
            {
                // Lekérdezés
                var resp = await client.GetAsync("http://localhost:3051/api/IndexImage");
                var indeximages = await resp.Content.ReadAsAsync<List<IndexImage>>();
                //indeximages.  // TODO: csak a movie jellegűeket?
                IndexImages = indeximages;
                // End of Lekérdezés


                // ListView-be berakás
                String IndexImageFilePath = Config.MovieIndexImagesDir;
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


        private async void GetMovies()
        {
            using (var client = new HttpClient())
            {
                var resp = await client.GetAsync("http://localhost:3051/api/Movie");

                Movies = await resp.Content.ReadAsAsync<List<Movie>>();

                dataGridViewMovies.DataSource = Movies;
                //var resp = client.GetAsync(string.Format("http://localhost:3051/api/Movie/{0}", id)).Result;
                //resp.EnsureSuccessStatusCode();
                //var movie = resp.Content.ReadAsAsync<Movie>().Result;
                //return movie;   // TODO: Ide érdemes breakpoint-ot tenni ... látni hogy mit kérdezett le
            }
        }
        //*/


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
            var movie = new Movie
            {
                //MovieID = 11,
                //MovieID = int.Parse(textBoxMovieID.Text), // Good, but so MAX ID
                MovieID = GetMaxID() + 1,
                //MovieName = "Micimackó",
                MovieName = textBoxMovieName.Text,
                //MovieLink = "C:\\",
                //LinkType = "local",
                //Language = "HU",
                //NameEnglish = "Winnie the Pooh",
                //Category = "állatos",
                MinAge = 6,
                ManyViews  = 0,          
                DateAdded = DateTime.Now
            };


            using (var client = new HttpClient())
            {
                // Post
                await client.PostAsJsonAsync("http://localhost:3051/api/Movie", movie);

                // Get
                var resp = await client.GetAsync("http://localhost:3051/api/Movie");  // BUG de hát ez get ...
                var movies = (await resp.Content.ReadAsAsync<List<Movie>>());
                dataGridViewMovies.DataSource = movies;
            }

            // Succesful textbox
            MessageBox.Show("Sikeres feltöltés");
        }


        // Módosítás gomb - PUT
        // Hasonló az "static void UpdateV1(int id)"-hoz
        private async void btModify_Click(object sender, EventArgs e)
        {

            //int id = int.Parse(dataGridViewMovies.CurrentRow.Cells["MovieID"].Value.ToString());
            //Movie modifiedMovie = GetMovie(id);

            Movie modifiedMovie = new Movie();

            // TODO: lecserélni majd valami objektumosabbra?
            modifiedMovie.MovieID = int.Parse(dataGridViewMovies.CurrentRow.Cells["MovieID"].Value.ToString());

            modifiedMovie.MovieName = dataGridViewMovies.CurrentRow.Cells["MovieName"].Value.ToString().Trim(); // végéről leszedi a white space-eket

            modifiedMovie.MovieLink = dataGridViewMovies.CurrentRow.Cells["MovieLink"].Value.ToString();
            modifiedMovie.LinkType = dataGridViewMovies.CurrentRow.Cells["LinkType"].Value.ToString();
            modifiedMovie.Language = dataGridViewMovies.CurrentRow.Cells["Language"].Value.ToString();
            modifiedMovie.NameEnglish = dataGridViewMovies.CurrentRow.Cells["NameEnglish"].Value.ToString();
            modifiedMovie.Category = dataGridViewMovies.CurrentRow.Cells["Category"].Value.ToString();
            modifiedMovie.MinAge = short.Parse(dataGridViewMovies.CurrentRow.Cells["MinAge"].Value.ToString());
            modifiedMovie.ManyViews  = int.Parse(dataGridViewMovies.CurrentRow.Cells["ManyViews"].Value.ToString());        
            modifiedMovie.DateAdded = DateTime.Parse(dataGridViewMovies.CurrentRow.Cells["DateAdded"].Value.ToString());


            using (var client = new HttpClient())
            {
                //modifiedMovie.MovieName = "Módosított"; // FOR TEST

                // Async + await kell ?s
                // Mégse, nem ez volt a baj: A Name az rövidebb kell legyen ?????
                await client.PutAsJsonAsync("http://localhost:3051/api/Movie/UpdateMovie", modifiedMovie);

                // TODO: BUG: exceptiont dob a savechange-nél - régen, amíg nem figyeltem a name hosszra, ellenőrizni!!!!
                //var resp = client.PutAsJsonAsync("http://localhost:3051/api/Movie/UpdateMovie", modifiedMovie).Result;                
                //resp.EnsureSuccessStatusCode();


                // Succesful textbox
                MessageBox.Show("Sikeres módosítás");
            }

        }



        static Movie GetMovie(int id)
        {
            using (var client = new HttpClient())
            {
                var resp = client.GetAsync(string.Format(
                    "http://localhost:3051/api/Movie/{0}", id)).Result;
                resp.EnsureSuccessStatusCode();
                var movie = resp.Content.ReadAsAsync<Movie>().Result;
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

        private void buttonIndexImageRefresh_Click(object sender, EventArgs e)
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
                List<Movie> movies = new List<Movie>();

                // String[] --> List<Movie>
                for (int i = 0; i < filePaths.Length; i++)
                {
                    Movie movie = new Movie();
                    movie.MovieLink = filePaths[i].Remove(0, Config.MoviesDir.Length);  // link elejének leszedése
                    movie.MovieName = movie.MovieLink;                                  // name = link ideiglenesen    

                    //MovieID = 11,
                    movie.MovieID = GetMaxID() + 1 + i;
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
                GetMovies(); // Refresh // TODO: ez lehet itt? async, mielőtt szívbajt kapnál
                // BUG: nem működik !!!!!!!!!!!!!!!!!!!!!!!!!4

            }


            
        }

        private async void UploadMovie (Movie movie)
        {

            using (var client = new HttpClient())
            {
                // Post
                await client.PostAsJsonAsync("http://localhost:3051/api/Movie", movie);

                // Get
                //var resp = await client.GetAsync("http://localhost:3051/api/Movie");  // BUG de hát ez get ...
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin form = new FormLogin();
            form.Show();
        }

        private void buttonReadMovieDir_Click(object sender, EventArgs e)
        {
            ReadDirForUploadMovies();
        }

        private void buttonMovieRefresh_Click(object sender, EventArgs e)
        {
            GetMovies();
        }

        private int GetMaxID()
        {
            int max = Movies.Max(t => t.MovieID);

            return max;
        }

        private void buttonExitParent_Click(object sender, EventArgs e)
        {
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
            mciSendString("open new type waveaudio alias Som", null, 0, 0);
            mciSendString("record Som", null, 0, 0);
         
        }
 
        private void buttonSave_Click(object sender, EventArgs e)
        {
            labelRecording.Visible = false;
            mciSendString("pause Som", null, 0, 0);

            String dir = Config.MovieSoundsDir;
            String fileName =  dataGridViewMovies.CurrentRow.Cells["NameEnglish"].Value.ToString().Trim();
            String format = Config.MovieSoundsFormat;

            SaveMCI(dir + fileName + format);
            /*
            SaveFileDialog save = new SaveFileDialog();
 
            save.Filter = "wave|*.wav";
 
 
            if (save.ShowDialog() == DialogResult.OK)
            {
                String fileName = save.FileName;
                SaveMCI(fileName);
  
            }
            */
             
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
                if (open.ShowDialog() == DialogResult.OK) { musica = open.FileName; }
            }
            mciSendString("play \"" + musica + "\"", null, 0, 0);
        }
 
        /*
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
        */

        private void buttonAddIndexImage_Click(object sender, EventArgs e)
        {
            // TODO: Add Image

        }


    }
}
