using System;
using System.Windows.Forms;
using Third_Assignment.Models;
using Third_Assignment.Repositories;

namespace Third_Assignment
{
    public partial class EditReviewForm : Form
    {
        private int reviewID;
        private Review review;

        public EditReviewForm(int reviewID)
        {
            InitializeComponent();
            this.reviewID = reviewID;
            this.Load += new System.EventHandler(this.EditReviewForm_Load);
        }

        private void EditReviewForm_Load(object sender, EventArgs e)
        {
            // Fetch the review by its ID
            review = ReviewRepository.GetReviewByReviewID(reviewID);

            if (review != null)
            {
                scoreNumericUpDown.Value = review.Score;
                commentTextBox.Text = review.Comment;
            }
            else
            {
                MessageBox.Show("Review not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            review.Score = (int)scoreNumericUpDown.Value;
            review.Comment = commentTextBox.Text;

            ReviewRepository.UpdateReview(review);

            MessageBox.Show("Review updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
