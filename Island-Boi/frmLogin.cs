using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

//Name: Ishaan Mittal, Ritisha Garg and Danial Suhail
//Date: <Jan 20 - Apr 26> 
//Assignment: Culminating / AP CSP
//Purpose: To make a log in page for library program 

//Ritisha's and Danial's parts are labeled, the rest is Ishaan's 

//Code Explnation: 
//This program is an event based program so there is no specfic order this program can run but, in my explanantion I will talk the proceudre between the 2 interfaces, Log-In and Sign Up

//For Login:
//After the initialize compenent the program displays eveyrhting that is needed to start the program, this includes things such as the username text box, labels to help the user, sign up button, and submit 
//Then, once user inputs a value for username and clicks submit, the program checks if it is already in the file and validates the input.
//Once the input is validated, then the user is asked for their password and the username text box dissapears and is replaced by the password text box 
//Then, after the user inputs the password and clicks submit, the program checks if the password matches the username and if so, leads to the next part of the program being the library interface which is a whole sepratre thing 

//For Sign Up:
//After the user clicks sign up, all the labels and buttons from the previous login page are hidden and repalced with the new labels and buttons that work for the sign up part of the program (text boxes don't change however) 
//Then, the user is asked to enter a new username and password 
//Once they input their username and password and click submit the program validates the input and prints error messges accordingly  
//Additionally, for the username the program checks the text file and if the username is arleady in the text file it inform the user that the username is taken, the reason this doesn't happen for password is becuase people can have the same password 
//After the input is validated, the program writes to a text file of accounts, and updates their info so any other time they review this program again their info is saved 
//Laslty, after the File IO the prgram ends and leads to the next part of the project being the library interface 

//(Addition) Back: 
//During the sign up interface there is a new button shown with the text of ">Back" 
//Once clicked it clears the labels and buttons from the sign up page and replaces them with the labels and buttons for the login page
//Basically, it just goes back to the orginal login interface incase the user remebers their log in or accidently clicked sign up 

//In summary, despite having 2 different 'interfaces' for my program the end result is the same which is to lead to the next part of the program and save any user changes made on their library account (logging in, or making a new one) 

namespace Island_Boi
{

    public partial class frmLogin : Form
    {
        //Danial Suhail-------------------------------------------------------------------
        public static frmLogin inst; //I explained in other program  
        //--------------------------------------------------------------------------------

        public frmLogin() //method that controls what is shows at the strating of the program 
        {
            InitializeComponent();
            txtPass.Hide(); //the text book thats takes the user's password 
            btnSubmit2.Hide(); //this button controls the action of checking if the password is correct based on the username inputed by the user 
            btnSubmit3.Hide(); //this button controls the sign up action where when clicked it clears the field and makes the fields visiable that help with the sign up process (talked about more in method)  
            lblStart2.Hide(); //label that tells user to enter their new username/password upon clicing sign up, hiden becuase the page starts at the login page and not the sign up page 
            lblUsername.Hide(); //label that tells the user which form is asking for username in the sign up part of the program, hiden becuase the page starts on login page 
            lblPassword.Hide(); //label that tells the user which form is asking for password in the sign up part of the program, hiden becuase the page starts on login page
            lblInfo2.Hide(); //label that tells user after entering username, if the username they typed is really them if not, suggests them to sign up, hiden becuase it happens after submit is clicked 
            btnBack.Hide(); //btn used to return back to the login page of the program from the sign up 

        //Danial Suhail-------------------------------------------------------------------
            inst = this; //I explained in the other program
            this.Text = string.Empty; //I explained in the other program
            this.ControlBox = false;//I explained in the other program
          
        }
        //This is used to create an entry point and exit point
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //Setting Release Capture as private extern.
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //--------------------------------------------------------------------------------

