using AForge.Video;
using AForge.Video.DirectShow;
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
using ZXing;

//Name: Ritisha Garg, Danial Suhail and Ishaan Mittal 
//Date: <Jan 20 - Apr 26>
//Assignment: ICS3UA Culminating / AP CSP
//Purpose: To create the Library Checkout and Return System for the Program

//Ritisha-------------------------------------------------------------
//Code Explanation and Approach:
//This program and checkout system use File IO to store a database containing names and ISBN numbers of various books and their availibility
//Moreover, a file named "UserAccounts.txt" is used to record the checkout history and due date for the books that a specific user has checked out

//Checkout:
//Upon the ISBN number being entered by the user, the program searches the BookFile.txt to record all lines into an array
//Then, the program will search through this array to find the name of the book coresponding to the ISBN number entered
//If the book isn't found, an error message is thrown at user. However, if it is correct, then the name of the book is displayed and user's checkout history is looked at
//If user hasn't already checked out a book previously, they are allowed to checkout. Otherwise, they are thrown an error message
//If the book that the user is willing to checkout is not availble, then user will be thrown an error message stating that book in unavailable

//Return: 
//Upon the ISBN number being entered by the user, the program searches the BookFile.txt to record all lines into an array
//Then, the program will search through this array to find the name of the book coresponding to the ISBN number entered
//If the book isn't found, an error message is thrown at user. However, if it is correct, then the name of the book is displayed
//The user is notified if their book is overdue and the book is erased from the user's checkout history
//It is also marked as availble in the book file. 
//Ritisha-----------------------------------------------------------

//Danial--------------------------------------------------------------
/*Code explanation and Approach:
 * My part of this program is to be able to build a sufficient UI that is visually pleasing and interactive for the user and to be able to provide more options for accesibility
 * Also to send data for the book details and changes between many forms through file.IO and to actively update them throughout especially through BookList.
 * In this program I encorporated a barcode scanner which can readily connect to any webcam or as intended for this project to create a simulation of a barcode scanner through syncing your phone to your webcam.
 * This can be done through the app "Iriun" which can be both downloaded on PC and Phone and insync can provide a well-made barcode scanner. https://iriun.com/
 * The barcode scanner was created to work with the webcam encorporating NuGet packages like aForge, ZXing, etc.
 * Focused on Optimizing UI to incorporate full screen, half screen, and small screen displays.
 * Helped sync Ritisha's code with the UI by implemented her form into this form.
*/
//-----------------------------------------------------------------------

namespace Island_Boi.Forms
{

    public partial class frmBookCheckList : Form
    {
        public frmBookCheckList()
        {
            InitializeComponent();
            dateTimePicker2.ShowUpDown = true;
            //dateTimePickers are objects in windows forms used to help user input a specific date and time
            //In this program there are two dateTimePickers to let user choose when they want to return the book
            //This datetime picker has been set to show an UpDown menu used to change the time. When the program is run, there will be arrow keys to allow user to either increase or decrease the time in increments
            //THIS CONCEPT WAS TAKEN FROM 
            //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datetimepicker?view=windowsdesktop-7.0  
            //& Also: https://www.c-sharpcorner.com/uploadfile/mahesh/C-Sharp-datetimepicker-control/
        }
        
        //Danial----------------------------------------------------------
        FilterInfoCollection filter;//This is a class that can be installed through a NuGet package "aforge" allowing to enumerate directshow filters for a specific category
        VideoCaptureDevice capDevice;//Also part of the Nuget package "aforge" and is a class that allows to display video sources for local video capturing devices like webcams.


        private void frmBookCheckList_Load(object sender, EventArgs e)
        {
            //This method begins when the Checklist form loads.
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);//This is all part of the FilterInfoCollection cass and is used to assign the video device to a category.
            foreach(FilterInfo info in filter)//for each loop is used here to add each compatible webcam to the array of webcams.
            {
                //This adds all items and names of the webcams to the combobox drop down to make it easily selectable for the user.
                comboBoxWebCam.Items.Add(info.Name);
            }
            //Sets or reutrns the index of the option selected in the drop-down comboBoxWebcam list starting at 0.
            comboBoxWebCam.SelectedIndex = 0;
        }

        private void btnCheckDisplay_Click(object sender, EventArgs e)
        {
            //Method used for The Check arrow button below the webcam display and next to the text to add functionality when clicked.
            capDevice = new VideoCaptureDevice(filter[comboBoxWebCam.SelectedIndex].MonikerString);//MonikerString is apropertly under aforge representing the video device that checks what selected combobox option you chose to be the new capturedevice.
            capDevice.NewFrame += CapDevice_NewFrame;//Adds on each new frame continuously of that select device.
            capDevice.Start();//Starts the webcam
            timer.Start();//Starts a timer for the webcam.
            //Copy here just in case.
        }

        private void CapDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //ISHAAN MITTAL -----------------------------------------
            try //runs the camera 
            { //This is the method that calculates each new frame and that is added on the the capDevice.NewFrame.
                pictureBox_Camera.Image = (Bitmap)eventArgs.Frame.Clone();
                //This is the picturebox visible on the windows form that is set to a bitmap of events that clones frames in order to update the image at a fast and higher resolution. 
            }

