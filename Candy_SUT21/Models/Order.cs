using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Candy_SUT21.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [Required (ErrorMessage ="Please enter your First Name!")]
        [Display(Name ="First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required (ErrorMessage ="Please enter your Last Name!")]
        [Display(Name ="Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your Adress!")]
        [Display(Name = "Street Adress")]
        [StringLength(100)]
        public string Adress { get; set; }

        [Required(ErrorMessage ="Please Enter Your City Name!")]
        [Display(Name = "City")]
        [StringLength(50)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter Your Zip Code!")]
        [Display(Name = "Zip Code")]
        [StringLength(20,MinimumLength =4)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please Enter Your Phone Number!")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
