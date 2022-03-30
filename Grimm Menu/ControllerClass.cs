using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Grimm_Menu
{
    class ControllerClass
    {
        //Function for adding to txt file

        public static void AddService(string date, string make, string model, string milage, string service)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.InitialDirectory = "c:\\temp";
            dlgSave.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.RestoreDirectory = true;
            String fname;
            ModelClass modelclass = new ModelClass(date, make, model, milage, service);
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                fname = dlgSave.FileName;
                using (StreamWriter writer = File.AppendText(fname))
                {
                    writer.WriteLine(modelclass.formatedService());
                }
                MessageBox.Show("The file was written.");

            }
        }

        public string ReadFile()
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
                    return text;
                }
            }
            else
            {
                return "Error finding text";
            }
        }

        public static void SaveFile(string text)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.InitialDirectory = "c:";
            dlgSave.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.RestoreDirectory = true;
            String fname;
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                fname = dlgSave.FileName;
                using (StreamWriter writer = new StreamWriter(fname))
                {
                    writer.WriteLine(text);
                }
                MessageBox.Show("The file was written.");
            }
        }
    }



//Function for saving

}
