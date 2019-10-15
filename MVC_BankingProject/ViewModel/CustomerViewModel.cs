using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_BankingProject.ViewModel
{
    public class NewCustomerViewModel
    {        
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "First name should be atleast 3 character length")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime? BirthDate { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 10)]
        public string MobileNumber { get; set; }

        [Required]
        [StringLength(200)]
        [EmailAddress]
        public string EmailId { get; set; }
    }

    public class AddressViewModel
    {
        [Required]
        [Display(Name = "Address Line1")]
        [StringLength(100,MinimumLength =2, ErrorMessage ="Address Line1 should atleast 2 character length and should not be more than 100 characters")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line2")]
        [StringLength(100, ErrorMessage ="Address Line2 should not be more than 100 characters")]
        public string AddressLine2 { get; set; }

        [Required]
        [Display(Name = "Door No")]
        [StringLength(10, ErrorMessage = "Door No should not be greater than 10 characters")]
        public string DoorNo { get; set; }

        [Display(Name ="Flat No / Name")]
        [StringLength(50, ErrorMessage = "Flat No / Name should be greater than 50 characters")]
        public string FlatNo { get; set; }      

        [Required]
        [Display(Name ="Street Name")]
        public string StreetName { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        // [Required]
        public int CustomerId { get; set; }
    }
}