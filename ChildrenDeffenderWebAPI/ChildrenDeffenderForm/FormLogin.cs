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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        // TODO: helyette majd más, bejelentkezés
        private void buttonLoginChildren_Click(object sender, EventArgs e)
        {
            //Application.Run(new FormMovieChildren());
            

            Form formNext = new FormMovieChildren();
            formNext.ShowDialog();

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
            //Application.Run(new FormMovieParent());

            Form formNext = new FormMovieParent();
            formNext.ShowDialog();
        }
    }
}
