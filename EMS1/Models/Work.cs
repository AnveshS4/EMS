using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace EMS1.Models
{
    public class Work
    {
        
        [Required, NotNull]
        public int WorkId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }


        [Required]
        public DateTime EndDate { get; set; }

        [Required, NotNull]
        public string WorkStatus { get; set; }




       
        public int Employee_ID  { get; set; }


      

       
    }

}
