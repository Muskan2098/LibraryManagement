using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Role")]
        public string Role { get; set; }
    }

    public class Student
    {

        public int Id { get; set; }

        public string Name  { get; set; }
         
        public string RollNumber { get; set; }
        public string Gender { get; set; }

        public string DateOfBirth { get; set; }

        public string Email { get; set; }
        
        public string Password { get; set; }

        public string ConfirmPass { get; set; }

    }

    public class Staff
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPass { get; set; }

    }

    public class Book
    {

        public int Id { get; set; }

        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Category  { get; set; }
        public string YearOfPublish { get; set; }
        public string Price { get; set; }

        

    }

}
