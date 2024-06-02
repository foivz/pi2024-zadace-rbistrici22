using System;
using System.Windows.Forms;
using Third_Assignment.Models;
using Third_Assignment.Repositories;

namespace Third_Assignment
{
    public partial class ReviewForm : Form
    {
        private int mealID;

        public ReviewForm(int mealID)
        {
            InitializeComponent();
            this.mealID = mealID;

            // Postavljanje placeholdera
            scoreComboBox.Items.Insert(0, "RATE");
            scoreComboBox.SelectedIndex = 0;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (scoreComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a rating before submitting.");
                return;
            }

            int score = int.Parse(scoreComboBox.SelectedItem.ToString());
            string comment = commentTextBox.Text;

            ReviewRepository.AddReview(new Review
            {
                MealID = mealID,
                Score = score,
                Comment = comment
            });
            MessageBox.Show("Review submitted successfully!");
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void scoreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler for scoreComboBox selection change, if needed
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
