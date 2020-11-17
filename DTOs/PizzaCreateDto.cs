using System.ComponentModel.DataAnnotations;

namespace PizzaProblems.DTOs{
    
    public class PizzaCreateDto{
        
        [Required]
        [MaxLength(250)]
        public string name { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string dough_type { get; set; }
        
        [Required]
        public bool isCalzone { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string ingredients { get; set; }
    }
}