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



namespace ChildrenDeffenderForm
{
    public partial class FormMoviePlayer : Form
    {
        public FormMoviePlayer()
        {
            InitializeComponent();

            // VLC
            // új ablakban nyitódik meg, ezért nem célszerű innen lejátszani...

            DirectoryInfo vlcLibDirectory = new DirectoryInfo(@"c:\Program Files (x86)\VideoLAN\VLC\");
            VlcMediaPlayer vlcPlayer = new VlcMediaPlayer(vlcLibDirectory);

            // VlcMedia SetMedia(FileInfo file, params string[] options);

            Uri uri = new Uri(@"d:\Minden\Mese\BigHero.avi");
            vlcPlayer.SetMedia(uri,null);
            vlcPlayer.Play();
            vlcPlayer.Pause();

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