        private void btnSubmit_Click(object sender, EventArgs e) //method contoling that when button is clicked the username entertd is saved into varible and checked for in the list, and if it is there asking for their password, if not, prints an error message 
        {
            StreamReader sr3 = new StreamReader("account.txt"); //used to read line and check if its empty 

            if (sr3.ReadLine() == null) //This if statement will run if value returned by the method FileCheck() = false
            {
                MessageBox.Show("File has been damaged");//notifes user that the file has been damamged
                Application.Exit();  //exists out of the program as a way to identify an evacution (Ishaan) 
            }

            sr3.Close(); //Close stream reader for accounts text file

            bool check = true; //bool used to check if the username entrted is in the text file, retruns false if username exsists, returns true if username does not exsist 

            if (txtusername.Text == "") { //used to check if the username inputed is not clear 
                MessageBox.Show("Please enter something"); //informs the user to enter something 
                check = false; //returns false so the program does not check for an invalid username and waste stroage
            }
           
            StreamReader sr = new StreamReader("account.txt"); //used for determining number of lines in text file (more on this) 
            StreamReader sr2 = new StreamReader("account.txt"); //used to actually add the items to the respective list (more on this) 

            int count = 0; //counter used to store the number of lines in file 

            int userCount = 0; //counter used to check for each element in the username array
            int passCount = 0; //counter used to check for each element in the password array

            while (sr.ReadLine() != null) //continues to read until the line is null or doesn't contrain anything 
            {
                count++; //increments the counter eveeytime a line is read to determine the total number of lines in the text file 
            }
            sr.Close(); //closes stream reader so other actions can be done in the file later on (this streamreader is used to find the total # of lines in the text file)

            int count2 = (count / 2); //used to identify the length of the list. Because the text file consists of usernames and passwords to find the total instances of each I just have to divide by 2 which is why I divide the total # of lines (count) by 2 to get the amount of passwords and usernames. 10 items = 5 usernmes and 5 passwords

            string[] inputs = new string[count]; // creates an array to store all the vaulues in the text file 
            string[] usernames = new string[count2]; //creates an array to store the usernames in the text file 
            string[] passwords = new string[count2]; //creates an array to store the passwords in the text file 

            for (int i = 0; i < count; i++) { //copys all the info from the text fine into the input array. The count represents the total lines in text file and therfore acts as the maximum value the for loop goes to until terminating 
                inputs[i] = sr2.ReadLine(); //copys info from text file into array 
            }

            //RITISHA GARG---------------------------------------------------------------
            if (FileCheck(inputs) == false) //This if statement will run if value returned by the method FileCheck() = false
            {
                MessageBox.Show("File has been damaged");//notifes user that the file has been damamged
                Application.Exit();  //exists out of the program as a way to identify an evacution (Ishaan) 
                return;
            }
            //--------------------------------------------

            for (int i = 0; i < count; i += 2) { //the reason this starts at 0 and increments by 2 is becuase the usernames are located at the even lines of the file. For example, 0 would be the first line which would be username #1 and then 1 would be the second line which would be password #1, then 2 would be the third line which would be the next usrname and continuing the pattern until all usernames are extracted, in others words, when the limit (count) is met 
                usernames[userCount] = inputs[i]; //copys the username from the input file which is immitating the text file, so that only username is copyed not password 
                userCount++; //increments to change the index at which the username is being copyed to 
            }

            for (int i = 1; i < count; i += 2) { //the reason this starts at 1 and increments by 2 is becuase the passwords are located at the odd lines of the file. For example, 1 would be the second line which would be password #1 and then 2 would be the third line which would be username #2, then 3 would be the fourth line which would be the next password and continuing the pattern until all passwords are extracted, in others words, when the limit (count) is met 
                passwords[passCount] = inputs[i]; //copys the password from the input file which is immitating the text file, so that only password is copyed not username 
                passCount++; //increments to change the index at which the password is being copyed to 
            }

            for (int i = 0; i < usernames.Length; i++) { //runs a loop to every element in the new username array with all the usernames
                usernames[i] = usernames[i].ToLower(); //makes all the elements lowercase so it is easy when validating input or checking if username is exsistent 
            }

            sr2.Close(); //closes streamreader so other actions can be done in the file later on (this streamreader is used for assigning values to the respected arrays as described above)

            string username = txtusername.Text; //varaible used to store the username value the user enters 
            username = username.ToLower(); //lowers the text so comparing is easy 

            string pass = txtPass.Text; //varibles used to store the password value the user enters

            for (int i = 0; i < usernames.Length; i++) { //checks thourgh all the elements in the username array 
                if (usernames[i] == username) //checks if the username inputted is actually in the text file/array or if the username is blank 
                {
                    txtusername.Hide();//hides the username text box to assure no changes are made 
                    btnSubmit.Hide(); //hides the submit button for username to start the next process, being entering the password 
                    btnSubmit2.Show(); //shows the submit button for password to start the next process of the program, which is to asses the password 
                    txtPass.Show(); //shows the text box that stores password, so the user can type their password 
                    lblInfo2.Show(); //label used to inform the user that if this is not their account, they should sign up 
                    check = false; //returns false so the program does not output an error message to the user stating that the username is not in the text file, therfore meaning the user has not signed up

                    lblStart.Text = "Enter your Password: "; //sets the text to displaying enter your password instead of enter your username
                }
            }

            if (check == true) { //based on the if statement above, if the username does not exsist in the text file, tells the user to sign up 
                MessageBox.Show("Username not found, please sign up"); //Informs user that username is not found and tht they should sign up
            }
        }

