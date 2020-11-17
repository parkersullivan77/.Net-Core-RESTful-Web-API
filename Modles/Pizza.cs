using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaProblems.Modles{
    
    public class Pizza{
        [Key]
        public int id {get;set;}
        
        [Required]
        [MaxLength(250)]
        public string name { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string dough_type { get; set; }
        
        [Required]
        [MaxLength(250)]
        public bool isCalzone { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string ingredients { get; set; }
    }
}