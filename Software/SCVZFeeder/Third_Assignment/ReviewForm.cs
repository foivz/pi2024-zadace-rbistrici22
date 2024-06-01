using System;
using System.Windows.Forms;
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            int score = (int)scoreNumericUpDown.Value;
            string comment = commentTextBox.Text;

            ReviewRepository.AddReview(new Models.Review
            {
                MealID = mealID,
                Score = score,
                Comment = comment
            });
            MessageBox.Show("Review submitted successfully!");

            this.Close();
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            // Ako želite nešto učiniti pri učitavanju forme, dodajte kod ovdje.
        }
    }
}
