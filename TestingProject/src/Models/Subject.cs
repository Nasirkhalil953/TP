using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingProject.Models
{
    public class Subject
    {
        [Required]
        public int Id { get; set; }
        [StringLength(20,ErrorMessage = "Name cannot be longer than 20 characters", MinimumLength = 1)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }

    }
}
