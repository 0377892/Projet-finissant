using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Site_Core.Models
{
    public class Employer
    {
        [Key]
        [DisplayName(displayName: "Employer ID")]
        public int ID { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [StringLength(255, ErrorMessage = "Name is too long")]
        [DisplayName(displayName: "Employer Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [StringLength(255, ErrorMessage = "Location is too long")]
        [DisplayName(displayName: "Logo URL")]
        public string Logo { get; set; }

        [ValidateNever]
        [DisplayName(displayName: "Jobs")]
        public List<Job> Jobs { get; set; }
    }
}
