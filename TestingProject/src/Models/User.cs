using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingProject.Models

{
    public class User
    {
        public User()
        {
            Subjects = new List<Subject>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Display(Name = "Username")]
        [StringLength(50, ErrorMessage = "Username cannot be longer than 50 characters", MinimumLength = 1)]
        public string Username { get; set; }
        [Display(Name = "Name")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters", MinimumLength = 1)]
        public string Name { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        [StringLength(200, ErrorMessage = "Name cannot be longer than 200 characters", MinimumLength = 1)]
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [EmailAddress]
        [Required]
        [Display(Name = "Email")]
        [StringLength(200)]
        public string Email { get; set; }    
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }  
        public virtual Role Role { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }

    }
}
