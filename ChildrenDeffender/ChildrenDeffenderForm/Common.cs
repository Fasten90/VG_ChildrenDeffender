using ChildrenDeffenderForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildrenDeffenderForm
{
    public static class Common
    {

        public static void PlaySound(String sound)
        {

            if (sound != null)        // TODO - külön függvénybe !!!!!!!!!!!!!!!!!!
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(sound);
                player.Play();
            }

        }


        public static bool PlayLocalMovie(Movie item, ChildrenDeffenderConfig Config)
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
            System.Diagnostics.Process.Start(command, argument);

            return true;
        }


        public static bool PlayNetMovie(Movie item, Form oldform)
        {

            //String movielink = item.MovieLink;

            oldform.Hide();
            FormMovieChildrenNetVideoPlayer form = new FormMovieChildrenNetVideoPlayer(item,oldform);
            form.Show();


            return true;

        }





    }
}
