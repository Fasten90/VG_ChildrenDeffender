using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenDeffenderForm
{
    public  class ChildrenDeffenderConfig
    {

        // variables for Config

        // Standards

        public String Language = "en";

        public String ApiLink = "http://childrendeffender.azurewebsites.net/Api/";      // For Azure version
        //public String ApiLink = "http://localhost:3581/api/";                         // For last local version
        //public String ApiLink = "http://localhost:3306/api/";
        //public String ApiLink = "http://localhost:3051/api/"; // old version, For MS SQL

        // Important - Movie dir, Movie player
        public String MoviesDir = @"D:\Minden\Mese\"; // TODO: ez legyen lista ??
        public String MoviePlayer = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";


        // Images
        public String MovieIndexImagesDir = @"D:\Minden\Gabika dolgai\BME\Google Drive\VG\ChildrenDeffender\Images\Movies\";
        public String UserImagesDir = @"D:\Minden\Gabika dolgai\BME\Google Drive\VG\ChildrenDeffender\Images\Users\";
        public String MovieIndexImagesFormat = ".jpg";
        public String UserIndexImagesFormat = ".jpg";

        // sounds dir
        public String MovieSoundsDir = @"D:\Minden\Gabika dolgai\BME\Google Drive\VG\ChildrenDeffender\Sounds\Movies\";
        public String MovieSoundsFormat = ".wav";
        public String UserSoundsDir = @"D:\Minden\Gabika dolgai\BME\Google Drive\VG\ChildrenDeffender\Sounds\Users\";
        public String UserSoundsFormat = ".wav";


        // Menu sounds
        public String SoundMenuExit = @"D:\Minden\Gabika dolgai\BME\Google Drive\VG\ChildrenDeffender\Sounds\Menu\Exit.wav";
        public String SoundMenuBack = @"D:\Minden\Gabika dolgai\BME\Google Drive\VG\ChildrenDeffender\Sounds\Menu\Back.wav";
        public String SoundMenuWelcome = @"D:\Minden\Gabika dolgai\BME\Google Drive\VG\ChildrenDeffender\Sounds\Menu\Welcome.wav";
        public String SoundThereIsNoVideo = @"D:\Minden\Gabika dolgai\BME\Google Drive\VG\ChildrenDeffender\Sounds\Menu\NoVideo.wav";

    }


}
