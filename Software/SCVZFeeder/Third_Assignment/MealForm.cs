using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Third_Assignment.Models;
using Third_Assignment.Repositories;

namespace Third_Assignment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainForm_Load); // Ensure the event is associated
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<Meal> meals = MealRepository.GetMeals();
                dvgmeal.DataSource = meals;
                dvgmeal.Refresh(); // Ensure the DataGridView refreshes
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aMealForm_Load(object sender, EventArgs e)
        {
            // Ovdje dodajte kod za obradu događaja
        }

        private void dgvmeal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ovdje dodajte kod za obradu događaja
        }

        private void ReviewBtn_Click(object sender, EventArgs e)
        {
            if (dvgmeal.SelectedCells.Count > 0)
            {
                int rowIndex = dvgmeal.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dvgmeal.Rows[rowIndex];


                this.Hide();
                ReviewForm reviewForm = new ReviewForm();
                reviewForm.ShowDialog();
                this.Close();

                /*this.Hide();
                ReviewForm reviewForm = new ReviewForm();
                reviewForm.ShowDialog();
                this.Close();*/
            }
        }


        private void FrmMeals_Load(object sender, EventArgs e)
        {
            ShowMeals();
        }
        private void ShowMeals()
        {
            List<Meal> meals = MealRepository.GetMeals();
            dvgmeal.DataSource = meals;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}