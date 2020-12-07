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
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        private void SubmitClick(object sender, EventArgs e)
        {
            MessageBox.Show("click");
            User u = new User();
            u.Firstname = textBoxFName.Text;
            u.Lastname = textBoxLName.Text;

            string m = comboBoxMonth.SelectedItem.ToString();
            string d = comboBoxDay.SelectedItem.ToString();
            string y = comboBoxYear.SelectedItem.ToString();
            u.Gender = comboBoxGender.SelectedItem.ToString();
            u.DOB = "month " + m + " Day " + d + " year " + y;
            u.Email = textBoxEmail.Text;
            u.Password1 = textBoxPassword.Text;
            u.Password2 = textBoxRePassword.Text;
            u.SeQuestion = comboBoxSequrityQuestion.SelectedItem.ToString();
            u.SeAnswer = textBoxSequrityAnswer.Text;
            u.Address = textBoxAddress.Text;
            u.City = textBoxCity.Text;
            u.State = comboBoxState.SelectedItem.ToString();
            u.Zip = textBoxZipCode.Text;
            u.Phone = textBoxPhone.Text;
            u.Mobile = comboBoxMobile.SelectedItem.ToString();

            new InfoWindow(u).Show();



        }

        
    }
}
