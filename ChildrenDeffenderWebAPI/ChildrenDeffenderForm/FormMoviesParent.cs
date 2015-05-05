﻿using ChildrenDeffenderForm.Model;
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
    public partial class FormMovieParent : Form
    {
        public FormMovieParent()
        {
            InitializeComponent();
        }


        ///*
        // Átcserélni a lentire (1 db betöltése) ha nem jó. KISZEDNI HA NEM JÓ
        private async void FormMovieParent_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var resp = await client.GetAsync("http://localhost:3051/api/Movie");

                var movies = await resp.Content.ReadAsAsync<List<Movie>>();

                dataGridViewMovies.DataSource = movies;
                //var resp = client.GetAsync(string.Format("http://localhost:3051/api/Movie/{0}", id)).Result;
                //resp.EnsureSuccessStatusCode();
                //var movie = resp.Content.ReadAsAsync<Movie>().Result;
                //return movie;   // TODO: Ide érdemes breakpoint-ot tenni ... látni hogy mit kérdezett le
            }
        }
        //*/


       // 
        /*
        private void FormMovieParent_Load(object sender, EventArgs e)
        {

            var movie = GetProduct(1);
            
            dataGridViewMovies.DataSource = movie;
        }


        // WEb Api 2 :: program.cs-be javasolják, de a console application miatt
        static Movie GetProduct(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                var resp = client.GetAsync(string.Format("http://localhost:3051/api/Movie/{0}", id)).Result;
                resp.EnsureSuccessStatusCode();
                var movie = resp.Content.ReadAsAsync<Movie>().Result;
                return movie;   // TODO: Ide érdemes breakpoint-ot tenni ... látni hogy mit kérdezett le
            }
        }//*/


        private async void btUpload_Click(object sender, EventArgs e)
        {
            // new movie
            var movie = new Movie
            {
                //MovieID = 11,
                MovieID = int.Parse(textBoxMovieID.Text),
                //MovieName = "Micimackó",
                MovieName = textBoxMovieName.Text,
                //MovieLink = "C:\\",
                //LinkType = "local",
                //Language = "HU",
                //NameEnglish = "Winnie the Pooh",
                //Category = "állatos",
                MinAge = 6,
                ManyViews  = 0,          
                DateAdded = DateTime.Now
            };


            using (var client = new HttpClient())
            {
                // Post
                await client.PostAsJsonAsync("http://localhost:3051/api/Movie", movie);

                // Get
                var resp = await client.GetAsync("http://localhost:3051/api/Movie");  // BUG de hát ez get ...
                var movies = (await resp.Content.ReadAsAsync<List<Movie>>());
                dataGridViewMovies.DataSource = movies;
            }

            // Succesful textbox
            MessageBox.Show("Sikeres feltöltés");
        }


        // Hasonló az "static void UpdateV1(int id)"-hoz
        private async void btModify_Click(object sender, EventArgs e)
        {

            //int id = int.Parse(dataGridViewMovies.CurrentRow.Cells["MovieID"].Value.ToString());
            //Movie modifiedMovie = GetMovie(id);

            Movie modifiedMovie = new Movie();

            // TODO: lecserélni majd valami objektumosabbra?
            modifiedMovie.MovieID = int.Parse(dataGridViewMovies.CurrentRow.Cells["MovieID"].Value.ToString());

            modifiedMovie.MovieName = dataGridViewMovies.CurrentRow.Cells["MovieName"].Value.ToString().Trim(); // végéről leszedi a white space-eket

            modifiedMovie.MovieLink = dataGridViewMovies.CurrentRow.Cells["MovieLink"].Value.ToString();
            modifiedMovie.LinkType = dataGridViewMovies.CurrentRow.Cells["LinkType"].Value.ToString();
            modifiedMovie.Language = dataGridViewMovies.CurrentRow.Cells["Language"].Value.ToString();
            modifiedMovie.NameEnglish = dataGridViewMovies.CurrentRow.Cells["NameEnglish"].Value.ToString();
            modifiedMovie.Category = dataGridViewMovies.CurrentRow.Cells["Category"].Value.ToString();
            modifiedMovie.MinAge = short.Parse(dataGridViewMovies.CurrentRow.Cells["MinAge"].Value.ToString());
            modifiedMovie.ManyViews  = int.Parse(dataGridViewMovies.CurrentRow.Cells["ManyViews"].Value.ToString());        
            modifiedMovie.DateAdded = DateTime.Parse(dataGridViewMovies.CurrentRow.Cells["DateAdded"].Value.ToString());

            using (var client = new HttpClient())
            {
                //modifiedMovie.MovieName = "Módosított"; // FOR TEST

                // Async + await kell ?
                // Mégse, nem ez volt a baj: A Name az rövidebb kell legyen ?????
                await client.PutAsJsonAsync("http://localhost:3051/api/Movie/UpdateMovie", modifiedMovie);

                // TODO: BUG: exceptiont dob a savechange-nél - régen, amíg nem figyeltem a name hosszra, ellenőrizni!!!!
                //var resp = client.PutAsJsonAsync("http://localhost:3051/api/Movie/UpdateMovie", modifiedMovie).Result;                
                //resp.EnsureSuccessStatusCode();


                // Succesful textbox
                MessageBox.Show("Sikeres módosítás");
            }

        }



        static Movie GetMovie(int id)
        {
            using (var client = new HttpClient())
            {
                var resp = client.GetAsync(string.Format(
                    "http://localhost:3051/api/Movie/{0}", id)).Result;
                resp.EnsureSuccessStatusCode();
                var movie = resp.Content.ReadAsAsync<Movie>().Result;
                return movie;
            }
        }


    }
}
