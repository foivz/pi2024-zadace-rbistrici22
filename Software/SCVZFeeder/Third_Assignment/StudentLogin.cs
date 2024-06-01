using Third_Assignment.Models;
using Third_Assignment.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Third_Assignment
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text;
            string password = PasswordTxt.Text;

            // Provjera korisničkih podataka
            var student = StudentRepository.GetStudent(username);

            if (student != null && student.Password == password)
            {
                // Uspješna prijava
                MessageBox.Show("Login successful!");

                // Otvorite MainForm
                MainForm mainForm = new MainForm();
                mainForm.Show();

                // Sakrijte trenutnu formu
                this.Hide();
            }
            else
            {
                // Neuspješna prijava
                MessageBox.Show("Invalid username or password!");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Ne treba nikakva funkcionalnost ovdje jer nema eventa textBox1_TextChanged
            // Možeš ostaviti praznu metodu ili ju ukloniti ako nije potrebna
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Ne treba nikakva funkcionalnost ovdje jer nema eventa label1_Click
            // Možeš ostaviti praznu metodu ili ju ukloniti ako nije potrebna
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

