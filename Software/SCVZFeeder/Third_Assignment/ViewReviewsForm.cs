using DBLayer;
using System;
using System.Windows.Forms;
using Third_Assignment.Repositories;

namespace Third_Assignment
{
    public partial class ViewReviewsForm : Form
    {
        private int mealID;

        public ViewReviewsForm(int mealID)
        {
            InitializeComponent();
            this.mealID = mealID;
        }

        private void ViewReviewsForm_Load(object sender, EventArgs e)
        {
            LoadReviews();
        }

        private void LoadReviews()
        {
            var reviews = ReviewRepository.GetReviewsByMealID(mealID);
            dgvReviews.DataSource = reviews;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedCells.Count > 0)
            {
                int rowIndex = dgvReviews.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvReviews.Rows[rowIndex];
                int reviewID = Convert.ToInt32(selectedRow.Cells["ReviewID"].Value);
                EditReviewForm editReviewForm = new EditReviewForm(reviewID);
                editReviewForm.ShowDialog();
                LoadReviews();
            }
            else
            {
                MessageBox.Show("Please select a review first.", "No review selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedCells.Count > 0)
            {
                int rowIndex = dgvReviews.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvReviews.Rows[rowIndex];
                int reviewID = Convert.ToInt32(selectedRow.Cells["ReviewID"].Value);
                var result = MessageBox.Show("Are you sure you want to delete this review?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteReview(reviewID);
                    LoadReviews();
                }
            }
            else
            {
                MessageBox.Show("Please select a review first.", "No review selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteReview(int reviewID)
        {
            string sql = $"DELETE FROM Review WHERE ReviewID = {reviewID}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
