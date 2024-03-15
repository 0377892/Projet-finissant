using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site_Core.Models
{
    public class Job
    {
        [Key]
        [DisplayName(displayName: "Job ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [StringLength(255, ErrorMessage = "Title is too long")]
        [DisplayName(displayName: "Job Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [StringLength(255, ErrorMessage = "Description is too long")]
        [DisplayName(displayName: "Job Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [StringLength(255, ErrorMessage = "Location is too long")]
        [DisplayName(displayName: "Job Location")]
        public string Location { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [DisplayName(displayName: "Job Start Date")]
        public DateTime JobStart { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [DisplayName(displayName: "Job End Date")]
        public DateTime JobEnd { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [DisplayName(displayName: "Skills Used")]
        public List<Site_Utilities.TagsSkillsEnum> Skills { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [DisplayName(displayName: "Tools Used")]
        public List<Site_Utilities.TagsToolsEnum> Tools { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [DisplayName(displayName: "Employer ID")]
        [ForeignKey("Employer")]
        public int EmployerId { get; set; }
    }
}
