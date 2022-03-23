using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
