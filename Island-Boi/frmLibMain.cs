using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name: Danial Suhail
//Date: <Jan 20 - Apr 26> 
//Assignment: ICS3UA Culminating / AP CSP
//Purpose: Display ISBN and barcodes for better functionality

namespace Island_Boi
{
    //Danial Suhail----------------------------------------------------
    public partial class frmLibMain : Form
    {
        //Setting the frmLibmain as an instance as a public static class.
        public static frmLibMain inst;
        //Setting button to private as current button.
        private Button currButton;
        //Setting the Form called formOn as a private.
        private Form formOn;
        //Creating a public label so the other form can access and change the label.
        public Label lblName;
        

        public frmLibMain()//This is the main form that has all forms nested in this specifically is the method associated with it.
        {
            InitializeComponent();
            //Sets the instance as this.
            inst = this;
            //sets the lblname to the label user displays by default on the main form
            lblName = lblUserIntro2;

            //Setting the Text to a empty string.
            this.Text = string.Empty;
            //Adds the controlbox as false.
            this.ControlBox = false;
            //Setting the maximum bounds of the form to what the screen can handle.
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //Sets the btnMoveMain visible to false.
            btnMoveMain.Visible = false;
            //Sets the serach button to visible as true to make it possible to search for one of the other form sections.
            btnSearchButton.Visible = true;
            

        }
        //This is used to create an entry point and exit point
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //Setting Release Capture as private extern.
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmLibMain_Load(object sender, EventArgs e)
        {
        }

        private Color SelectThemeColor()//This method is used to select the main selectthemecolour for the main form.
        {
            string color = MainColour.colourMain;//Sets a string color to the class Maincolour to .colourMain.
            return ColorTranslator.FromHtml(color);//Translates the colour from HTML to the actual colour to display.
        }

        private void ActivateButton(object btnSender)//When activated it will go through this method
        {
            if (btnSender != null)//if the btn sender is considered not null so its visible and runnable it wil contineu with the following.
            {
                //If the currentbuttion is not equal to the btnsender button it will contineu with tefollowing
                if (currButton != (Button)btnSender)
                {
                    //call the method DisableButton.
                    DisableButton();
                    //Sets the color to the select theme colour's method selection.
                    Color color = SelectThemeColor();
                    //Sets the current button to the button sender.
                    currButton = (Button)btnSender;
                    //Sets the backcolour of the currbutton to the color selected through the selectthemecolour.
                    currButton.BackColor = color;
                    //currButton Setting the forecolour to white.
                    currButton.ForeColor = Color.White;
                    //Setting the font of the side panel buttons to 3 plus the font when clicked on.
                    currButton.Font = new System.Drawing.Font("Nirmala UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //The main button is now visible and the serach button are vissible,.
                    btnMoveMain.Visible = true;
                    btnSearchButton.Visible = true;
                }
            }
        }
        //Private Disabled button method is run which is when the button is not actiavqtewd yet.
        private void DisableButton()
        {
            //Used a foreach loop for each previous button in the panel maincontrol it will do the following till completion.
            foreach(Control previousBtn in panelMain.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))//if the previous button elemtn type is considered a button it will contineu witht efollowing,
                {
                    //setting the backcolour and setting the font donw to 8.25.
                    previousBtn.BackColor = Color.FromArgb(9, 70, 125);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                }
            }
        }
        //This private method is used for entering the sub form entries with the buttons .
       private void subFormEntry(Form subForm, object btnSender)
        {
            //if the formOn is not null meaning it is running it will close the form 
            if( formOn!= null)
            {
                formOn.Close();
            }
            //Then it will call activate buttion sender when the button is clicked.
            ActivateButton(btnSender);
            //sets the formOn as the new subform.
            formOn = subForm;
            //Sets the layout and assets of the subform as the following.
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            this.panelDisplayForm.Controls.Add(subForm);
            this.panelDisplayForm.Tag = subForm;
            subForm.BringToFront();
            subForm.Show();
            lblSubTitle.Text = subForm.Text;

        }
             //These are the method that allow the entry of the forms when the corresponding buttons are clicked.
        private void btnBookList_Click(object sender, EventArgs e)
        {
            subFormEntry(new Forms.frmBookList(), sender);
        }
        //These are the method that allow the entry of the forms when the corresponding buttons are clicked.
        private void btnBookHistory_Click(object sender, EventArgs e)
        {
            subFormEntry(new Forms.frmBookISBN(), sender);
        }
        //These are the method that allow the entry of the forms when the corresponding buttons are clicked.
        private void btnBookReview_Click(object sender, EventArgs e)
        {
            subFormEntry(new Forms.frmBookReview(), sender);
        }
        //These are the method that allow the entry of the forms when the corresponding buttons are clicked.
        private void btnBookHold_Click(object sender, EventArgs e)
        {
        }

