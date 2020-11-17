namespace PizzaProblems.DTOs{
    
    public class PizzaReadDtos{
        
        public int id { get;set; }
        public string name { get; set; }
        public string dough_type { get; set; }
        public bool isCalzone { get; set; }
        public string ingredients { get; set; }
    }
}