            catch (InvalidOperationException) { //catches error with if the display button is clicked mutliple times, or mutiple cameras are used (i.e webcame, phone cam)
                Application.Exit(); //exits out of the program as error was found 
            }
            //------------------------------------------------------------------
        }

        private void frmBookCheckList_FormClosing(object sender, FormClosingEventArgs e)
        {
            //This is an event added as a method for the process of closing the form book list.
            if (capDevice != null)//This is when capdevice is not equal to null or the default value meaning it still is processsing it will continue to do the followin
            {
                if (capDevice.IsRunning)// If the capdevice is still running it will continue to do the following
                {
                    capDevice.Stop();//This will stop the capdevice or webcamdevice so that it no longer runs after it's done its use.
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //This is a method to set a timer so the Picturebox can stop once it finds the ISBN value.
            if (pictureBox_Camera.Image != null)// If the picturebox image visible on the windows form is still running and is not equal to null it will continue to do the following.
            {
                BarcodeReader barcode = new BarcodeReader();//Using the ZXing NuGet Package to create a new barcode reader.
                Result res = barcode.Decode((Bitmap)pictureBox_Camera.Image);//Encapsulates the result of the barcode decode from the picturebox images bitmap.
                if (res != null)//If the variable assigned to the decode is no null so it was able to find a valid ISBN it will continue to do the following
                {
                    txtDisplay.Text = res.ToString();//Assigns the txtDisplay text box to the decoded ISBN converted to a string.
                    timer.Stop();//Stops timer as the process is now complete to find the ISBN number.
                    if (capDevice.IsRunning)//If capdevice is still running it will continue to do the following
                    {
                        capDevice.Stop();//The capdevice stops.
                    }
                }
            }
        }
        //References: https://www.youtube.com/watch?v=pKjct-DXL0w
        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
        }
        //^-----------------------------------------------------------------------------------------------------------

        //Ritisha-----------------------------------------------------------------------------------------------------
        private void btnCheckDisplayV2_Click(object sender, EventArgs e)
        //This loop will play when user presses checkout button
        {
            //The following three lines of code will read the file CurrentLogin.txt to find the username of the current user
            //The Login forms would have uploaded this data into that file!
            StreamReader ReadingUsername = new StreamReader("CurrentLogin.txt");
            //Opens up StreamReader and the file named CurrentLogin.txt
            string Username = ReadingUsername.ReadLine();
            //Reads the first line stored in the file and assigns a string variable named Username to that variable
            ReadingUsername.Close();//Closes the process

            string ISBN = txtISBN.Text; //string varaible used to determine ISBN number
            //This variable will store value from the ISBN textbox (what user has inputted)
            int BookName = 0; //int variable used to determine the index that the Book's Name will be stored in, in the books array
            bool BookFound = false;//bool variable named BookFound used to determine if the Book has been found or not in BookFile.

            string[] Books = File.ReadAllLines("BookFile.txt"); //An Array that will read all lines in BookFile.txt and store values into a string array
            string[] Record = File.ReadAllLines("UserAccounts.txt");//An Array that will read all lines in UserAccounts.txt and store values into a string array
            //The above two lines work in the way that File.ReadAllLines automatically creates an array of the same amount of lines as in the specific file and stores every line as an element in the array
            //For ex. line 1 will be stored in the first element of the array (at index 0)
            //THE CONCEPT ABOVE WAS TAKEN FROM: https://www.geeksforgeeks.org/file-readalllinesstring-method-in-c-sharp-with-examples/

            if (FileCheck(Books) == false || SyncCheck(Books, Record) == false)
            //This if statements will run if any of either methods FileCheck() or SyncCheck() return a false value.
            //If they do then that is a clear indicator of a damaged file
            {
                MessageBox.Show("File Error");//Notifies user that File is damamged
                Application.Exit();
                return;//Breaks from btnCheckout_Click().
                //THIS CONCEPT WAS TAKEN FROM: https://social.msdn.microsoft.com/Forums/windows/en-US/df0c4a7c-2134-45d0-b075-f78762e54840/how-do-you-break-out-of-a-windows-form-button-click-event?forum=winforms
            }

            //For loop used to find the Book Name of the respective ISBN number given
            for (int Index = 0; Index < Books.Length; Index += 4)
            //Starts at 0, increments by 4 each time and will run until Index is less than Books.Length
            //will increment by 4 each time as ISBN's in BookFile are only stored at every 4th line (index 0, 4, 8 etc.)
            {
                if (Books[Index] == ISBN)
                    //this if statement will run when Books[Index
                {
                    BookName = Index + 1; //BookName will record the index of the name after the associated ISBN number. This is the name of the Book that will be used several times throughout program
                    BookFound = true; // Validates that the book has been found (to be used in next block)
                    break; // Breaks out of if block as BookName has been found
                }
            }

            if (!BookFound) 
            //signifies that BookFound == false, or that book hasn't been found
            {
                MessageBox.Show("Book Not Found"); //User will get this as an error message
            }
            else//will run if the if statement condition is not true
            {
                    bool PlayLoop = true;//A bool variable used to validate weather user already has a book checked out or not
                    string CheckoutBook = "";//A string variable that will store the name of the checked out book. This variable will be used to tell the user which book they've already checked out
                    for (int Index = 0; Index < Record.Length; Index++) //for loop that goes through every element stored in Record
                    {
                        if (Record[Index] == Username)//When loop finds the element which stores the users name it will...
                        {
                            if (Record[Index + 1] != "Checkout Empty")//Validate if on the the next line "Checkout Empty" is written ("meaning no checkouts have been done") 
                            {
                                CheckoutBook = Record[Index + 1];//Will set the value inside CheckoutBook as the element stored in Record[Index + 1]
                                                                 //This means that the name of the book will be stored as the book name is written one line after the ISBN number 
                                PlayLoop = false;//sets PlayLoop to false 
                            }
                            else
                            {
                                PlayLoop = true;//keeps PlayLoop to true
                            }
                        }
                    }
                    //A Specific Case: If the user has never checked out a book before in the library PlayLoop will remain true and the following if statement WILL be run
                    if (PlayLoop == true) //Validates if PlayLoop = true
                    {
                        bool BookAvailable = true;//Variable used as a parameter for Appending
                        if (Appending(ref Books, Books[BookName], BookAvailable))//Validates if value returned by Appending() is true or not
                                                                                 //if true this block will be run
                        {
                            StreamWriter BooksRewrite = new StreamWriter("BookFile.txt");
                            for (int Index = 0; Index < Books.Length; Index++)//will run for as long as the length of Books[]
                            {
                                BooksRewrite.WriteLine(Books[Index]);//will write the string value stored at every index of Books[] 
                            }
                            BooksRewrite.Close();//closes the process
                        }
                        else //if Appending() does not return true, then the return statement will exit out of this entire method
                        {
                            return;
                            //THIS CONCEPT HAS BEEN TAKEN FROM: https://social.msdn.microsoft.com/Forums/windows/en-US/df0c4a7c-2134-45d0-b075-f78762e54840/how-do-you-break-out-of-a-windows-form-button-click-event?forum=winforms
                        }
                        StreamWriter WritingRecords = new StreamWriter("UserAccounts.txt"); //Opens UserAccounts.txt using StreamWriter named WritingRecords 

                        //The following lines of code use the DateTime and TimeSpan library which contain classes and methods that can deal with time
                        //--
                        //The following line uses the TimeSpan Library to store the time given by user in dateTimePicker1 into a variable of type TimeSpan named ReturnTime
                        //.TimeOfDay is property of dateTimePicker which return the time specifed by user without the date. 
                        TimeSpan ReturnTime = dateTimePicker2.Value.TimeOfDay;
                        //The Following line of code uses the DateTime library which stores the date selected by user via the dateTimePicker into a variable named ReturnDay of type DateTime
                        DateTime ReturnDay = dateTimePicker1.Value;
                        //The Following line of code adds the time specified by user stored in ReturnTime to the Day specified by user stored in Return Day
                        //Together this creates a date and time at which the user must return the book
                        //This value is stored in a variable named ReturnDate of type DateTime
                        DateTime ReturnDate = ReturnDay.Add(ReturnTime);
                        //These Concepts were taken from:
                        //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.application.exit?view=windowsdesktop-7.0
                        //https://www.codeproject.com/Questions/778932/How-to-get-time-value-from-DateTimePicker
                        //--

                        bool UsernameFound = false;//bool variable named UsernameFound used to identify whether or not the username is already in the record
                        for (int index = 0; index < Record.Length; index++)//A for loop in which index starts at 0. It will increment by 1 each time and the for loop will play until index is less then the length or the Record Array
                        {
                            if (Record[index] == Username)//This if statement will play if element stored in Record[index] = Username
                                                          //This if statement basically checks if the user's record has already been written inside UserAccounts
                                                          //This just makes sure that the program is not writing the same user's records over and over again and just edits the one already done
                            {
                                UsernameFound = true;//changes UsernameFound to trye
                                WritingRecords.WriteLine(Username);//Writes the username in the file on a new line
                                WritingRecords.WriteLine(Books[BookName]);//Writes the name of book (Books[BookName]) in the file on a new line
                                WritingRecords.WriteLine(ReturnDate);//Writes the ReturnDate in the file on a new line
                                WritingRecords.WriteLine("");//Leaves a blank line in the file on a new line
                                MessageBox.Show("You have comitted to return the book before " + ReturnDate);
                                //Reminds user of the date they have comitted to return the book before
                                index += 3;// increments index by 3 as the next 3 lines have already been written. Hence, the program moves on to the next user
                            }
                            else
                            {
                                WritingRecords.WriteLine(Record[index]);
                                //For all iterations that program does not find username in the Record array, the program will exactly copy the elements stored in Record[index] on the file so that the data stays the same
                            }
                        }
                        if (UsernameFound == false)//This if statement will run if the Username has not been found (UsernameFound = false)
                        {
                            //This next few lines will be written at the end of the file
                            WritingRecords.WriteLine(Username);//;//Writes the username in the file on a new line
                            WritingRecords.WriteLine(Books[BookName]);//Writes the name of book (Books[BookName]) in the file on a new line
                            WritingRecords.WriteLine(ReturnDate);//Writes the ReturnDate in the file on a new line
                            WritingRecords.WriteLine("");//Leaves a blank line in the file on a new line
                            MessageBox.Show("You have comitted to return book before " + ReturnDate);
                            //Reminds user of the date they have comitted to return the book before
                        }
                        WritingRecords.Close();
                    }
                    else
                    //This else statement will run if PlayLoop was false
                    //This means that user has already checked out one book 
                    {
                        MessageBox.Show("You've already checked out " + CheckoutBook + ", Please return it before checking out another one!");
                        //Notifes user of the book that they've already checked out and that they must return it first
                    }
                }
            //Ritisha's Code Ends-----------------------------------------------------------------------------------------------

            //Danial's Code Starts:-------------------------------------------------------------------------------------------------
            bool check = long.TryParse(txtISBN.Text, out long ParsedInput);//Sets a bool check to a long try parse since the ISBN number is considered longer than the integer limit long is a suitable datatype and to check if the txtISBN.Text option which is the secondary option of checking ISBN and outing it as ParsedInput if it is convertable to long.

            if (check == true)//If the txtISBN.Text is able to convert to long datatype it will continue to do the following.
            {
                if (txtISBN.Text.Length < 13 || txtISBN.Text.Length > 13)//If the length is less than or greater than 13 it will ask the user to try again.
                {
                    MessageBox.Show("Please try again");//shows a message box to the user4
                }
                else if (txtISBN.Text != "9780735211292" && txtISBN.Text != "9781538762738" && txtISBN.Text != "9781501133862" && txtISBN.Text != "9781250182265" && txtISBN.Text != "9781501138799" && txtISBN.Text != "9780765395115" && txtISBN.Text != "9781982127480" && txtISBN.Text != "9780316018708" && txtISBN.Text != "9780312558352" && txtISBN.Text != "9781250151360")//check if its not a valid ISBN number and then does the following
                {
                    MessageBox.Show("This is not the desired ISBN number");//Shows a message box to the user that they shoudl reenter since it is not desired ISBN number.
                }
                else if (txtISBN.Text == "9780735211292")//This will be where it is a valid ISBN and based on which isbn it will change the picturebox and label accordingly and the updated quantity, rating, author, title , and etc.
                {
                    //This sets the label if the ISBN is correspondant to Atomic habits which it is to the title, author, text, published, publisher, rating, quantity, and pictureboxCover whent he user clicks on check
                    lblTitle.Text = "Atomic Habits";
                    lblAuthor.Text = "James Clear";
                    lblPublished.Text = "08/08/18";
                    lblPublisher.Text = "Penguin Random House";
                    lblRating.Text = "?/10";
                    lblQuantity.Text = "1";
                    pictureBox_Cover.Image =
                        Image.FromStream(typeof(frmBookCheckList).Assembly.GetManifestResourceStream("Island_Boi.Resources.atomichabitscover.jpg"));
                    pictureBox_Cover.Refresh();//Refreshes the picturebox in order to update the images and the picturebox is set to zoom.
                    StreamWriter sw3 = new StreamWriter("BookCheckout.txt");//This is part of the file.IO library where it writes in the BookCheckout.txt file in the file directory the following.
                    //It writes the title, author, published, publisher, rating, quantity, and sets a string to the name of the cover image, and adds the ISBN.
                    sw3.WriteLine(lblTitle.Text);
                    sw3.WriteLine(lblAuthor.Text);
                    sw3.WriteLine(lblPublished.Text);
                    sw3.WriteLine(lblPublisher.Text);
                    sw3.WriteLine(lblRating.Text);
                    sw3.WriteLine(lblQuantity.Text);
                    sw3.WriteLine("atomichabitscover.jpg");
                    sw3.WriteLine(txtISBN.Text);
                    string[] Record2 = File.ReadAllLines("UserAccounts.txt");//This reads all line in the file and sets each line as part of an string array in the file UserAccounts.txt found in the directory.

                    sw3.Close();//Closes writing the file.
                    using (StreamWriter sw4 = new StreamWriter("BookRating.txt"))//Starts writing in the bookRating.txt file the following but uses using so it can actively add values without fully closing and erasing the previously given info.
                    {
                        //Writes the title, and rating and then closes the file.
                        sw4.WriteLine(lblTitle.Text);
                        sw4.WriteLine(lblRating.Text);
                        sw4.Close();
                    }
                }

                else if (txtISBN.Text == "9781538762738")//This will be where it is a valid ISBN and based on which isbn it will change the picturebox and label accordingly and the updated quantity, rating, author, title , and etc.
                {
                    //Its the same principle as the previous lines of codes but for the second book Blood orange.
                    lblTitle.Text = "Blood Orange";
                    lblAuthor.Text = "Harriet Tyce";
                    lblPublished.Text = "01/10/19";
                    lblPublisher.Text = "Grand Central Publishing";
                    lblRating.Text = "?/10";
                    lblQuantity.Text = "1";
                    pictureBox_Cover.Image =
                        Image.FromStream(typeof(frmBookCheckList).Assembly.GetManifestResourceStream("Island_Boi.Resources.51TYAMkpUgL.jpg"));
                    pictureBox_Cover.Refresh();
                    StreamWriter sw3 = new StreamWriter("BookCheckout.txt");
                    sw3.WriteLine(lblTitle.Text);
                    sw3.WriteLine(lblAuthor.Text);
                    sw3.WriteLine(lblPublished.Text);
                    sw3.WriteLine(lblPublisher.Text);
                    sw3.WriteLine(lblRating.Text);
                    sw3.WriteLine(lblQuantity.Text);
                    sw3.WriteLine("51TYAMkpUgL.jpg");
                    sw3.WriteLine(txtISBN.Text);
                    string[] Record2 = File.ReadAllLines("UserAccounts.txt");

                    sw3.Close();
                    using (StreamWriter sw4 = new StreamWriter("BookRating.txt", true))
                    {
                        sw4.WriteLine(lblTitle.Text);
                        sw4.WriteLine(lblRating.Text);
                        sw4.Close();
                    }

                }

                else if (txtISBN.Text == "9781501133862")//This will be where it is a valid ISBN and based on which isbn it will change the picturebox and label accordingly and the updated quantity, rating, author, title , and etc.
                {
                    //Its the same principle as the previous lines of codes but for the third book DarkTown.
                    lblTitle.Text = "DARKTOWN";
                    lblAuthor.Text = "Thomas Mullen";
                    lblPublished.Text = "09/13/16";
                    lblPublisher.Text = "Simon and Schuster";
                    lblRating.Text = "?/10";
                    lblQuantity.Text = "1";
                    pictureBox_Cover.Image =
                        Image.FromStream(typeof(frmBookCheckList).Assembly.GetManifestResourceStream("Island_Boi.Resources.Darktowncover.jpg"));
                    pictureBox_Cover.Refresh();
                    StreamWriter sw3 = new StreamWriter("BookCheckout.txt");
                    sw3.WriteLine(lblTitle.Text);
                    sw3.WriteLine(lblAuthor.Text);
                    sw3.WriteLine(lblPublished.Text);
                    sw3.WriteLine(lblPublisher.Text);
                    sw3.WriteLine(lblRating.Text);
                    sw3.WriteLine(lblQuantity.Text);
                    sw3.WriteLine("Darktowncover.jpg");
                    sw3.WriteLine(txtISBN.Text);
                    string[] Record2 = File.ReadAllLines("UserAccounts.txt");

                    sw3.Close();
                    using (StreamWriter sw4 = new StreamWriter("BookRating.txt", true))
                    {
                        sw4.WriteLine(lblTitle.Text);
                        sw4.WriteLine(lblRating.Text);
                        sw4.Close();
                    }
                }

                else if (txtISBN.Text == "9781250182265")//This will be where it is a valid ISBN and based on which isbn it will change the picturebox and label accordingly and the updated quantity, rating, author, title , and etc.
                {
                    //Its the same principle as the previous lines of codes but for the fourth book Lies.
                    lblTitle.Text = "LIES";
                    lblAuthor.Text = "T.M. Logan";
                    lblPublished.Text = "01/17/17";
                    lblPublisher.Text = "St. Martin's Press";
                    lblRating.Text = "?/10";
                    lblQuantity.Text = "1";
                    pictureBox_Cover.Image =
                        Image.FromStream(typeof(frmBookCheckList).Assembly.GetManifestResourceStream("Island_Boi.Resources.LiesCover.jpg"));
                    pictureBox_Cover.Refresh();
                    StreamWriter sw3 = new StreamWriter("BookCheckout.txt");
                    sw3.WriteLine(lblTitle.Text);
                    sw3.WriteLine(lblAuthor.Text);
                    sw3.WriteLine(lblPublished.Text);
                    sw3.WriteLine(lblPublisher.Text);
                    sw3.WriteLine(lblRating.Text);
                    sw3.WriteLine(lblQuantity.Text);
                    sw3.WriteLine("LiesCover.jpg");
                    sw3.WriteLine(txtISBN.Text);
                    string[] Record2 = File.ReadAllLines("UserAccounts.txt");

                    sw3.Close();
                    using (StreamWriter sw4 = new StreamWriter("BookRating.txt", true))
                    {
                        sw4.WriteLine(lblTitle.Text);
                        sw4.WriteLine(lblRating.Text);
                        sw4.Close();
                    }
                }

                else if (txtISBN.Text == "9781501138799")//This will be where it is a valid ISBN and based on which isbn it will change the picturebox and label accordingly and the updated quantity, rating, author, title , and etc.
                {
                    //Its the same principle as the previous lines of codes but for the fifth book Lightinign men.
                    lblTitle.Text = "LIGHTNING MEN";
                    lblAuthor.Text = "Thomas Mullen";
                    lblPublished.Text = "09/12/17";
                    lblPublisher.Text = "Simon and Schuster";
                    lblQuantity.Text = "1";
                    lblRating.Text = "?/10";
                    pictureBox_Cover.Image =
                        Image.FromStream(typeof(frmBookCheckList).Assembly.GetManifestResourceStream("Island_Boi.Resources.LightningMenCover.jpg"));
                    pictureBox_Cover.Refresh();
                    StreamWriter sw3 = new StreamWriter("BookCheckout.txt");
                    sw3.WriteLine(lblTitle.Text);
                    sw3.WriteLine(lblAuthor.Text);
                    sw3.WriteLine(lblPublished.Text);
                    sw3.WriteLine(lblPublisher.Text);
                    sw3.WriteLine(lblRating.Text);
                    sw3.WriteLine(lblQuantity.Text);
                    sw3.WriteLine("LightningMenCover.jpg");
                    sw3.WriteLine(txtISBN.Text);
                    string[] Record2 = File.ReadAllLines("UserAccounts.txt");

                    sw3.Close();
                    using (StreamWriter sw4 = new StreamWriter("BookRating.txt", true))
                    {
                        sw4.WriteLine(lblTitle.Text);
                        sw4.WriteLine(lblRating.Text);
                        sw4.Close();
                    }
                }

                else if (txtISBN.Text == "9780765395115")//This will be where it is a valid ISBN and based on which isbn it will change the picturebox and label accordingly and the updated quantity, rating, author, title , and etc.
                {
                    //Its the same principle as the previous lines of codes but for the Sixth book Nomad.
                    lblTitle.Text = "NOMAD";
                    lblAuthor.Text = "James Swallow";
                    lblPublished.Text = "06/02/16";
                    lblPublisher.Text = "Forge Books";
                    lblRating.Text = "?/10";
                    lblQuantity.Text = "1";
                    pictureBox_Cover.Image =
                        Image.FromStream(typeof(frmBookCheckList).Assembly.GetManifestResourceStream("Island_Boi.Resources.NomadCover.jpg"));
                    pictureBox_Cover.Refresh();
                    StreamWriter sw3 = new StreamWriter("BookCheckout.txt");
                    sw3.WriteLine(lblTitle.Text);
                    sw3.WriteLine(lblAuthor.Text);
                    sw3.WriteLine(lblPublished.Text);
                    sw3.WriteLine(lblPublisher.Text);
                    sw3.WriteLine(lblRating.Text);
                    sw3.WriteLine(lblQuantity.Text);
                    sw3.WriteLine("NomadCover.jpg");
                    sw3.WriteLine(txtISBN.Text);
                    string[] Record2 = File.ReadAllLines("UserAccounts.txt");

                    sw3.Close();
                    using (StreamWriter sw4 = new StreamWriter("BookRating.txt", true))
                    {
                        sw4.WriteLine(lblTitle.Text);
                        sw4.WriteLine(lblRating.Text);
                        sw4.Close();
                    }
                }

                else if (txtISBN.Text == "9781982127480")//This will be where it is a valid ISBN and based on which isbn it will change the picturebox and label accordingly and the updated quantity, rating, author, title , and etc.
                {
                    //Its the same principle as the previous lines of codes but for the Seventh book PLease see us.
                    lblTitle.Text = "PLEASE SEE US";
                    lblAuthor.Text = "Caitlin Mullen";
                    lblPublished.Text = "03/03/20";
                    lblPublisher.Text = "Gallery Books";
                    lblRating.Text = "?/10";
                    lblQuantity.Text = "1";
                    pictureBox_Cover.Image =
                        Image.FromStream(typeof(frmBookCheckList).Assembly.GetManifestResourceStream("Island_Boi.Resources.PleaseSeeUsCover.jpg"));
                    pictureBox_Cover.Refresh();
                    StreamWriter sw3 = new StreamWriter("BookCheckout.txt");
                    sw3.WriteLine(lblTitle.Text);
                    sw3.WriteLine(lblAuthor.Text);
                    sw3.WriteLine(lblPublished.Text);
                    sw3.WriteLine(lblPublisher.Text);
                    sw3.WriteLine(lblRating.Text);
                    sw3.WriteLine(lblQuantity.Text);
                    sw3.WriteLine("PleaseSeeUsCover.jpg");
                    sw3.WriteLine(txtISBN.Text);
                    string[] Record2 = File.ReadAllLines("UserAccounts.txt");

                    sw3.Close();
                    using (StreamWriter sw4 = new StreamWriter("BookRating.txt", true))
                    {
                        sw4.WriteLine(lblTitle.Text);
                        sw4.WriteLine(lblRating.Text);
                        sw4.Close();
                    }
                }

                else if (txtISBN.Text == "9780316018708")//This will be where it is a valid ISBN and based on which isbn it will change the picturebox and label accordingly and the updated quantity, rating, author, title , and etc.
                {
                    //Its the same principle as the previous lines of codes but for the eight book Sail.
                    lblTitle.Text = "SAIL";
                    lblAuthor.Text = "James Patterson";
                    lblPublished.Text = "06/09/08";
                    lblPublisher.Text = "Grand Central Publishing";
                    lblRating.Text = "?/10";
                    lblQuantity.Text = "1";
                    pictureBox_Cover.Image =
                        Image.FromStream(typeof(frmBookCheckList).Assembly.GetManifestResourceStream("Island_Boi.Resources.SailCoverv2.jpg"));
                    pictureBox_Cover.Refresh();
                    StreamWriter sw3 = new StreamWriter("BookCheckout.txt");
                    sw3.WriteLine(lblTitle.Text);
                    sw3.WriteLine(lblAuthor.Text);
                    sw3.WriteLine(lblPublished.Text);
                    sw3.WriteLine(lblPublisher.Text);
                    sw3.WriteLine(lblRating.Text);
                    sw3.WriteLine(lblQuantity.Text);
                    sw3.WriteLine("SailCoverv2.jpg");
                    sw3.WriteLine(txtISBN.Text);
                    string[] Record2 = File.ReadAllLines("UserAccounts.txt");

                    sw3.Close();
                    using (StreamWriter sw4 = new StreamWriter("BookRating.txt", true))
                    {
                        sw4.WriteLine(lblTitle.Text);
                        sw4.WriteLine(lblRating.Text);
                        sw4.Close();
                    }
                }

                else if (txtISBN.Text == "9780312558352")//This will be where it is a valid ISBN and based on which isbn it will change the picturebox and label accordingly and the updated quantity, rating, author, title , and etc..
                {
                    //Its the same principle as the previous lines of codes but for the ninth book Slow fire.
                    lblTitle.Text = "SLOW FIRE";
                    lblAuthor.Text = "Ken Mercer";
                    lblPublished.Text = "01/01/10";
                    lblPublisher.Text = "Minotaur Books";
                    lblRating.Text = "?/10";
                    lblQuantity.Text = "1";
                    pictureBox_Cover.Image =
                        Image.FromStream(typeof(frmBookCheckList).Assembly.GetManifestResourceStream("Island_Boi.Resources.SlowFireCoverv2.jpg"));
                    pictureBox_Cover.Refresh();
                    StreamWriter sw3 = new StreamWriter("BookCheckout.txt");
                    sw3.WriteLine(lblTitle.Text);
                    sw3.WriteLine(lblAuthor.Text);
                    sw3.WriteLine(lblPublished.Text);
                    sw3.WriteLine(lblPublisher.Text);
                    sw3.WriteLine(lblRating.Text);
                    sw3.WriteLine(lblQuantity.Text);
                    sw3.WriteLine("SlowFireCoverv2.jpg");
                    sw3.WriteLine(txtISBN.Text);
                    string[] Record2 = File.ReadAllLines("UserAccounts.txt");

                    sw3.Close();
                    using (StreamWriter sw4 = new StreamWriter("BookRating.txt", true))
                    {
                        sw4.WriteLine(lblTitle.Text);
                        sw4.WriteLine(lblRating.Text);
                        sw4.Close();
                    }
                }

                else if (txtISBN.Text == "9781250151360")//This will be where it is a valid ISBN and based on which isbn it will change the picturebox and label accordingly and the updated quantity, rating, author, title , and etc.
                {
                    //Its the same principle as the previous lines of codes but for the tenth bookThe Dilemma.
                    lblTitle.Text = "THE DILEMMA";
                    lblAuthor.Text = "B.A. Paris";
                    lblPublished.Text = "01/01/19";
                    lblPublisher.Text = "St. Martin's Press";
                    lblRating.Text = "?/10";
                    lblQuantity.Text = "1";
                    pictureBox_Cover.Image =
                        Image.FromStream(typeof(frmBookCheckList).Assembly.GetManifestResourceStream("Island_Boi.Resources.TheDilemmaCoverv2.jpg"));
                    pictureBox_Cover.Refresh();
                    StreamWriter sw3 = new StreamWriter("BookCheckout.txt");
                    sw3.WriteLine(lblTitle.Text);
                    sw3.WriteLine(lblAuthor.Text);
                    sw3.WriteLine(lblPublished.Text);
                    sw3.WriteLine(lblPublisher.Text);
                    sw3.WriteLine(lblRating.Text);
                    sw3.WriteLine(lblQuantity.Text);
                    sw3.WriteLine("TheDilemmaCoverv2.jpg");
                    sw3.WriteLine(txtISBN.Text);
                    string[] Record2 = File.ReadAllLines("UserAccounts.txt");

                    sw3.Close();
                    using (StreamWriter sw4 = new StreamWriter("BookRating.txt", true))
                    {
                        sw4.WriteLine(lblTitle.Text);
                        sw4.WriteLine(lblRating.Text);
                        sw4.Close();
                    }
                }
            }
            else//else the user entered incorrect or unnecasry characters that werent able to convert to an long it does the following
            {
                MessageBox.Show("Error. Remove unnecessary characters that are not numbers");// through a message box it tells the user there is an error and to remove those unnecessary characters.
            }
        }
        //Danial's Code Ends-----------------------------------------------------------------------------------------------------

        //Ritisha's Code Starts----------------------------------------------------------------------------
        public bool Appending(ref string[] Recieve, string BookName, bool Recieve2)
        //Purpose: The purpose of this method is to change values in the string array that stores BookFile.txt's data, to make the book eitehr unavailable or available
            //This method will also return a bool value stating whether or not the book was available or has already been retruned
            //In both cases the program will notify the user and not move forward with re-printing book files
            //Moreover, since this method is for both checkout and return, if when called Recieve2 = true, then the method will treat it as if its for checkout
            //However, if its false, the method will treat it as if it's for return
        {
            for (int Index = 0; Index < Recieve.Length - 1; Index++)
                //A for loop that starts at 0, incrememnts by 1 each time. It will iterate for as long as Index is less that 1 - the length of Recieve            
            {
                if (Recieve[Index] == BookName)
                    //This if statement will run if Recieve[Index] is equal to BookName
                {
                    if (Recieve2)
                        //This if statement will run if Recieve2 is true
                        //This means that this method was called for Checkout
                        //Hence book needs to be changed from Available to Unavailable
                    {
                        if (Recieve[Index + 1] == "Available")
                            //this if statement will run if Recieve[Index + 1] == Available
                            //this is to make sure that the books were Available
                            //Hence, eliminating scenarios in which multiple users can checkout the same book
                        {
                            //status change
                            Recieve[Index + 1] = "Unavailable";//The element value is changed from Unavaiable to Available
                            //methods returns true as book was available
                            return true;
                        }
                        else
                        //If the book wasn't available, that means a user has already checked it out
                        //Hence user must be notified
                        {
                            //User is notified
                            MessageBox.Show("This Book is Unavailable");
                            //Method returns false as book was unavailable
                            return false;
                        }

                    }
                    else
                    //This will run if Recieve2 was false
                    //This means that the method was called for returnn
                    //Hence status must be changed from Unavailable to Available
                    {
                        if (Recieve[Index + 1] == "Unavailable")
                        //this if statement will run if Recieve[Index + 1] == Unavailable
                        //this is to make sure that the books were Unvailable
                        //Hence, eliminating scenarios in which user keeps returning a book without being sure if its already returned
                        {
                            Recieve[Index + 1] = "Available";//changes element in array from Unavailable to Avaiable as book has been returned
                            MessageBox.Show("Book has been Returned!");
                            //notifies user that book has been returned
                            //methods returns true as book was not already returned 
                            return true;
                        }
                        else
                        //If the book wasn't Unavailable, that means a user has already returned it
                        //Hence user must be notified
                        {
                            //User is notfied
                            MessageBox.Show("This book has already been returned");
                            //Method returns false as book was already returned
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public bool SyncCheck(string[] Recieve, string[] Recieve2)
            //Purpose:
            //Takes two string array parameters that store the data of UserAccounts.txt and BookFile.txt. It basically validates whether both of them have data that makes sense
            //Approach:
            //Program will go through the the array of BookFile.txt and check whatever books are unavaiable.
            //next it will go through the array of UserAccounts.txt to check if that book has been recorded there which indicates that it has been checked out by someone
        {
            bool Return = true;//variable that will store the return value
            for (int Index = 2; Index < Recieve.Length; Index += 4)
            //for loop starting at 2, incrementing by 4 each time and iterating until Index < Recieve.Length
            {
                if (Recieve[Index] == "Unavailable")
                //Will run when program detecs Unavailable in the array
                {
                    //Used to store book's name as book name will be in the line before in UserAccounts
                    string BookSelected = Recieve[Index - 1];
                    //variable used to determine if book has been found or not
                    bool BookFound = false;
                    for (int Index2 = 0; Index2 < Recieve2.Length; Index2++)
                    //for loop starting at 0, increments by 1 and iterates until Index2 < Recieve2's length
                    {
                        if (Recieve2[Index2] == BookSelected)//will run if program finds book name in Recieve2[Index]
                        {
                            BookFound = true;
                            //value of BookFound set to true
                        }
                    }
                    if (BookFound == false)//will run if bookFound reamined false and never changed to true
                    {
                        Return = false;//If book hasn't been found in UserAccounts.txt, that means that file has been damaged. Hence, false is set to return value
                    }
                }
            }
            return Return;//the value inside Return is returned where the method is called 
        }
    

        public bool FileCheck(string[] Recieve)
        //Purpose:
        //This method takes one string array parameter to check if the elements stored in that array which are from BookFile.txt are in the desired format
        //Approach: It first checks if the length of the file is 39-40 lines (which should be the ammount of lines in the file). Then. it validates whether at every 4th index there is an ISBN number that starts with 978 using string manipulation
        //Third, it looks if at every 2 lines after ISBN number is written Available or Unavailable
        //This makes sure no one has tampered with file (added extra space, deleted ISBN numbers, deleted a space, deleted a book detail)
        {
            if (Recieve.Length != 40 && Recieve.Length != 39)//This if statement will run if the length of array given by user is not 55-56 in length
            {
                return false;//Automatically returns as false
            }
            bool Return = true;//a bool variable used as the return value for this method
            for (int Index = 0; Index < Recieve.Length; Index += 4)//for loop that starts at 0 , increments by 4 each time and iterates until Index is less than length of Recieve
            //Increments by 4 as ISBN numbers should be stored on every 4th line for the correct format
            {
                //Uses string manipulation to seperate the first 3 numbers of the ISBN number
                string Code = Recieve[Index].Substring(0, 3);
                //Creates a string variable to store value two lines after ISBN that should record the availability
                string Availibility = Recieve[Index + 2];

                if (Code != "978")//will run if Code does not equal 978
                {
                    Return = false;//Return is set to false as ISBN is not in the required format
                }
                else if (!(Availibility == "Available" || Availibility == "Unavailable"))
                //will run if Availability is not Available or Unavailable 
                {
                    Return = false;
                    //Return is set to false
                }

            }
            //value of Return is returned by the method 
            return Return;
        }
        //Ritisha's Code Ends-------------------------------------------------------------------


        //Danial's Code Starts--------------------------------------------------------------------
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            txtISBN.Text = txtDisplay.Text;

        }//Danial's Code Ends----------------------------------------------------------------------------------

        //Ritisha's Code Starts-------------------------------------------------------------------------
        private void btnReturn_Click(object sender, EventArgs e)
        {
            //The following three lines of code will read the file CurrentLogin.txt to find the username of the current user
            //The Login forms would have uploaded this data into that file!
            StreamReader ReadingUsername = new StreamReader("CurrentLogin.txt");//Opens up StreamReader and the file named CurrentLogin.txt
            string Username = ReadingUsername.ReadLine();//Reads the first line stored in the file and assigns a string variable named Username to that variable
            ReadingUsername.Close();//Closes the process

            bool BookFound = false; //bool variable named BookFound used to determine if the Book has been found or not in BookFile. 
            int BookName = 0; //int variable used to determine the index that the Book's Name will be stored in, in the books array
            string[] Books = File.ReadAllLines("BookFile.txt"); //An Array that will read all lines in BookFile.txt and store values into a string array
            string[] Record = File.ReadAllLines("UserAccounts.txt");//An Array that will read all lines in UserAccounts.txt and store values into a string array
                                                                    //THE CONCEPT ABOVE WAS TAKEN FROM: 

            if (FileCheck(Books) == false || SyncCheck(Books, Record) == false)
            //This if statements will run if any of either methods FileCheck() or SyncCheck() return a false value.
            //If they do then that is a clear indicator of a damaged file
            {
                MessageBox.Show("File Error");//Notifies user that File is damamged
                Application.Exit();
                return;//Breaks from btnCheckout_Click().
                //THIS CONCEPT WAS TAKEN FROM: https://social.msdn.microsoft.com/Forums/windows/en-US/df0c4a7c-2134-45d0-b075-f78762e54840/how-do-you-break-out-of-a-windows-form-button-click-event?forum=winforms
            }


            for (int Index = 0; Index < Books.Length; Index += 4)
            //for loop in which Index starts at 0 and increments by 4 after each iteration
            //This loop will run until Index is less than Books.Length
            {
                if (Books[Index] == txtISBN.Text)
                {
                    BookName = Index + 1;
                    BookFound = true;
                }
            }
            if (!BookFound)
            {
                MessageBox.Show("Book Not Found");
            }
            else
            {
                string[] Record2 = File.ReadAllLines("UserAccounts.txt");//An Array that will read all lines in UserAccounts.txt and store values into a string array
                //The above line work in the way that File.ReadAllLines automatically creates an array of the same amount of lines as in the specific file and stores every line as an element in the array
                //For ex. line 1 will be stored in the first element of the array (at index 0)
                //THE CONCEPT ABOVE WAS TAKEN FROM: https://www.geeksforgeeks.org/file-readalllinesstring-method-in-c-sharp-with-examples/

                StreamWriter ReadingHistory = new StreamWriter("UserAccounts.txt");//Opens UserAccounts.txt using StreamWriter named WritingRecords 
                //The following uses the DateTime library to create a vraible named ReturnDate that stores the value returned by DateTime.Now which indicated the current date and time
                DateTime ReturnDate = DateTime.Now;
                //THIS CONCEPT WAS TAKEN FROM: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.application.exit?view=windowsdesktop-7.0
                //And Also: https://www.codeproject.com/Questions/778932/How-to-get-time-value-from-DateTimePicker
                for (int Index = 0; Index < Record2.Length; Index++)//A for loop that starts at 0 and incrememnts by 1 each time. It keeps iterating until the value of Index is less than Records.Length
                {
                    if (Record2[Index] == Books[BookName])//This if statement will play when program finds an element in Record2 that is the name of the book wanting to be checked out by user
                    {
                        //The following uses the dateTime Library to create a variable named CurrentDate which stores the date at which book was supposed to eb returned
                        //It does this by reading the next line (this is because due date is stored after book name) 
                        //It also uses DateTime.Parse to convert value stored in Record2[Index + 1] into a DateTime value \
                        //Concept Taken From: https://learn.microsoft.com/en-us/dotnet/api/system.datetime.parse?view=net-7.0
                        DateTime CurrentDate = DateTime.Parse(Record2[Index + 1]);
                        if (CurrentDate < ReturnDate)//if the CurrentDate is less than ReturnDate then this block will play
                                                     //This means that user did not return book on time
                        {
                            //Overdue message
                            MessageBox.Show("This book is overdue!");
                            MessageBox.Show("You are required to complete 10 Pushups!");
                            lblQuantity.Text = "0";
                            
                        }
                        //Writes Checkout Empty to erase user record and playes "Due|" as a placeholder for the due date for user's next checkout
                        ReadingHistory.WriteLine("Checkout Empty");
                        ReadingHistory.WriteLine("Due|");
                        ReadingHistory.WriteLine("");
                        Index += 2;//increments index by 2
                    }
                    else
                    //For every iteration that Record2[Index] is not the name of the book, the program will copy the elements written in Record[index] in the file
                    {
                        ReadingHistory.WriteLine(Record[Index]);
                    }
                }
                ReadingHistory.Close();//Closes the process 
                bool BookAvailable = false;//Variable used as a parameter for Appending
                if (Appending(ref Books, Books[BookName], BookAvailable))//Validates if value returned by Appending() is true or not
                                                                         //if true this block will be run
                {
                    StreamWriter BooksRewrite = new StreamWriter("BookFile.txt");
                    for (int Index = 0; Index < Books.Length; Index++)//will run for as long as the length of Books[]
                    {
                        BooksRewrite.WriteLine(Books[Index]);//will write the string value stored at every index of Books[] 
                    }
                    BooksRewrite.Close();//closes the process
                }

            }
            //Ritisha's Code Ends------------------------------------------------------------------------------------

        }
    }
    
}