        private void btnBookDonate_Click(object sender, EventArgs e)
        { 
        }
        //These are the method that allow the entry of the forms when the corresponding buttons are clicked.
        private void btnBookCheckout_Click(object sender, EventArgs e)
        {
            subFormEntry(new Forms.frmBookCheckList(), sender);
        }
        //This is responsible for the top panel and whn clicked on it will do th following
        private void panelTopTitle_MouseDown(object sender, MouseEventArgs e)
        {
            //it calls the ReleaseCapture method in order to move and tinker with the form layout.
            ReleaseCapture();
            //calls the send message method allowing it to more around.
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //If button close is clicked which is a button created cusetomly to close the file it will aplication.exit out.
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //when the expand button is clicked it will set the window state to the maximized tstate through this method.
        private void btnExpand_Click(object sender, EventArgs e)
        {
            //if the windowstate is set to normal it will contineu iwth the following
            if(WindowState == FormWindowState.Normal)
            {
                //it will maximize the windows form state.
                this.WindowState = FormWindowState.Maximized;
            }
            else//otherwise it iwill unmaximize it back to normal.
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        //sets the private method when button minimize is clicked it will minimize the form being no longer visible but does not close the progbram.
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //When the searchbar textbox is clicked it will autmoatically clear what is in there.
        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            txtSearchBar.Text = "";

            

        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSearchBar_Enter(object sender, EventArgs e)
        {
        }
        //if the button1 which is the button next to the search that looks at whats in the text box it will run this method.
        private void button1_Click(object sender, EventArgs e)
        {
            //Checks thorugh if statements if the txtSearchbar is equal to the form names and if they are it will open the form.
            if (txtSearchBar.Text == "book list")
            {
                //it opens the subform
                subFormEntry(new Forms.frmBookList(), sender);
            }

            if (txtSearchBar.Text == "book isbn")//Checks thorugh if statements if the txtSearchbar is equal to the form names and if they are it will open the form.
            {
                //it opens the subform
                subFormEntry(new Forms.frmBookISBN(), sender);
            }

            if (txtSearchBar.Text == "book review")//Checks thorugh if statements if the txtSearchbar is equal to the form names and if they are it will open the form.
            {
                //it opens the subform
                subFormEntry(new Forms.frmBookReview(), sender);
            }

            if (txtSearchBar.Text == "book checkout")//Checks thorugh if statements if the txtSearchbar is equal to the form names and if they are it will open the form.
            {
                //it opens the subform
                subFormEntry(new Forms.frmBookCheckList(), sender);
            }

            if (txtSearchBar.Text == "home" || txtSearchBar.Text == "menu" || txtSearchBar.Text == "main" || txtSearchBar.Text == "welcome")//Checks thorugh if statements if the txtSearchbar is equal to the form names and if they are it will open the form.
            {
                //if formOn is not set to null meaning its on it will close the form.
                if (formOn != null)
                {
                    formOn.Close();
                }
                //it will then run the reset method to reset the welcome page back to normal.
                Reset();
            }
        }
        //If the btn which is on the logo top left is clicked it will do this method.
        private void btnMoveMain_Click(object sender, EventArgs e)
        {
            //If the form is on still it will close the form.
            if(formOn != null)
            {
                formOn.Close();
            }
            //It will run the reset method which will reset the welcome page back to normal.
            Reset();
        }

        //Run the reset method.
        private void Reset()
        {
            //Runs the disable button method.
            DisableButton();
            //Sets the subtitle back to welcome.
            lblSubTitle.Text = "WELCOME";
            //sets the curr button to null and sets the buttons to visible fo rthe search but the movemain butto to false.
            currButton = null;
            btnMoveMain.Visible = false;
            btnSearchButton.Visible = true;
        }

        private void lblUserIntro2_Click(object sender, EventArgs e)
        {
            /*
            //The Login forms would have uploaded this data into that file!
            StreamReader ReadingUsername = new StreamReader("CurrentLogin.txt");
            //Opens up StreamReader and the file named CurrentLogin.txt
            string Username = ReadingUsername.ReadLine();
            //Reads the first line stored in the file and assigns a string variable named Username to that variable
            ReadingUsername.Close();//Closes the process
            lblUserIntro2.Text = Username;*/
        }
        
    }
}
