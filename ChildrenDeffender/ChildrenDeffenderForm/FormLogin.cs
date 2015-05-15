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

        public List<User> LoginUsers;

        public ChildrenDeffenderConfig Config;

        //public ConfigHandler TheConfigHandler;

        //public static ChildrenDeffenderConfig Config;

        //public Config ChildrenDeffenderConfigs;



        public FormLogin()
        {
            InitializeComponent();
        }


        // TODO: helyette majd más, bejelentkezés
        private void buttonLoginChildren_Click(object sender, EventArgs e)
        {

            // MEGOLDÁS 2 - új form és a régi elrejtése
            this.Hide();
            FormMovieChildren form = new FormMovieChildren(Config);
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
            FormMovieParent form = new FormMovieParent(Config);
            form.Show();

            // Másik megoldás
            //Form formNext = new FormMovieParent();
            //formNext.ShowDialog();


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            GetUsersForLogin();

            Config = new ChildrenDeffenderConfig();
            ConfigHandler handler = new ConfigHandler();

            if (handler.LoadConfigsFromXML(Config))
            {   // Ha sikerült betölteni a config fájlt
                Console.WriteLine("Config.xml has been loaded.");
            }
            else
            {   // Ha nem sikerült betölteni a config fájlt
                Console.WriteLine("Cannot load Config.xml, loaded standard values.");
                MessageBox.Show("Hiányzó \"Config.xml\" fájl! Alapértelmezett config adatok betöltve és lementve.");
                handler.SaveConfigsToXML(Config);
            }

            Common.PlaySound(Config.SoundMenuWelcome);
             
        }


        private async void GetUsersForLogin()
        {
            using (var client = new HttpClient())
            {
                bool success;
                try
                { 
                    // Lekérdezés
                    var resp1 = await client.GetAsync("http://localhost:3051/api/User");
                    var resp2 = await resp1.Content.ReadAsAsync<List<User>>();
               
                    LoginUsers = resp2;
                    // End of Lekérdezés

                    success = true;
                    
                    
                }
                catch (Exception e )
                {
                    //LoadUsersFromXml();
                    Console.WriteLine("Error message: {0}.", e.Message);
                    success = false;
                }

                if (success)
                {
                    SaveUsersToXml();

                }
                else
                {
                    LoadUsersFromXml();
                }
                
                

                // ListView-be berakás
                String IndexImageFilePath = Config.UserImagesDir;
                int i = 0;
                foreach (var item in LoginUsers)
                {
                    ///*
                    String path = IndexImageFilePath + item.IndexImageName;
                    imageListUsersForLogin.Images.Add(Image.FromFile(path));    // TODO: hiányzó képre exceptiont dob, lekezelni
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.ImageIndex = i;
                    listViewUsersForLogin.Items.Add(listViewItem);
                    i++;
                    //*/
                }
                // end of ListView



            }



        }

        private void listViewUsersForLogin_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            ListViewItem listViewItem = new ListViewItem();
            listViewItem = listViewUsersForLogin.FocusedItem;

            int userID = listViewItem.ImageIndex;
            // TODO: értelmesebben kinyerni az ID-t !!!!!!!!!!!!!!4


            //ChildrenMovies.Find()
            foreach (var item in LoginUsers)
            {
                if (item.UserID == userID)
                {
                    String profilType = item.ProfilType.Trim();
                    if (profilType == "Child")
                    {
                        FormSwitchToChildrenForm();
                        break;
                    }
                    else if (profilType == "Admin" || profilType == "Parent")
                    {
                        FormSwitchToParentForm();
                        break;
                    }
                    
                }
            }

        }

        private void FormSwitchToChildrenForm ()
        {
            this.Hide();
            FormMovieChildren form = new FormMovieChildren(Config);
            form.Show();
        }
        private void FormSwitchToParentForm ()
        {
            this.Hide();
            FormMovieParent form = new FormMovieParent(Config);
            form.Show();
        }

        private void listViewUsersForLogin_MouseClick(object sender, MouseEventArgs e)
        {

            ListViewItem listViewItem = new ListViewItem();
            listViewItem = listViewUsersForLogin.FocusedItem;

            int userID = listViewItem.ImageIndex;
            // TODO: értelmesebben kinyerni az ID-t !!!!!!!!!!!!!!


            foreach (var item in LoginUsers)
            {
                if (item.UserID == userID)
                {
                    String soundFileDir = Config.UserSoundsDir;

                    //String soundFileName = item.SoundFileName;    // TODO: sound paraméter vagy name paraméter?
                    String soundFileName = item.UserName;

                    if ( soundFileName != null )
                    {
                        soundFileName = soundFileName.Trim() + Config.UserSoundsFormat;
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundFileDir + soundFileName);
                        player.Play();
                        break;
                    }

                }
            }

        }

        private void pictureBoxLoginExit_Click(object sender, EventArgs e)
        {
            // TODO: Exit Sound
            Common.PlaySound(Config.SoundMenuExit);
        }

        private void pictureBoxLoginExit_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void LoadUsersFromXml()
        {

            // Then in some other function.
            //Person person = XmlSerialization.ReadFromXmlFile<Person>("C:\person.txt");
            //List<Person> people = XmlSerialization.ReadFromXmlFile<List<Person>>("C:\people.txt");
            LoginUsers = XmlSerialization.ReadFromXmlFile<List<User>>("Users.xml");

        }

        private void SaveUsersToXml()
        {
            // And then in some function.
            //Person person = new Person() { Name = "Dan", Age = 30; HomeAddress = new Address() { StreetAddress = "123 My St", City = "Regina" }};
            //List<Person> people = GetListOfPeople();
            //XmlSerialization.WriteToXmlFile<Person>("C:\person.txt", person);
            //XmlSerialization.WriteToXmlFile<List<People>>("C:\people.txt", people);
            XmlSerialization.WriteToXmlFile<List<User>>("Users.xml", LoginUsers);
        }

    }
}
