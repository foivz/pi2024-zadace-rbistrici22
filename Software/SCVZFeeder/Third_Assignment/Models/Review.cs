namespace Third_Assignment.Models
{
    public class Review
    {
        public int ReviewID { get; set; }  // Jedinstveni ID recenzije
        public int MealID { get; set; }    // ID obroka na koji se recenzija odnosi
        public int Score { get; set; }     // Ocjena recenzije (npr. od 1 do 5)
        public string Comment { get; set; }  // Komentar recenzije

        // Konstruktor bez parametara
        public Review() { }

        // Konstruktor s parametrima
        public Review(int reviewID, int mealID, int score, string comment)
        {
            ReviewID = reviewID;
            MealID = mealID;
            Score = score;
            Comment = comment;
        }

        // Override metode ToString za lakše ispisivanje informacija o recenziji
        public override string ToString()
        {
            return $"ReviewID: {ReviewID}, MealID: {MealID}, Score: {Score}, Comment: {Comment}";
        }
    }
}
