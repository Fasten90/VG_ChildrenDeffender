using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenDeffenderForm
{
    class ChildrenMovies
    {

        //List<Movie> ChildrenMovies;

        
        /*
        private void LoadIndexImagesForChildren()
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
            /*
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
                    Console.WriteLine("Cannot load MovieID={0}. image.", item.IndexImageID);
                    Console.WriteLine("Error message: {0}.", e.Message);
                }

            }
            // end of ListView
        }
        */

    }
}
