using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Third_Assignment.Models;

namespace Third_Assignment.Repositories
{
    public class ReviewRepository
    {
        // Metoda za dohvaćanje svih recenzija iz baze podataka
        public static List<Review> GetReviews()
        {
            List<Review> reviews = new List<Review>();
            string sql = "SELECT * FROM Review";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Review review = CreateObject(reader);
                reviews.Add(review);
            }
            reader.Close();
            DB.CloseConnection();
            return reviews;
        }

        // Metoda za dohvaćanje recenzije po ID-u obroka
        public static Review GetReviewByMealID(int mealID)
        {
            Review review = null;
            string sql = $"SELECT * FROM Review WHERE MealID = {mealID}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                review = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return review;
        }

        // Metoda za dodavanje nove recenzije
        public static void AddReview(Review review)
        {
            string sql = $"INSERT INTO Review (MealID, Score, Comment) VALUES ({review.MealID}, {review.Score}, '{review.Comment}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        // Metoda za ažuriranje postojeće recenzije
        public static void UpdateReview(Review review)
        {
            string sql = $"UPDATE Review SET Score = {review.Score}, Comment = '{review.Comment}' WHERE ReviewID = {review.ReviewID}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        // Pomoćna metoda za kreiranje objekta Review iz SqlDataReader-a
        private static Review CreateObject(SqlDataReader reader)
        {
            return new Review
            {
                ReviewID = Convert.ToInt32(reader["ReviewID"]),
                MealID = Convert.ToInt32(reader["MealID"]),
                Score = Convert.ToInt32(reader["Score"]),
                Comment = reader["Comment"].ToString()
            };
        }
    }
}
