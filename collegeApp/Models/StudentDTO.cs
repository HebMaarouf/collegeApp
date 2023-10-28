using collegeApp.Models.Validators;
using System.ComponentModel.DataAnnotations;

namespace collegeApp.Models
{
    public class StudentDTO
    {
        //[ValidateNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "student name is required")]
        [StringLength(20)]
        public string StudentName { get; set; }
        
        [EmailAddress(ErrorMessage = "please enter email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "address is required")]
        public string Address { get; set; }
        /* [Range(10,20)]
         public int Age { get; set; }

         public string password { get; set; }

         [Compare(nameof(password))]
         public string confirmPassword { get; set; }*/
       /* [DateCheckAttribute]
        public DateTime AddmissionDate { get; set; }
   */ }
}

