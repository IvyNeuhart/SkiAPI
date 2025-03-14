namespace SkiAPI.Models {
    public class SkiModel {
        public int Id { get; set; }
        public string Name { get; set; }
        

        // Relational Information (A Ski Model is manufactured by a single Ski Brand)
        
        // Foreign Key
        // This column links SkiModel to SkiBrand by storing the SkiBrand's Id (primary key).
        public int SkiBrandId {get; set; }

        // Navigation Property
        // This allows you to access the related SkiBrand object directly in code.
        public SkiBrand SkiBrand { get; set; }
    }
}