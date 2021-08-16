using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RestaurantSystem.Models.Metadata
{
    public class TableNew
    {
        [Key]
        public int UserId { get; set; }
        [Display(Name ="User name")]
        [Required(ErrorMessage = "UserName is required!")]
        public string UserName { get; set; }
        [Display(Name ="FirstName")]
        [Required(ErrorMessage = "First Name is required!")]
        public string FirstName { get; set; }
        [Display(Name ="LastName")]
        [Required(ErrorMessage = "Last Name is required!")]
        public string LastName { get; set; }
        [Display(Name ="Email")]
        [Required(ErrorMessage = "Email is required!")]
        [RegularExpression(@"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$", ErrorMessage = "Please enter valid email")]
        public string Email { get; set; }
        [Display(Name ="Password")]
        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Please must be same!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}