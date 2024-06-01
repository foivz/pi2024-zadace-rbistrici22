﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            ReviewRepository.SaveReview(mealID, score, comment);
            MessageBox.Show("Review submitted successfully!");

            this.Close();
        }
    }

