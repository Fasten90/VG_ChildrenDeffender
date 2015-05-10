using ChildrenDeffenderForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildrenDeffenderForm
{
    public partial class FormMovieChildrenNetVideoPlayer : Form
    {
        Form backForm;

        public FormMovieChildrenNetVideoPlayer(Movie movie, Form backForm)
        {
            InitializeComponent();
            LoadVideoPage(movie);
            this.backForm = backForm;
            
        }


        public void LoadVideoPage (Movie movie)
        {
            String link = movie.MovieLink;
            webBrowserForChildrenMovie.Url = new Uri(link); // its ok, but not full screen

            //webBrowserForChildrenMovie.

            //webBrowserForChildrenMovie.Url = new Uri("http://www.youtube.com");   // FOR TEST

        }

        public void CreateWebPageForPlaying (Movie movie)
        {
            //<iframe width="420" height="315" src="https://www.youtube.com/embed/2ATBSX2rd-g" frameborder="0" allowfullscreen></iframe>


        }

        private void webBrowserForChildrenMovie_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if ( e.KeyCode == Keys.Space )
            {
                // Pause
            }

        }

        private void pictureBoxNetBack_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
            //Form form = new Form();   // NEED, IF NEW
            //form.Show();
            backForm.Show();
            
        }


    }
}
