using DBLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Third_Assignment.Models;
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
            // Load reviews related to the specific mealID from the database
            var reviews = ReviewRepository.GetReviewsByMealID(mealID);
            dgvReviews.DataSource = reviews;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedCells.Count > 0)
            {
                int rowIndex = dgvReviews.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvReviews.Rows[rowIndex];

                // Assuming ReviewID is in the first column
                int reviewID = Convert.ToInt32(selectedRow.Cells["ReviewID"].Value);

                EditReviewForm editReviewForm = new EditReviewForm(reviewID);
                editReviewForm.ShowDialog();

                // Reload reviews after editing
                LoadReviews();
            }
            else
            {
                MessageBox.Show("Please select a review first.", "No review selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedCells.Count > 0)
            {
                int rowIndex = dgvReviews.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvReviews.Rows[rowIndex];

                // Pretpostavljamo da je ReviewID u prvoj koloni
                int reviewID = Convert.ToInt32(selectedRow.Cells["ReviewID"].Value);

                var result = MessageBox.Show("Are you sure you want to delete this review?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteReview(reviewID);
                    LoadReviews(); // Osvježavanje liste nakon brisanja
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

    }

}
