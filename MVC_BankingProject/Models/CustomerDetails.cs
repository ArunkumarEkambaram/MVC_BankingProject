using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_BankingProject.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 10)]
        public string MobileNumber { get; set; }

        [Required]
        [StringLength(200)]
        [EmailAddress]
        public string EmailId { get; set; }

        public ICollection<Address> Addresses { get; set; }

        [Required]
        public string CustomerId { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? DeactivatedDate { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string AddressLine1 { get; set; }

        [StringLength(100)]
        public string AddressLine2 { get; set; }

        [Required]
        [StringLength(10)]
        public string DoorNo { get; set; }

        [StringLength(50)]
        public string FlatNo { get; set; }

        [StringLength(100)]
        public string StreetName { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }
                
        [StringLength(100)]
        public string Country { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}