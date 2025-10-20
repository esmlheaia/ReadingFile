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


namespace ReadingFile
{
    public partial class FrmOpenTextFile : Form
    {
        public FrmOpenTextFile()
        {
            InitializeComponent();
        }
        public void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\"; 
            openFileDialog1.Title = "Browse Text Files"; 
            openFileDialog1.DefaultExt = "txt"; //default file extension
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 
            openFileDialog1.ShowDialog(); //open dialog
            String path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path)) //read the file
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null) //read line by line
                {
                    Console.WriteLine(_getText); 
                    lvShowText.Items.Add(_getText); //display the text to listview
                }
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayToList(); //call the method
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            FrmRegistration reg = new FrmRegistration(); //create an instance of FrmRegistration
            reg.ShowDialog(); //show the registration form as a dialog

            this.Hide(); //hide the current form
        }
    }
    
}
