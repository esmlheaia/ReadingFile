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
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }
        private void DisplayToList()
        {
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration reg = new FrmRegistration(); //create an instance of FrmRegistration
            reg.ShowDialog(); //show the registration form as a dialog
            
        }

        private void btnFind_Click(object sender, EventArgs e) 
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); 
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Find Student Record";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) //open dialog
            {
                String path = openFileDialog1.FileName;
                lvRecord.Items.Clear();

                using (StreamReader reader = new StreamReader(path)) //read the file
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) //read line by line
                    {
                        lvRecord.Items.Add(line); //display the text to listview
                    }
                }
            }
        }


        private void btnUpload_Click(object sender, EventArgs e) //upload button
        {
            MessageBox.Show("Successfully Uploaded!"); //   show message box
            lvRecord.Items.Clear(); //clear the listview after upload
            this.Hide();
        }
    }
}
