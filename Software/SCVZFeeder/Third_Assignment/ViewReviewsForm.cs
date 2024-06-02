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
        }
    }
}
