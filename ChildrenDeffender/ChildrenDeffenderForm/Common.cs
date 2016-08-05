using ChildrenDeffenderDatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildrenDeffenderForm
{
    public static class Common
    {

        public static void PlaySound(String sound)
        {
            try
            {
                if (sound != null)        // TODO - külön függvénybe !!!!!!!!!!!!!!!!!!
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(sound);
                    player.Play();
                }
                else
                {
                    Log.SendErrorLog("Sound parameter is null.");
                }
            }
            catch (Exception e)
            {
                Log.SendErrorLog("Sound playing has been failed. " + e.Message);
            }

        }


        public static bool PlayLocalMovie(movie item, ChildrenDeffenderConfig Config)
        {
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
            try
            {
                System.Diagnostics.Process.Start(command, argument);
                Log.SendEventLog("Movie player successful opened.");
            }
            catch (Exception)
            {

                Log.SendErrorLog("Movie player opening has been failed.");
            }
            

            return true;
        }



        ///*
        // BUG: TODO: GOND: ParentFOrm nem lesz jó, oldForm meg ócsdi megoldás...
        // NEM LEHET helyette a ParenForm-os, mert akkor nem lehet a commonban a függvény...............
        public static bool PlayNetMovie(movie item, Form backForm)
        {

            //String movielink = item.MovieLink;

            backForm.Hide();
            FormMovieChildrenNetVideoPlayer form = new FormMovieChildrenNetVideoPlayer(item,backForm);   //,oldform
            form.Show();

            return true;

        }
        //*/



        // FOR CONTROL VOLUME

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);



        public static void VolumeMute(Form form)
        {
            SendMessageW(form.Handle, WM_APPCOMMAND, form.Handle,
                (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        public static void VolumeDec(Form form)
        {
            SendMessageW(form.Handle, WM_APPCOMMAND, form.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        public static void VolumeInc(Form form)
        {
            SendMessageW(form.Handle, WM_APPCOMMAND, form.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        // END OF FOR CONTROL VOLUME





        internal static void PlayLocalMovieVLC()
        {
            throw new NotImplementedException();
        }
    }
}
