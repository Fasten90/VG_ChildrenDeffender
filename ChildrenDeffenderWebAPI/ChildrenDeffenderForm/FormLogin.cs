using ChildrenDeffenderForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildrenDeffenderForm
{
    public partial class FormLogin : Form
    {

        List<User> LoginUsers;
        String ConfigUserImagesDir = @"D:\Minden\Gabika dolgai\BME\Google Drive\VG\ChildrenDeffender\Images\Users\";

        public FormLogin()
        {
            InitializeComponent();
        }


        // TODO: helyette majd más, bejelentkezés
        private void buttonLoginChildren_Click(object sender, EventArgs e)
        {

            // MEGOLDÁS 2 - új form és a régi elrejtése
            this.Hide();
            FormMovieChildren form = new FormMovieChildren();
            form.Show();


            //// Új ablakban nyitja meg // GOOOOOOOOOOOOOOOOOOOOOOD, de nem a legjobb megoldás
            //Form formNext = new FormMovieChildren();
            //formNext.ShowDialog();


            /*
            objForm1.Visible = False
            objForm2.ShowDialog()

            In Solution Explorer, double-click Form2, and then double-click myButton to open the code window.
            Add the following code to the myButton_click event handler in Form2 class:

            objForm2.Visible = False
            objForm1.Visible = True
            */
        }


        // TODO: helyette majd más, bejelentkezés
        private void buttonLoginParent_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMovieParent form = new FormMovieParent();
            form.Show();

            // Másik megoldás
            //Form formNext = new FormMovieParent();
            //formNext.ShowDialog();


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            GetUsersForLogin();
        }


        private async void GetUsersForLogin()
        {
            using (var client = new HttpClient())
            {
                // Lekérdezés
                var resp1 = await client.GetAsync("http://localhost:3051/api/User");
                var resp2 = await resp1.Content.ReadAsAsync<List<User>>();
                //indeximages.  // TODO: csak a movie jellegűeket?
                LoginUsers = resp2;
                // End of Lekérdezés


                // ListView-be berakás
                String IndexImageFilePath = ConfigUserImagesDir;
                foreach (var item in LoginUsers)
                {
                    /*
                    String path = IndexImageFilePath + item.IndexImageName;
                    imageListMoviesForChildren.Images.Add(Image.FromFile(path));    // TODO: hiányzó képre exceptiont dob, lekezelni
                    ListViewItem listViewMovie = new ListViewItem();
                    listViewMovie.ImageIndex = item.IndexImageID;
                    listViewMoviesForChildren.Items.Add(listViewMovie);
                    */
                }
                // end of ListView

            }



        }



    }
}
