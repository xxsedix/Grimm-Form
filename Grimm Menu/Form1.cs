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

namespace Grimm_Menu
{
    public partial class Form1 : Form
    {
        private MenuStrip mainMenu;
        //defined controller globaly so it can be accessed by other functions
        ControllerClass Cclass = new ControllerClass();

        public Form1()
        {
            //Set up the drop down menu
            InitializeComponent();
            mainMenu = new MenuStrip();
            MainMenuStrip = mainMenu;
            Controls.Add(mainMenu);

            ToolStripMenuItem mnuFile = new ToolStripMenuItem("File");
            mainMenu.Items.Add(mnuFile);
            ToolStripMenuItem mnuHelp = new ToolStripMenuItem("Help");
            mainMenu.Items.Add(mnuHelp);


            ToolStripMenuItem miOpen = new ToolStripMenuItem("Open");
            ToolStripMenuItem miSave = new ToolStripMenuItem("Save");
            ToolStripMenuItem miQuit = new ToolStripMenuItem("Quit");
            mnuFile.DropDownItems.Add(miOpen);
            mnuFile.DropDownItems.Add(miSave);
            mnuFile.DropDownItems.Add(miQuit);


            ToolStripMenuItem miAbout = new ToolStripMenuItem("About");
            mnuHelp.DropDownItems.Add(miAbout);

            miOpen.Click += MiOpen_Click;
            miSave.Click += MiSave_Click;
            miQuit.Click += MiQuit_Click;
            miAbout.Click += MiAbout_Click;

            ContextMenuStrip popup = new ContextMenuStrip();
            ToolStripMenuItem miUpperCase = new ToolStripMenuItem("Upper Case");
            ToolStripMenuItem miLowerCase = new ToolStripMenuItem("Lower Case");
            miUpperCase.Click += MiUpperCase_Click;
            miLowerCase.Click += MiLowerCase_Click;
            popup.Items.Add(miUpperCase);
            popup.Items.Add(miLowerCase);

            ContextMenuStrip = popup;
        }

        private void MiOpen_Click(object sender, EventArgs e)
        {
            //This is the reader object that will print to the screen
            readrtb.Text = Cclass.ReadFile();
        }

        private void MiSave_Click(object sender, EventArgs e)
        {
            //Save the text file you are currently editing and update read only rtb box
            ControllerClass.SaveFile(mainrtb.Text);
            readrtb.Text = mainrtb.Text;
        }
        private void MiQuit_Click(object sender, EventArgs e)
        {
            //Exit application
            Application.Exit();
        }
        private void MiAbout_Click(object sender, EventArgs e)
        {
            //Help box to let people know how to use the apk
            MessageBox.Show("This is an application to track vehicle maintenance history.\n" +
                "Enter a vehicles information and click append to add the data to your textfile.\n" +
                "You can edit existing files by opening the file from the dropdown menu and clicking edit." +
                "Saving without appending will overwrite the txt file. Enjoy tracking your vehicles history.");
        }

        private void MiUpperCase_Click(object sender, EventArgs e)
        {
            mainrtb.Text = mainrtb.Text.ToUpper();
        }

        private void MiLowerCase_Click(object sender, EventArgs e)
        {
            mainrtb.Text = mainrtb.Text.ToLower();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            //Clear the current txt box.
            mainrtb.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //Get information from the current txt fields and send it to the append function.
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            string tb3 = textBox3.Text;
            string tb4 = rtbService.Text;
            string tb5 = textBox4.Text;
            string txt = Cclass.AddService(tb5, tb1, tb2, tb3, tb4);
            //Refresh for the read only txt string.
            readrtb.Text = txt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Allows you to edit the file in the read window.
            mainrtb.Text = readrtb.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}