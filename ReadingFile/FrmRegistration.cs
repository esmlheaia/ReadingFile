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
using System.IO;

namespace ReadingFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            
            String[] list = new string[7]; // Declare an array to hold the user input
            list[0] = "Student No. " + txtStudentNo.Text; // Get user input from the text box
            list[1] = "FullName: " + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMI.Text; // Get user input from the text box
            list[2] = "Program: " + cmbProgram.Text;
            list[3] = "Gender: " + cmbGender.Text;
            list[4] = "Age: " + txtAge.Text;
            list[5] = "Birthday: " + dateBirth.Value.ToString("yyyy-MM-dd");
            list[6] = "Contact No.: " + txtContactNo.Text;

            


        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord record = new FrmStudentRecord(); //create an instance of FrmStudentRecord
            record.ShowDialog(); //show the student record form as a dialog

           
        }
    }
}