        private void btnSubmit2_Click(object sender, EventArgs e) //method contoling that when button is clicked the password entertd is saved into a varible and checked for in the list, and if it is there loading to the next part of the program being the actualy librry checkout interface, if not, prints an error message 
        {
            bool isTrue = true; //bool used to check if the password entrted is in the text file, retruns false if passwords exsists, returns true if password does not exsist 

            if (txtPass.Text == "")
            { //used to check if the password inputed is not clear      
                MessageBox.Show("Please enter something"); //informs the user to enter something 
                isTrue = false;  //returns false so the program does not check for an invalid password and waste stroage
            }

            StreamReader sr = new StreamReader("account.txt"); //used for determining number of lines in text file 
            StreamReader sr2 = new StreamReader("account.txt"); //used to actually add the items to the list 


            int count = 0; //counter used to store the number of lines in file 

            int userCount = 0;//counter used to check for each element in the username array
            int passCount = 0; //counter used to check for each element in the password array

            while (sr.ReadLine() != null) //continues to read until the line is null or doesn't contrain anything 
            {
                count++; //increments the counter eveeytime a line is read to determine the total number of lines in the text file 
            }
            sr.Close(); //closes stream reader so other actions can be done in the file later on (this streamreader is used to find the total # of lines in the text file)

            int count2 = (count / 2); //used to identify the length of the list. Because the text file consists of usernames and passwords to find the total instances of each I just have to divide by 2 which is why I divide the total # of lines (count) by 2 to get the amount of passwords and usernames. 10 items = 5 usernmes and 5 passwords

            string[] inputs = new string[count]; // creates an array to store all the vaulues in the text file 
            string[] usernames = new string[count2]; //creates an array to store the usernames in the text file 
            string[] passwords = new string[count2]; //creates an array to store the passwords in the text file 

            for (int i = 0; i < count; i++)
            { //copys all the info from the text fine into the input array. The count represents the total lines in text file and therfore acts as the maximum value the for loop goes to until terminating 
                inputs[i] = sr2.ReadLine(); //copys info from text file into array 
            }

            //RITISHA GARG--------------------------------------------------------------------
            if (FileCheck(inputs) == false) //This if statement will run if value returned by the method FileCheck() = false
            {
                MessageBox.Show("File has been damaged");//notifes user that the file has been damamged
                Application.Exit();  //exists out of the program as a way to identify an evacution (Ishaan) 
                return;
            }
            //--------------------------------------------------------------------

            for (int i = 0; i < count; i += 2)
            { //the reason this starts at 0 and increments by 2 is becuase the usernames are located at the even lines of the file. For example, 0 would be the first line which would be username #1 and then 1 would be the second line which would be password #1, then 2 would be the third line which would be the next usrname and continuing the pattern until all usernames are extracted, in others words, when the limit (count) is met 
                usernames[userCount] = inputs[i]; //copys the username from the input file which is immitating the text file, so that only username is copyed not password 
                userCount++; //increments to change the index at which the username is being copyed to 
            }

            for (int i = 1; i < count; i += 2)
            { //the reason this starts at 1 and increments by 2 is becuase the passwords are located at the odd lines of the file. For example, 1 would be the second line which would be password #1 and then 2 would be the third line which would be username #2, then 3 would be the fourth line which would be the next password and continuing the pattern until all passwords are extracted, in others words, when the limit (count) is met 
                passwords[passCount] = inputs[i]; //copys the password from the input file which is immitating the text file, so that only password is copyed not username 
                passCount++; //increments to change the index at which the password is being copyed to 
            }

            for (int i = 0; i < usernames.Length; i++)
            { //runs a loop to every element in the new username array with all the usernames
                usernames[i] = usernames[i].ToLower(); //makes all the elements lowercase so it is easy when validating input or checking if username is exsistent 
            }

            sr2.Close(); //closes streamreader so other actions can be done in the file later on (this streamreader is used for assigning values to the respected arrays as described above)

            string username = txtusername.Text; //varaible used to store the username value the user enters 
            username = username.ToLower(); //lowers the text so comparing is easy 
            username = username.Trim(); // trims any spaces 
            string pass = txtPass.Text; //varibles used to store the password value the user enters


            int index = Array.IndexOf(usernames, username); //checks where in the list (index) is the user input located 

            if (passwords[index] == pass) //becuase the matching usernames and passwords have the same index, it just checks the password is the same as the password in the same index as the username enterted
            {
                isTrue = false; // if it is returns false, which then leads to the library interface

            }

            else
            {
                isTrue = true; // if the password is not correct returns true which then outputs an error message.
            }
            StreamWriter sw2 = new StreamWriter("CurrentLogin.txt");// streamwriter to determine which user is using the program currently
            if (isTrue == false) // checks if the bool is false 
            {
                sw2.WriteLine(username);
                sw2.Close();
                //Danial Suhail-------------------------------------------------------------------
                frmLibMain form = new frmLibMain(); //opens the main form
                //The Login forms would have uploaded this data into that file!
                StreamReader ReadingUsername = new StreamReader("CurrentLogin.txt");
                //Opens up StreamReader and the file named CurrentLogin.txt
                string Username = ReadingUsername.ReadLine();
                //Reads the first line stored in the file and assigns a string variable named Username to that variable
                ReadingUsername.Close();//Closes the process
                frmLibMain.inst.lblName.Text = username + "!"; // Reads from Main form and changes the name label from there to the username
                form.Show();//shows the form
                this.Hide();//Hides form
               //-------------------------------------------------------------------      
       

            }
            sw2.Close();

            if (isTrue == true && pass != "") { // if there is no changes with the bool and stays true, tells the user the password is wrong and checks if the password is not empty as incorrect password is not a valid error message. Basically used to prevent 2 error messages.
                MessageBox.Show("Incorrect Password"); //tells user the password is wrong
            }
        }

