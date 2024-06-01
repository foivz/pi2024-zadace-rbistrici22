using DBLayer;
using System;
using System.Collections.Generic;
using Third_Assignment.Models;

namespace Third_Assignment.Repositories
{
    public class MealRepository
    {
        // Metoda za dohvaćanje svih jela iz baze podataka
        public static List<Meal> GetMeals()
        {
            List<Meal> meals = new List<Meal>();
            string sql = "SELECT * FROM Meals";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Meal meal = new Meal
                {
                    MealID = Convert.ToInt32(reader["MealID"]),
                    Name = reader["Meal"].ToString(),  // Promijenjeno na Name
                    Ingredients = reader["ingredients"].ToString(),
                    Description = reader["Description"].ToString()
                };
                meals.Add(meal);
            }
            reader.Close();
            DB.CloseConnection();
            return meals;
        }
    }
}
