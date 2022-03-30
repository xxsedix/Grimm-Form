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
        public Form1()
        {
            InitializeComponent();
            mainMenu = new MenuStrip();
            MainMenuStrip = mainMenu;
            Controls.Add(mainMenu);

            ToolStripMenuItem mnuFile = new ToolStripMenuItem("File");
            mainMenu.Items.Add(mnuFile);
            ToolStripMenuItem mnuHelp = new ToolStripMenuItem("Help");
            mainMenu.Items.Add(mnuHelp);

            // adding menu items to the File menu
            ToolStripMenuItem miOpen = new ToolStripMenuItem("Open");
            ToolStripMenuItem miSave = new ToolStripMenuItem("Save");
            ToolStripMenuItem miExit = new ToolStripMenuItem("Exit");
            mnuFile.DropDownItems.Add(miOpen);
            mnuFile.DropDownItems.Add(miSave);
            mnuFile.DropDownItems.Add(miExit);

            // add one item to the Help menu
            ToolStripMenuItem miAbout = new ToolStripMenuItem("About");
            mnuHelp.DropDownItems.Add(miAbout);

            // set up the event handling. Do this by adding to the Click property for each menu item
            miOpen.Click += MiOpen_Click;       // specifying the function that will be used to handle clicking on MiOpen
            miSave.Click += MiSave_Click;
            miExit.Click += MiExit_Click;
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
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.InitialDirectory = "c:";
            dlgOpen.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.RestoreDirectory = true;
            string fname;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fname = dlgOpen.FileName;
                using (StreamReader reader = new StreamReader(fname))
                {
                    String text = reader.ReadToEnd();
                    readrtb.Text = text;
                }

            }
        }

        private void MiSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.InitialDirectory = "c:\\temp";
            dlgSave.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.RestoreDirectory = true;
            String fname;  // name of the file the user selected
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                fname = dlgSave.FileName;
                using (StreamWriter writer = new StreamWriter(fname))
                {
                    writer.WriteLine(mainrtb.Text);
                }
                MessageBox.Show("The file was written.");
            }
        }
        private void MiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an application to track vehicle maintenance history.");
        }

        private void MiUpperCase_Click(object sender, EventArgs e)
        {
            mainrtb.Text = mainrtb.Text.ToUpper();
        }

        private void MiLowerCase_Click(object sender, EventArgs e)
        {
            mainrtb.Text = mainrtb.Text.ToLower();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            mainrtb.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.InitialDirectory = "c:\\temp";
            dlgSave.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.RestoreDirectory = true;
            String fname;  // name of the file the user selected
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                fname = dlgSave.FileName;
                using (StreamWriter writer = new StreamWriter(fname))
                {
                    writer.WriteLine(mainrtb.Text);
                }
                MessageBox.Show("The file was written.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mainrtb.Text = readrtb.Text;
        }
    }
}