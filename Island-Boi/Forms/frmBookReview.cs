using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name: Danial Suhail
//Date: 26 Jan 2023
//Assignment: ICS3UA Culminating 
//Purpose: To allow user to rate books

namespace Island_Boi.Forms
{
    //Danial--------------------------------------------------------------------------------------------------------
    public partial class frmBookReview : Form
    {
        
        public string[] BookDetails = File.ReadAllLines("BookCheckout.txt"); //Sets a string array called Bookdetals to the BookCheckout.txt file directory that reads each line in that file and sets each as an element.
        public frmBookReview()//This is the main method for the form Book review.
        {
            InitializeComponent();
            lblTitle.Text = BookDetails[0];//Sets the label for title equal to the first element of the BookCheckout.txt file.
            pictureBox_Cover.Image =
                Image.FromStream(typeof(frmBookCheckList).Assembly.GetManifestResourceStream("Island_Boi.Resources." + BookDetails[6]));// sets the picturebox cover to the image that is called what the seventh element of the array is which is the same as checkout.
        }
        
        private void btnStar1_Click(object sender, EventArgs e)//For button star 1 when you click it, the label rating is 1/10.
        {
            lblRating.Text = "1/10";
        }

        private void btnStar2_Click(object sender, EventArgs e)//For button star 2 when you click it, the label rating is 2/10.
        {
            lblRating.Text = "2/10";
        }

        private void btnStar3_Click(object sender, EventArgs e)//For button star 3 when you click it, the label rating is 3/10.
        {
            lblRating.Text = "3/10";
        }

        private void btnStar4_Click(object sender, EventArgs e)//For button star 4 when you click it, the label rating is 4/10.
        {
            lblRating.Text = "4/10";
        }

        private void btnStar5_Click(object sender, EventArgs e)//For button star 5 when you click it, the label rating is 5/10.
        {
            lblRating.Text = "5/10";
        }

        private void btnStar6_Click(object sender, EventArgs e)//For button star 6 when you click it, the label rating is 6/10.
        {
            lblRating.Text = "6/10";
        }

        private void btnStar7_Click(object sender, EventArgs e)//For button star 7 when you click it, the label rating is 7/10.
        {
            lblRating.Text = "7/10";
        }

        private void btnStar8_Click(object sender, EventArgs e)//For button star 8 when you click it, the label rating is 8/10.
        {
            lblRating.Text = "8/10";
        }

        private void btnStar9_Click(object sender, EventArgs e)//For button star 9 when you click it, the label rating is 9/10.
        {
            lblRating.Text = "9/10";
        }

        private void btnStar10_Click(object sender, EventArgs e)//For button star 10 when you click it, the label rating is 10/10.
        {
            lblRating.Text = "10/10";
        }

        private void btnSubmit_Click(object sender, EventArgs e)//If the user clickes the button displayed on the windows form called btnSubmit this method will work.
        {
            string[] Rating = File.ReadAllLines("BookRating.txt");//Sets a string array called Rating that will read all the lines form the book rating.txt file directory and each line is 
            for (int i = 0; i < Rating.Length; i++)//Starts a for loop that chcks for each elemtn of the array Rating.
            {
                if (Rating[i] == "?/10")//for the element correspondent to the i lines it that equals ?/10 it will run the follwoing.
                {
                    Rating[i] = lblRating.Text;//Sets the element to the label Rating.Text.
                    break;//Breaks out of the for loop.
                }
            }
            File.WriteAllLines("BookRating.txt", Rating);//Writes down all new changes done to the file and updates it to be sent to the frmBookList to be updated to those labels.
        }
    }
}
