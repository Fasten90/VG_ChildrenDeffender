using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc;
using Vlc.DotNet.Forms;
using Vlc.DotNet.Core;
using System.IO;
using ChildrenDeffenderDatabaseModel;



namespace ChildrenDeffenderForm
{
    public partial class FormMoviePlayer : Form
    {
            
        private movie movie;
        private ChildrenDeffenderConfig Config;
        private Form BackForm;

        Vlc.DotNet.Forms.VlcControl vlcControl;


        public FormMoviePlayer()    // NOT USED ????????????? TODO: delete
        {
            InitializeComponent();
        }



        public FormMoviePlayer(movie movie, ChildrenDeffenderConfig config, Form backForm)
        {
            InitializeComponent();


            // TODO: Complete member initialization
            this.movie = movie;
            this.Config = config;
            this.BackForm = backForm;

            this.BackForm.Hide();
            this.Show();


            String filePath = Config.MoviesDir + movie.MovieLink.Trim();


            // My version ...   // VlcPlayer
            //PlayMediaV0(filePath);

            // My version ... // VlcControl
            PlayMediaVlcControl(filePath);
            
            // Other version
            //PlayMedia(filePath);
            
        }




        /*
        private void PlayMediaV0(String fileName)
        {

            // VLC
            // WORK, BUT: új ablakban nyitódik meg, ezért nem célszerű innen lejátszani...

            DirectoryInfo vlcLibDirectory = new DirectoryInfo(@"c:\Program Files (x86)\VideoLAN\VLC\");
            VlcMediaPlayer vlcPlayer = new VlcMediaPlayer(vlcLibDirectory);

            // VlcMedia SetMedia(FileInfo file, params string[] options);

            //Uri uri = new Uri(@"d:\Minden\Mese\BigHero.avi");
            Uri uri = new Uri(fileName);       
            vlcPlayer.SetMedia(uri,null);

            vlcPlayer.Play();
            vlcPlayer.Pause();

        }
        */

        /*
        VlcContext.LibVlcDllsPath = CommonStrings.LIBVLC_DLLS_PATH_DEFAULT_VALUE_AMD64;
        VlcContext.LibVlcPluginsPath = CommonStrings.PLUGINS_PATH_DEFAULT_VALUE_AMD64;

        VlcContext.StartupOptions.IgnoreConfig = true;
        VlcContext.StartupOptions.LogOptions.LogInFile = true;
        VlcContext.StartupOptions.LogOptions.ShowLoggerConsole = true;
        VlcContext.StartupOptions.LogOptions.Verbosity = VlcLogVerbosities.Debug;

        VlcContext.Initialize();
         */

        private void PlayMediaVlcControl(String fileName)
        {

 
            //DirectoryInfo vlcLibDirectory = new DirectoryInfo(@"c:\Program Files (x86)\VideoLAN\VLC\");
            DirectoryInfo vlcLibDirectory = new DirectoryInfo(@"vlc\x86\");
            // TODO: !!IMPORTANT!! NINCS DLL hiba, mióta a native csomagot linkelem...

            //VlcMediaPlayer vlcPlayer = new VlcMediaPlayer(vlcLibDirectory);

            Uri uri = new Uri(fileName);


            vlcControl = new Vlc.DotNet.Forms.VlcControl();


            vlcControl.VlcLibDirectory = vlcLibDirectory;


            vlcControl.CreateControl();
            vlcControl.Dock = DockStyle.Fill;


            try     // TODO: try-catch nem segített a DLL hibán
            {
                // FULL SCREEN
                this.WindowState = FormWindowState.Normal;

                // minimize, maximize, close button hide
           
                this.FormBorderStyle = FormBorderStyle.None;

                // max size
                this.WindowState = FormWindowState.Maximized;



                // Play()
                // uri / fileinfo lehet az első paraméter (=mit játszon le)
                // 2. paraméter: options
                vlcControl.Play(uri, null);
                //vlcControl.Play(uri, "-fullscreen"); // TODO: Full screen ... nem működik
                // TODO: DLL hibákkal inicializálódik a VlcControl... megnézni


            }
            catch (Exception e)
            {
                Log.SendErrorLog("VlcControl.Play() hiba");
                Log.SendErrorLog(e.Message);
            }


            this.panelVideo.Controls.Add(vlcControl);       //panelVideo is main container panel.



            if (vlcControl != null)
            {
                //Media2Play = new Vlc.DotNet.Core.Medias.PathMedia(fileName);
                //vlcControl.Media = Media2Play;
                
                vlcControl.Show();
                //vlcControl.Play(uri, null);
                //vlcControl.Controls.Add(panelDoubleClick);
            }
            else
            {
                Log.SendErrorLog("VlcControl failed. Cannot play video.");
            }


        }
        // End of PlayMediaVlcControl();



        // http://stackoverflow.com/questions/24799178/c-sharp-vlc-player-mouse-double-click-event
        //Vlc.DotNet.Core.VlcMedia media;
        //Medias.PathMedia Media2Play;
        public void PlayMedia(string fileName)
        {

            //if (Vlc.DotNet.Core.VlcContext.IsInitialized == false)
                initVLC();

            //StopVLC();

            //Panel1: "panelVideo" holds "Vlc.DotNet.Forms.VlcControl"
            //Panel2: "panelDoubleClick" created  at runtime and "vlcControl.Controls.Add(panelDoubleClick);" 
            //Panel2: panelDoubleClick.BackColor = Color.Transparent;
            //panelDoubleClick.MouseDoubleClick += panelDoubleClick_MouseDoubleClick;


 
            //this.panelVideo.Controls.Add(vlcControl);       //panelVideo is main container panel.
            //initEvents();//VLC player events


            Panel panelDoubleClick = new Panel();// this panel requires to catche double click evetns.
            panelDoubleClick.Dock = DockStyle.Fill;
            panelDoubleClick.BackColor = Color.Transparent;
            panelDoubleClick.MouseDoubleClick += new MouseEventHandler(panelDoubleClick_MouseDoubleClick);

            if (vlcControl != null)
            {
                //Media2Play = new Vlc.DotNet.Core.Medias.PathMedia(fileName);
                //vlcControl.Media = Media2Play;
                Uri uri = new Uri(@"d:\Minden\Mese\BigHero.avi");
                vlcControl.Show();
                vlcControl.Play(uri, null);
                vlcControl.Controls.Add(panelDoubleClick);
                panelDoubleClick.BringToFront();
            }

        }


        private void panelDoubleClick_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           MessageBox.Show  ("ToggleFullScreen();");
        }


