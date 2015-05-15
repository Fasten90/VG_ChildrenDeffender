using ChildrenDeffenderForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        
       //[DllImport("user32.dll",CharSet=CharSet.Auto, CallingConvention=CallingConvention.StdCall)]
        // PInvokeStackImbalance C# call EXCEPTIONT DOBOTT... helyette az alábbi
       [DllImport("user32.dll",CharSet=CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
       public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
       
        //[DllImport("CommonNativeLib.dll", CallingConvention = CallingConvention.Cdecl)]
        //extern "C" __declspec(dllexport) __stdcall int Add(int a, int b) ...
        //public static extern "C" __declspec(dllexport) __stdcall  void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

       private const int MOUSEEVENTF_LEFTDOWN = 0x02;
       private const int MOUSEEVENTF_LEFTUP = 0x04;
       private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
       private const int MOUSEEVENTF_RIGHTUP = 0x10;
        
        private void webBrowserForChildrenMovie_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.Space)
            {
                // Pause
                DoMouseClick();
            }
             */

            switch (e.KeyCode)
            {
                case Keys.Space:
                    DoMouseClick();
                    break;
                case Keys.Down:
                    Common.VolumeDec(this);
                    break;
                case Keys.Up:
                    Common.VolumeInc(this);
                    break;
                case Keys.Escape:
                    ThisFormSwitchToBackForm();
                    break;
                default:
                    return;
                    //break;
            }
            Console.WriteLine("KeyDown {0}",e.KeyCode);


        }

        ///*
       public void DoMouseClick()
       {
          //Call the imported function with the cursor's current position
          //int X = Cursor.Position.X;
          //int Y = Cursor.Position.Y;
           int X = this.Width / 2;
           int Y = this.Height / 2;
            // TODO: BUG: EXCEPTION: PINVOKE EXCEPTION.... 
            //CTRL + ALT + E
            //Under "Managed Debugging Assistants" uncheck PInvokeStackImbalance.
           try
           {
               mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
           }
           catch (Exception e)  // Valamiért exceptiont dob a fenti.......................... TODO: BUG: EXCEPTION
           {
               Console.WriteLine("Mouse event for pause on youtube.");
               Console.WriteLine("Error message: {0}.", e.Message);
           }
        }
        //*/


        /*
        public void DoMouseClick()
        {
            //Create a MouseEventArgs whose Button property is set to the MouseButtons.Right value.
            //Call the OnMouseClick method with this MouseEventArgs as the argument.

            MouseEventArgs mouse = new MouseEventArgs(MouseButtons.Left, 1, this.Width / 2, this.Height / 2,0);

        }
        */




        private void pictureBoxNetBack_DoubleClick(object sender, EventArgs e)
        {
            ThisFormSwitchToBackForm();
        }



        private void ThisFormSwitchToBackForm()
        {
            this.Close();
            //Form form = new Form();   // NEED, IF NEW
            //form.Show();
            backForm.Show();
        }


        private void webBrowserForChildrenMovie_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // TODO:....
        }

        private void FormMovieChildrenNetVideoPlayer_Load(object sender, EventArgs e)
        {
            // FOR FULL SCREEN

            //this.TopMost = true;  // nem kell, tiltja az ALT+TAB-ot

            // first, normal ??? after maximized... ?
            this.WindowState = FormWindowState.Normal;

            // minimize, maximize, close button hide
           
            this.FormBorderStyle = FormBorderStyle.None;

            // max size
            this.WindowState = FormWindowState.Maximized;

            //Activate();

            //this.Bounds = Screen.PrimaryScreen.;

            //this.Bounds = Screen.PrimaryScreen.Bounds;

            
        }


    }
}
