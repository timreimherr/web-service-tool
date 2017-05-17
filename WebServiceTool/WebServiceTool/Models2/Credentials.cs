using System.ComponentModel.DataAnnotations;

namespace WebServiceTool.Models2
{
    public class Credentials
    {
        [Required(ErrorMessage = "Company Login ID is required")]
        [Display(Name = "Company Login ID")]
        public string CompanyID { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
