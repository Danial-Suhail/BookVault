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
    public partial class frmBookList : Form
    {
        //Danial Suhail-------------------------------------------------------------------------------------------------------

        public frmBookList()
        {
            InitializeComponent();

            //Danial's Code Start
            string[] Books = File.ReadAllLines("BookFile.txt");//This creates a string array that reads all the lines from the bookfile.txt file directory.
            for (int i = 0; i < Books.Length; i++)//starts a for loop that sets it for each value in the books array that increments till completion.
            {
                if (Books[i] == "Unavailable")//If the string in a line is equal to not available it will continue with the following 
                {
                    
                    if (i == 2)//Starting at index 2 or element 3 which is line 3 it will set the lbl quantity to 1.
                    {
                        lblQuantity1.Text = "0";
                    }
                    else if (i == 6)//Adds four lines till the next quantity which will set the lbl quantity2 to 1.
                    {
                        lblQuantity2.Text = "0";
                    }
                    else if (i == 10)//Adds four lines till the next quantity which will set the lbl quantity3 to 1.
                    {
                        lblQuantity3.Text = "0";
                    }
                    else if (i == 14)//Adds four lines till the next quantity which will set the lbl quantity4 to 1.
                    {
                        lblQuantity4.Text = "0";
                    }
                    else if (i == 18)//Adds four lines till the next quantity which will set the lbl quantity5 to 1.
                    {
                        lblQuantity5.Text = "0";
                    }
                    else if (i == 22)//Adds four lines till the next quantity which will set the lbl quantity6 to 1.
                    {
                        lblQuantity6.Text = "0";
                    }
                    else if (i == 26)//Adds four lines till the next quantity which will set the lbl quantity7 to 1.
                    {
                        lblQuantity7.Text = "0";
                    }
                    else if (i == 30)//Adds four lines till the next quantity which will set the lbl quantity8 to 1.
                    {
                        lblQuantity8.Text = "0";
                    }
                    else if (i == 34)//Adds four lines till the next quantity which will set the lbl quantity9 to 1.
                    {
                        lblQuantity9.Text = "0";
                    }
                    else if (i == 38)//Adds four lines till the next quantity which will set the lbl quantity10 to 1.
                    {
                        lblQuantity10.Text = "0";
                    }
                }
                else if (Books[i] == "Available")//If the string in a line is equal to the string "vailable" it will continue with the following: 
                {
                    if (i == 2)//Starting at index 2 or element 3 which is line 3 it will set the lbl quantity to 1.
                    {
                        lblQuantity1.Text = "1";
                    }
                    else if (i == 6)//Adds four lines till the next quantity which will set the lbl quantity2 to 1.
                    {
                        lblQuantity2.Text = "1";
                    }
                    else if (i == 10)//Adds four lines till the next quantity which will set the lbl quantity2 to 1.
                    {
                        lblQuantity3.Text = "1";
                    }
                    else if (i == 14)//Adds four lines till the next quantity which will set the lbl quantity2 to 1.
                    {
                        lblQuantity4.Text = "1";
                    }
                    else if (i == 18)//Adds four lines till the next quantity which will set the lbl quantity2 to 1.
                    {
                        lblQuantity5.Text = "1";
                    }
                    else if (i == 22)//Adds four lines till the next quantity which will set the lbl quantity2 to 1.
                    {
                        lblQuantity6.Text = "1";
                    }
                    else if (i == 26)//Adds four lines till the next quantity which will set the lbl quantity2 to 1.
                    {
                        lblQuantity7.Text = "1";
                    }
                    else if (i == 30)//Adds four lines till the next quantity which will set the lbl quantity2 to 1.
                    {
                        lblQuantity8.Text = "1";
                    }
                    else if (i == 34)//Adds four lines till the next quantity which will set the lbl quantity2 to 1.
                    {
                        lblQuantity9.Text = "1";
                    }
                    else if (i == 38)//Adds four lines till the next quantity which will set the lbl quantity2 to 1.
                    {
                        lblQuantity10.Text = "1";
                    }
                }
            }
            string[] BookRating = File.ReadAllLines("BookRating.txt"); //Creates a string array bookrating that is assigned to the txt file BookRating.txt File directory for each line as an element.

            for (int i = 0; i < BookRating.Length; i++)//Starts a for loop for each index for the Bookrating array that increments.
            {
                if (BookRating[i] == "Atomic Habits")//If the book rating line equals to the string "Atomic Habits" it will continue and set the label Rating1 to the bookrating index plus 1 which will be the rating.
                {
                    lblRating1.Text = BookRating[i + 1];
                }
                else if (BookRating[i] == "Blood Orange")//If the book rating line equals to the string "Blood Orange" it will continue and set the label Rating2 to the bookrating index plus 1 which will be the rating.
                {
                    lblRating2.Text = BookRating[i + 1];
                }
                else if (BookRating[i] == "DARKTOWN")//If the book rating line equals to the string "DARKTOWN" it will continue and set the label Rating3 to the bookrating index plus 1 which will be the rating.
                {
                    lblRating3.Text = BookRating[i + 1];
                }
                else if (BookRating[i] == "LIES")//If the book rating line equals to the string "LIES" it will continue and set the label Rating4 to the bookrating index plus 1 which will be the rating.
                {
                    lblRating4.Text = BookRating[i + 1];
                }
                else if (BookRating[i] == "LIGHTNING MEN")//If the book rating line equals to the string "LIGHTNING MEN" it will continue and set the label Rating5 to the bookrating index plus 1 which will be the rating.
                {
                    lblRating5.Text = BookRating[i + 1];
                }
                else if (BookRating[i] == "NOMAD")//If the book rating line equals to the string "NOMAD" it will continue and set the label Rating6 to the bookrating index plus 1 which will be the rating.
                {
                    lblRating6.Text = BookRating[i + 1];
                }
                else if (BookRating[i] == "PLEASE SEE US")//If the book rating line equals to the string "PLEASE SEE US" it will continue and set the label Rating7 to the bookrating index plus 1 which will be the rating.
                {
                    lblRating7.Text = BookRating[i + 1];
                }
                else if (BookRating[i] == "SAIL")//If the book rating line equals to the string "SAIL" it will continue and set the label Rating8 to the bookrating index plus 1 which will be the rating.
                {
                    lblRating8.Text = BookRating[i + 1];
                }
                else if (BookRating[i] == "SLOW FIRE")//If the book rating line equals to the string "SLOW FIRE" it will continue and set the label Rating9 to the bookrating index plus 1 which will be the rating.
                {
                    lblRating9.Text = BookRating[i + 1];
                }
                else if (BookRating[i] == "THE DILEMMA")//If the book rating line equals to the string "THE DILEMMA" it will continue and set the label Rating10 to the bookrating index plus 1 which will be the rating.
                {
                    lblRating10.Text = BookRating[i + 1];
                }
            }

        }
        //References:
        /*
        1 - https://www.youtube.com/watch?v=BtOEztT1Qzk&t=1093s
        2 - https://www.youtube.com/watch?v=OFX9LMGkLW4


        */

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panelBackList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        public void lblQuantity2_Click(object sender, EventArgs e)
        {

        }

        private void frmBookList_Load(object sender, EventArgs e)
        {

        }
    }
}



