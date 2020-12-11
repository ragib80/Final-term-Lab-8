using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class InfoWindow : Form
    {
        public InfoWindow(User u)
        {
            InitializeComponent();

            string output = String.Format("First Name: {0}" +
                "\nLast Name: {1}" +
                "\nDate Of Birth: {2}" +
                "\nGender: {3}" +
                "\nEmail: {4}" +
                "\nPassword: {5}" +
                "\nRe- Typed password: {6}" +

                "\nSecurity Question: {7}" +
                "\nSecurity Answer: {8}" +
                "\nAddress: {9}" +
                 "\nCity: {10}" +
                 "\nState: {11}" +
                 "\nZip Code: {12}" +
                 "\nPhone: {13}" +
                 "\nCell Type: {14}", u.Firstname,u.Lastname, u.DOB, u.Gender, u.Email, u.Password1, u.Password2, u.SeQuestion, u.SeAnswer, u.Address, u.City, u.State, u.Zip, u.Phone, u.Mobile);

            richTextBox1.Text = output;
        }
    }
}
