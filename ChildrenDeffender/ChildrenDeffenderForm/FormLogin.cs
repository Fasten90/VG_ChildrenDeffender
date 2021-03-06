﻿using ChildrenDeffenderDatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        public List<user> LoginUsers;

        public ChildrenDeffenderConfig Config;

        private ConfigHandler configHandler;

        //LogClass Log;

        //public ConfigHandler TheConfigHandler;

        //public static ChildrenDeffenderConfig Config;

        //public Config ChildrenDeffenderConfigs;



        public FormLogin()
        {
            InitializeComponent();
            //Log = new LogClass();

        }


        // TODO: helyette majd más, bejelentkezés
        private void buttonLoginChildren_Click(object sender, EventArgs e)
        {

            // MEGOLDÁS 2 - új form és a régi elrejtése
            this.Hide();
            FormMovieChildren form = new FormMovieChildren(Config, this);
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
            FormMovieParent form = new FormMovieParent(Config, configHandler, this); 
            form.Show();

            // Másik megoldás
            //Form formNext = new FormMovieParent();
            //formNext.ShowDialog();


        }



		// 
        private void FormLogin_Load(object sender, EventArgs e)
        {
            
            // Configs
            //Config = new ChildrenDeffenderConfig();   // lokális, ez nekünk nem jó...
            configHandler = new ConfigHandler();

            Config = configHandler.LoadConfigsFromXML(Config);   // Config beállítása / betöltése

            if ( Config != null )
            {   // Ha sikerült betölteni a config fájlt
                //Console.WriteLine("Config has been loaded.");
                Log.SendEventLog("Config has been loaded.");
            }
            else
            {   // Ha nem sikerült betölteni a config fájlt
                //Console.WriteLine("Cannot load Config.xml, loaded standard values.");
                //EventLogger.WriteLine("Cannot load Config.xml, loaded standard values.");
                Log.SendErrorLog("Cannot load Config.xml, loaded standard values.");
                MessageBox.Show("Hiányzó \"Config.xml\" fájl! Alapértelmezett config adatok betöltve és lementve.");
                Config = new ChildrenDeffenderConfig();
                configHandler.SaveConfigsToXML(Config);
            }


            // Get Users
            GetUsersForLogin();


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
                    var resp1 = await client.GetAsync(Config.ApiLink + "User");
                    var resp2 = await resp1.Content.ReadAsAsync<List<user>>();
               
                    LoginUsers = resp2;
                    // End of Lekérdezés

                    success = true;
                    Log.SendEventLog("Users has been downloaded.");
                    
                    
                }
                catch (Exception e )
                {
                    //LoadUsersFromXml();
                    //Console.WriteLine("Error message: {0}.", e.Message);
                    Log.SendErrorLog("Error message: " + e.Message);
                    success = false;
                }



                if (success)
                {
                    try
                    {
                        SaveUsersToXml();
                        Log.SendEventLog("Users save has been succesful.");
                    }
                    catch (Exception e)
                    {
                        Log.SendErrorLog("Users saving is unsuccesful: " + e.Message);
                    }
                    
                }
                else
                {                 
                    try
                    {
                        LoadUsersFromXml();
                        Log.SendEventLog("Users loading has been succesful.");
                    }
                    catch (Exception e)
                    {
                        Log.SendErrorLog("Users loading is unsuccesful: " + e.Message);
                    }
                }
                
                

                // ListView-be berakás
                String IndexImageFilePath = Config.UserImagesDir;
                int i = 0;
                foreach (var item in LoginUsers)
                {
                    String path = IndexImageFilePath + item.UserName.Trim() + Config.UserIndexImagesFormat;

                    try
                    {
                        imageListUsersForLogin.Images.Add(Image.FromFile(path));    // TODO: hiányzó képre exceptiont dob, lekezelni
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.ImageIndex = i;
                        listViewItem.Tag = item;                   // AZONOSÍTÓ !!!!!!!!!
                        listViewUsersForLogin.Items.Add(listViewItem);
                        i++;
                    }
                    catch (Exception e)
                    {
                        Log.SendErrorLog("User image loading has been failed. Image path: " + path
                                          + "ErrorMessage: " + e.Message);
                    }
                    
                    
                }
                // end of ListView

            }

        }



        private void listViewUsersForLogin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem = listViewUsersForLogin.FocusedItem;

            user user = new user();
            user = (user)listViewItem.Tag;

            if (user != null)
            {
                UserLogin(user);
            }
            else
            {      // Error log
                Log.SendErrorLog("There is not found the user from listViewUsersForLogin, index: " +
                    listViewItem.ImageIndex);
            }

            /*
            // TODO: Működő kód volt, de nem elegánsan nyeri ki az ID-t
            ListViewItem listViewItem = new ListViewItem();
            listViewItem = listViewUsersForLogin.FocusedItem;

            int userID = listViewItem.ImageIndex;


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
            */

        }

        private void UserLogin(user user)
        {
            //if (user.UserID != null)
            //{
                String profilType = user.ProfilType.Trim();
                if (profilType == "Child")
                {
                    FormSwitchToChildrenForm();
                    return;
                }
                else if (profilType == "Admin" || profilType == "Parent")
                {
                    FormSwitchToParentForm();
                    return;
                }

            //}
        }

        private void FormSwitchToChildrenForm ()
        {
            this.Hide();
            FormMovieChildren form = new FormMovieChildren(Config, this); //
            form.Show();
        }
        private void FormSwitchToParentForm ()
        {
            this.Hide();
            FormMovieParent form = new FormMovieParent(Config, configHandler, this); // 
            form.Show();
        }

        private void listViewUsersForLogin_MouseClick(object sender, MouseEventArgs e)
        {

            ListViewItem listViewItem = new ListViewItem();
            listViewItem = listViewUsersForLogin.FocusedItem;

            user user = new user();
            user = (user)listViewItem.Tag;

            if (user != null)
            {
                PlayLoginUserSound(user);
            }
            else
            {      // Error log
                Log.SendErrorLog("There is not found the user from listViewUsersForLogin, index: " +
                    listViewItem.ImageIndex + "\t" +
                    "User Name:" + user.UserID +
                    "User Name: " + user.UserName);
            }



            // Működő kód volt, de Index kinyeréssel szerzi meg a user-t és a hangját, ami elcsúszásokat okozhat...
            // Helyette a fenti listViewItem.Tag-os verzió ajánlott...
            /*
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
            */

        }

        private void PlayLoginUserSound(user user)
        {
            String soundFileDir = Config.UserSoundsDir;

            //String soundFileName = item.SoundFileName;    // TODO: sound paraméter vagy name paraméter?
            String soundFileName = user.UserName;

            String soundFormat = Config.UserSoundsFormat;

            String soundFullPath;

            if (soundFileName != null)
            {
                soundFileName = soundFileName.Trim();
                soundFullPath = soundFileDir + soundFileName + soundFormat;

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundFullPath);
                try
                {
                    player.Play();
                }
                catch (Exception e)
                {
                    Log.SendErrorLog("Cannot found and played this User Sound: " + soundFullPath + "  ErrorMessage: " +  e.Message);
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
            LoginUsers = XmlSerialization.ReadFromXmlFile<List<user>>("Users.xml");
            Log.SendEventLog("Users.xml file loaded succesful.");

        }

        private void SaveUsersToXml()
        {
            // And then in some function.
            //Person person = new Person() { Name = "Dan", Age = 30; HomeAddress = new Address() { StreetAddress = "123 My St", City = "Regina" }};
            //List<Person> people = GetListOfPeople();
            //XmlSerialization.WriteToXmlFile<Person>("C:\person.txt", person);
            //XmlSerialization.WriteToXmlFile<List<People>>("C:\people.txt", people);
            XmlSerialization.WriteToXmlFile<List<user>>("Users.xml", LoginUsers);
            Log.SendEventLog("Users.xml file saved succesful.");
        }

    }
}