        private void btnSign_Click(object sender, EventArgs e) //method that controls what happens after user clicks the sign up button and pretty much initates the sign up part of the program 
        {
            lblSign.Text = ""; //clears the statment that says "Dont have an account..." 
            lblSign2.Text = "";//clears the statment that says "Click this button....." 
            lblPassword.Show(); //shows the label telling which txtfield is the password 
            lblUsername.Show(); //shows the label telling which txtfield is the username 

            txtusername.Text = ""; //clears the username text box
            txtPass.Text = ""; //clears the password text box 

            txtusername.Show(); //shows the username text box incase it was hidden 
            txtPass.Show(); //shows the password text box incase it was hidden 

            lblStart.Hide();//hides the start message 
            lblStart2.Show();//shows the label that says "Enter your new username and password" 
            lblInfo2.Hide();//hides the label that tells user after entering username, if the username they typed is really them if not, suggests them to sign up

            btnBack.Show(); //shows the back button which is used to travel back to the login page 
            btnSign.Hide(); //hides the sign up button that was clicked 
            btnSubmit.Hide(); //hides the submit button for username 
            btnSubmit2.Hide(); //hides the submit button for password 
            btnSubmit3.Show(); //shows the submit button that saved the new user info 
        }

        private void btnSubmit3_Click(object sender, EventArgs e)
        {
            StreamReader sr3 = new StreamReader("account.txt"); //used to read line and check if its empty 

            if (sr3.ReadLine() == null)//Checks if the first line is null 
            {
                MessageBox.Show("File has been damaged");//notifes user that the file has been damamged
                Application.Exit();  //exists out of the program as a way to identify an evacution (Ishaan) 
            }

            
            sr3.Close();
           
            bool save = true; //bool that returns false if the username and password have no problems and allows them to be added to the file, and returns true if there is a problem (e.g. if username is alreay taken) 

            if (txtusername.Text == "") { //checks if username is empty 
                MessageBox.Show("Please enter a value for username");  //tells user to enter something for username 
            }

            if (txtPass.Text == "") //checks if password is empty 
            {
                MessageBox.Show("Please enter a value for Password"); //tells user to enter something for password 
            }

            for (int i = 0; i < txtusername.Text.Length; i++) { //checks through every chratcter in the username, and if one of them is a space informs the user 
                if (txtusername.Text[i] == ' ') { //if the chraer is a space 
                    MessageBox.Show("Username cannot contain spaces"); //tells user that the username cannot contain spaces 
                    txtusername.Text = ""; //clears text box 
                    save = true; //returns true so it doesn't add an invalid username to text file 
                }
            }

            for (int i = 0; i < txtPass.Text.Length; i++) //same thing as above but for password 
            {
                if (txtPass.Text[i] == ' ')
                {
                    MessageBox.Show("Password cannot contain spaces");
                    txtPass.Text = "";
                    save = true;

                }
            }

            StreamReader sr = new StreamReader("account.txt"); //used for determining number of lines in text file 
            StreamReader sr2 = new StreamReader("account.txt"); //used to actually add the items to the list 

            int count = 0; //counter used to store the number of lines in file 

            int userCount = 0;//counter used to check for each element in the username array
            int passCount = 0; //counter used to check for each element in the password array

            while (sr.ReadLine() != null) //continues to read until the line is null or doesn't contrain anything 
            {
                count++; //increments the counter eveeytime a line is read to determine the total number of lines in the text file 
            }
            sr.Close(); //closes stream reader so other actions can be done in the file later on (this streamreader is used to find the total # of lines in the text file)

            int count2 = (count / 2); //used to identify the length of the list. Because the text file consists of usernames and passwords to find the total instances of each I just have to divide by 2 which is why I divide the total # of lines (count) by 2 to get the amount of passwords and usernames. 10 items = 5 usernmes and 5 passwords

            string[] inputs = new string[count]; // creates an array to store all the vaulues in the text file 
            string[] usernames = new string[count2]; //creates an array to store the usernames in the text file 
            string[] passwords = new string[count2]; //creates an array to store the passwords in the text file 

            for (int i = 0; i < count; i++)
            { //copys all the info from the text fine into the input array. The count represents the total lines in text file and therfore acts as the maximum value the for loop goes to until terminating 
                inputs[i] = sr2.ReadLine(); //copys info from text file into array 
            }

            //RITISHA GARG ------------------------------------------------------------------
            if(FileCheck(inputs) == false) //This if statement will run if value returned by the method FileCheck() = false
            {
                MessageBox.Show("File has been damaged");//notifes user that the file has been damamged
                Application.Exit();  //exists out of the program as a way to identify an evacution (Ishaan) 
                return;
            }
            //--------------------------------------------------------------------------------

            for (int i = 0; i < count; i += 2)
            { //the reason this starts at 0 and increments by 2 is becuase the usernames are located at the even lines of the file. For example, 0 would be the first line which would be username #1 and then 1 would be the second line which would be password #1, then 2 would be the third line which would be the next usrname and continuing the pattern until all usernames are extracted, in others words, when the limit (count) is met 
                usernames[userCount] = inputs[i]; //copys the username from the input file which is immitating the text file, so that only username is copyed not password 
                userCount++; //increments to change the index at which the username is being copyed to 
            }

            for (int i = 1; i < count; i += 2)
            { //the reason this starts at 1 and increments by 2 is becuase the passwords are located at the odd lines of the file. For example, 1 would be the second line which would be password #1 and then 2 would be the third line which would be username #2, then 3 would be the fourth line which would be the next password and continuing the pattern until all passwords are extracted, in others words, when the limit (count) is met 
                passwords[passCount] = inputs[i]; //copys the password from the input file which is immitating the text file, so that only password is copyed not username 
                passCount++; //increments to change the index at which the password is being copyed to 
            }

            for (int i = 0; i < usernames.Length; i++)
            { //runs a loop to every element in the new username array with all the usernames
                usernames[i] = usernames[i].ToLower(); //makes all the elements lowercase so it is easy when validating input or checking if username is exsistent 
            }

            sr2.Close(); //closes streamreader so other actions can be done in the file later on (this streamreader is used for assigning values to the respected arrays as described above)

            string username = txtusername.Text; //varaible used to store the username value the user enters 
            username = username.ToLower(); //lowers the text so comparing is easy 
            username = username.Trim(); // trims any spaces 
            string pass = txtPass.Text; //varibles used to store the password value the user enters
            pass = pass.Trim(); // trims any spaces 

            bool error = true; //used to check if the username is already taken. Retruns false if username is arleady taken, retrusn true if username is not taken 

            for (int i = 0; i < usernames.Length; i++) { //goes throught every value in the usernames list 
                if (usernames[i] == username) //checks if any of the usernames are the same as the username enter 
                {
                    save = true; //returns true so the program doesn't add an invalid username to file 
                    error = false; //returns false to tell user the name is aready taken. 
                }
                else //if they are not the same as the username 
                {
                    save = false; //returns false to allow the username to be added to the text file 
                }
            }

            if (error == false) { //checks if bool error is false 
                MessageBox.Show("Username already taken, please enter a different username"); // if it is false tells the username is already taken 
                save = true; // returns true so the program doesn't add an indalid to file 
            }

            StreamWriter sw = new StreamWriter("account.txt", true); //makes a streamwriter that writes to the file. The true allows the streamwritier to continue writing on another line instead of clearing the whole text file. 
            StreamWriter sw2 = new StreamWriter("CurrentLogin.txt"); //streamwriter to determine which user is using the program currently
            if (txtusername.Text != "" && txtPass.Text != "" && save == false) { //checks if the username and password are not empty and bool save is false 
                sw.WriteLine(username); // prints the username to the file 
                sw2.WriteLine(username);
                sw.WriteLine(pass); // prints the password to the file 
                sw.Close(); //closes the streamwriter so it doesn't cause an issue with the file 
                sw2.Close(); //closes the streamwriter so it doesn't cause an issue with the file 
                lblStart2.Text = ""; //clears the start text in this part of the program "Enter your new username......" 
                lblUsername.Text = "";//clears the label telling the user which box is username 
                lblPassword.Text = "";//clears the label telling the user which box is password 
                txtusername.Hide(); //hides the username text box 
                txtPass.Hide(); //hides the password text box 
                btnSubmit3.Hide(); //hides the submit button 
                btnBack.Hide(); //hides the back button
                //the reason all of this is hidden is so the user cannot make any changes 

                //DANIAL SUHAIL--------------------------------------------------------------
                frmLibMain form = new frmLibMain();//opens the main form 
                frmLibMain.inst.lblName.Text = username + "!"; //
                form.Show(); //leads to the next part of the program being the library interface 
                this.Hide();
                //----------------------------------------------------------------------------
            }

            sw.Close(); //closes the streamwriter so it doesn't cause an issue with the file 
            sw2.Close(); //closes the streamwriter so it doesn't cause an issue with the file 
        }

