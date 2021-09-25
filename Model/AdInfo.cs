using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Model
{
    public class AdInfo
    {
        [Required(ErrorMessage = "Adid missing")]
        public Int32 AdId { get; set; }
        [MaxLength(20,ErrorMessage = "Please give below 20"), Required(ErrorMessage = "Title missing")]
        [Display(Name = "Title")]
        public string AdTitle { get; set; } 
        
        [StringLength(10, ErrorMessage = "Please check length")]
        public string Location { get; set; }
        public string City { get; set; }
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please check phone number")]
        public string CustomerMob { get; set; }
    }

    public record adCustomer
    {
        public string custName { get; init; }
        public string mobile { get; init; }
    }
}
