using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    public class user
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your username")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string password { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        public string mail { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Please enter your city")]
        public string city { get; set; }

        [Required(ErrorMessage = "Please enter your Name")]
        public string cname { get; set; }
        [Required(ErrorMessage = "Please enter your Email")]
        public string cmail { get; set; }
        [Required(ErrorMessage = "Please enter your Phone")]
        public string cphone { get; set; }
        [Required(ErrorMessage = "Please enter your valuable feedback")]
        public string feedback { get; set; }

    }
}