        private void initVLC()
        {

            try
            {
                // Set libvlc.dll and libvlccore.dll directory path
                string vlcPath = "";

                vlcPath = "E:\\VLC\\VLC_minimal";

                if (System.IO.Directory.Exists(vlcPath) == false)
                {
                    vlcPath = Application.StartupPath.Trim('\\') + "\\VLC\\";
                    if (System.IO.Directory.Exists(vlcPath) == false)
                    {
                        if (Environment.Is64BitOperatingSystem)
                        {
                            vlcPath = "C:\\Program Files (x86)\\VideoLAN\\VLC";
                        }
                        else
                        {
                            vlcPath = "C:\\Program Files\\VideoLAN\\VLC";
                        }
                        if (System.IO.Directory.Exists(vlcPath) == false)
                        {
                            MessageBox.Show("VLC cannot be fount on your system.");
                            Application.Exit();
                            return;
                        }
                    }
                }

                DirectoryInfo vlcLibDirectory = new DirectoryInfo(@"c:\Program Files (x86)\VideoLAN\VLC\");
                //VlcMediaPlayer vlcPlayer = new VlcMediaPlayer(vlcLibDirectory); // ez rossz???

                vlcControl = new Vlc.DotNet.Forms.VlcControl();
                vlcControl.CreateControl();
                vlcControl.Dock = DockStyle.Fill;

                vlcControl.VlcLibDirectory = vlcLibDirectory;

                //Vlc.DotNet.Core.VlcContext.LibVlcDllsPath = vlcPath;

               /*
                // CommonStrings.LIBVLC_DLLS_PATH_DEFAULT_VALUE_AMD64;

                // Set the vlc plugins directory path
                //Vlc.DotNet.Core.LibVlcPluginsPath = Vlc.DotNet.Core.VlcContext.LibVlcDllsPath + "\\pugins";
                //CommonStrings.PLUGINS_PATH_DEFAULT_VALUE_AMD64;

                // Ignore the VLC configuration file
                //Vlc.DotNet.Core.VlcContext.StartupOptions.IgnoreConfig = true;

                // Enable file based logging
                Vlc.DotNet.Core.VlcContext.StartupOptions.LogOptions.LogInFile = false;

                // Shows the VLC log console (in addition to the applications window)
                Vlc.DotNet.Core.VlcContext.StartupOptions.LogOptions.ShowLoggerConsole = false;

                // Set the log level for the VLC instance
                Vlc.DotNet.Core.VlcContext.StartupOptions.LogOptions.Verbosity = Vlc.DotNet.Core.VlcLogVerbosities.None;

                Vlc.DotNet.Core.VlcContext.StartupOptions.ScreenSaverEnabled = false;
                Vlc.DotNet.Core.VlcContext.StartupOptions.AddOption("--no-video-title");
                //hide played media filename on startingto play media.

                // Initialize the VlcContext
                Vlc.DotNet.Core.VlcContext.Initialize();
                */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void panelVideo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //KeyHandler((KeyEventArgs)e);
        }


        private void FormMoviePlayer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            //KeyHandler((KeyEventArgs)e);

        }


        private void FormMoviePlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //KeyHandler((KeyEventArgs)e);
        }


        private void FormMoviePlayer_KeyDown(object sender, KeyEventArgs e)
        {
            KeyHandler(e);
        }


        private void KeyHandler(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    MoviePause();
                    break;
                case Keys.Down:
                    Common.VolumeDec(this);
                    break;
                case Keys.Up:
                    Common.VolumeInc(this);
                    break;
                case Keys.Escape:
                    ThisFormSwitchToBackForm();
                    break;
                default:
                    return;
                //break;
            }
            Console.WriteLine("KeyDown {0}", e.KeyCode);
        }



        private void MoviePause()
        {  
            if (vlcControl.IsPlaying)
            {
                vlcControl.Pause();
            }
            else
            {
                vlcControl.Play();
            }
        }

        private void ThisFormSwitchToBackForm()
        {
            try
            {
                vlcControl.Stop();
                this.Close();
                BackForm.Show();
            }
            catch (Exception e)
            {
                Log.SendErrorLog("Vlc closing with error.");
                Log.SendErrorLog(e.Message);
            }

        }






        /*
        // EXAMPLE CODE FROM: http://vlcdotnet.codeplex.com/wikipage?title=Forms
        void VlcPluginLoad ()
        {
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
        }
        */



    }
}