        private void btnBack_Click(object sender, EventArgs e) //used to go from the sign-up page to the log in page 
        {
            btnSubmit3.Hide(); //hides the button that saves the user's password and username and adds it to text file if no error are in it 
            lblPassword.Hide(); //hides the label telling the user which box is password 
            lblUsername.Hide(); //hides the label telling the user which box is username  
            lblStart2.Hide(); //hides the start text in the sign up part of the program "Enter your new username...." 
            txtusername.Text = ""; //clears the username text box 
            txtPass.Text = ""; //celars the password text box 
            txtPass.Hide(); //hides the password text box, as the login page starts off with the username text box 
            btnSubmit.Show(); //shows the button that stores username 
            btnBack.Hide(); //hides the back button as now the current page is the log in page and not the sign up page 
            lblStart.Show(); //shows the start message of the log in page "Enter username" 
            lblSign.Text = "Don't have an account? Sign up Now!"; //reassigns the label thier orginal values before sign up button was clikced 
            lblSign2.Text = "Click this button to sign up: "; //reassigns the label thier orginal values before sign up button was clikced 
            lblStart.Text = "Enter your Username: ";  //reassigns the label thier orginal values before sign up button was clikced 

            btnSign.Show(); //shows the sign up button incase the user wants to go back to the sign up page 
        }
        public static bool FileCheck(string[] Recieve)
        //RITISHA GARG ------------------------------------------------------------------------------
        //Created a bool method named FileCheck with one string array parameter
        //The bool method will return a false/true value which will determine whether the file is good or not
        {
            if (Recieve.Length % 2 != 0) //This if statement will run if Length of Recieve is not divisible by 2 
                                         //This is because the data stored in account.txt will always be in pairs (username + password) and thus total file length will always be an even number
            {
                return false;
                //Automatically the method returns false as this is a clear indicator of a damaged file
            }
            for (int index = 0; index < Recieve.Length; index++)//For loop in which variable int index, will start at 0, increment by 1 each time and will run through the loop until it is less than the length of recieve
                                                                //This loop is used to go through the array see if any one of the elemets stored are null or a space
            {
                if (Recieve[index] == " " || Recieve[index] == "") //if statement that will run if element stored at Recieve[index] = "" or " " 
                {
                    return false;
                    //Automatically returns false as this is a clear indicator of damamged file
                }
            }
            return true;
            //If the program didn't catch any errors before, this will return true meaning that the file has not been damamged. 
            //----------------------------------------------------------------------------------------------
        }
        //DANIAL SUHAIL--------------------------------------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            //if the windowstate is set to normal it will contineu iwth the following
            if (WindowState == FormWindowState.Normal)
            {
                //it will maximize the windows form state.
                this.WindowState = FormWindowState.Maximized;
            }
            else//otherwise it iwill unmaximize it back to normal.
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //I explained the previous code in the other Main form program

        //--------------------------------------------------------------
    }
}

//References: 

//I learned about .Hide and .Show by this website: https://www.physicsforums.com/threads/c-hiding-and-showing-forms.552874/#:~:text=In%20c%23%20you%20have%20to%20do%20this%20Code%3A,%2F%2Fcreate%20a%20new%20instance%20form2.show%20%28%29%3B%20this.hide%20%28%29%3B
//Pretty much .Show changes the visiblity property of the form (e.g. button, text field, label) where .show makes the form visible and .Hide makes the form invisible 

//I learned about Application.Ext() by this website: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.application.exit?view=windowsdesktop-7.0
//Pretty much application.exit tells the seperate files (the premaid ones, e.g. Program.CS) controlling this program to terminate the project and once the message reaches, that is when the application closes.

//I learned how to append to file using streamwrirter wihout clearing from this webiste: https://www.codeproject.com/Questions/305991/write-to-a-text-file-without-overwriting-existing