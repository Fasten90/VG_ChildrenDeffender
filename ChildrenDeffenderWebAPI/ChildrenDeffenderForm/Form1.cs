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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProduct(1);
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
        }
    }
}
