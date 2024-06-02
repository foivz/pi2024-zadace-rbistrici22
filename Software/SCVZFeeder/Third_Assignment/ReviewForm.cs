using System;
using System.Collections.Generic;
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
        }

        /*private void ReviewForm_Load(object sender, EventArgs e)
        {
            LoadReviews();
        }

        private void LoadReviews()
        {
            try
            {
                List<Review> reviews = ReviewRepository.GetReviewsByMealID(mealID);
                dgvReviews.DataSource = reviews;
                dgvReviews.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void submitButton_Click(object sender, EventArgs e)
        {
            int score = (int)scoreNumericUpDown.Value;
            string comment = commentTextBox.Text;

            ReviewRepository.AddReview(new Review
            {
                MealID = mealID,
                Score = score,
                Comment = comment
            });
            MessageBox.Show("Review submitted successfully!");
            this.Hide();
            MainForm mealForm = new MainForm();
            mealForm.Show();

            //LoadReviews();  // Refresh the reviews after adding a new one
        }
    }
}
